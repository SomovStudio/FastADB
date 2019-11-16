/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 08.10.2018
 * Time: 12:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FastADB.data;

namespace FastADB.client
{
	/// <summary>
	/// Description of GeteventForm.
	/// </summary>
	public partial class GeteventForm : Form
	{
		public GeteventForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public delegate void AddConsoleItem(String message);
      	public AddConsoleItem myDelegate;
		Process P;
		
		public void addConsoleItemMethod(String message)
		{
			DataResources.consoleMessage(message);
		}
		
		void GeteventFormLoad(object sender, EventArgs e)
		{
			myDelegate = new AddConsoleItem(addConsoleItemMethod);

			DataResources.checkFolders();
			String filename = DataResources.commandsPath + "adb_getevent.bat";
			if(!File.Exists(filename)){
				DataResources.saveFile(filename, DataResources.initGetevent(DataResources.filesPath + "getevents.txt"));
			}
			scriptTextBox.Text = DataResources.readFile(filename);
			
			filenameTextBox.Text = "getevents.txt";
			folderPcTextBox.Text = DataResources.filesPath;
			
			linkLabel5.Select();
			pathLabel.Text = filename;
		}
		void GeteventFormFormClosed(object sender, FormClosedEventArgs e)
		{
			if(P != null){
				P.Close();
				DataResources.consoleMessage("Процесс getevent - остановлен");
			}
			DataForms.FGetevent = null;
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.InitialDirectory = DataResources.commandsPath;
			openFileDialog1.FileName = "";
			openFileDialog1.Filter = "*.bat|*.bat";
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
				scriptTextBox.Text = DataResources.readFile(openFileDialog1.FileName);
				pathLabel.Text = openFileDialog1.FileName;
				DataResources.consoleMessage("Файл " + pathLabel.Text + " открыт");
			}
		}
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataResources.saveFile(pathLabel.Text, scriptTextBox.Text) == true){
				DataResources.consoleMessage("Файл " + pathLabel.Text + " сохранён");
			}
		}
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			saveFileDialog1.InitialDirectory = DataResources.commandsPath;
			saveFileDialog1.FileName = "adb_getevent.bat";
			if(saveFileDialog1.ShowDialog() == DialogResult.OK){
				pathLabel.Text = saveFileDialog1.FileName;
				if(DataResources.saveFile(saveFileDialog1.FileName, scriptTextBox.Text) == true){
					DataResources.consoleMessage("Файл " + pathLabel.Text + " сохранён");
				}
			}
		}
		void LinkLabel4LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataForms.FConverter == null){
				DataForms.FConverter = new ConverterForm();
				DataForms.FConverter.MdiParent = DataForms.FClient;
				DataForms.FConverter.Show();
			}
		}
		void LinkLabel5LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				DataResources.saveFile(pathLabel.Text, scriptTextBox.Text);
				
				P = new Process();
				P.StartInfo.FileName = pathLabel.Text;
				P.StartInfo.Arguments = "/k";
				P.StartInfo.RedirectStandardError = true;
				P.StartInfo.RedirectStandardInput = true;
				P.StartInfo.RedirectStandardOutput = true;
				P.StartInfo.CreateNoWindow = false;
				P.StartInfo.UseShellExecute = false;
				P.ErrorDataReceived += P_ErrorDataReceived;
				P.OutputDataReceived += P_OutputDataReceived;
				P.Start();
				P.BeginErrorReadLine();
				P.BeginOutputReadLine(); 
				
				DataResources.consoleMessage("Закройте консоль чтобы остановить запись событий с устройства");
			}catch(Exception ex){
				DataResources.consoleMessage("ОШИБКА: " + ex.Message);
			}
		}
		void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
		{
			try{
				this.Invoke(this.myDelegate, new object[] {"ОШИБКА: " + e.Data.ToString()});
			}catch(Exception ex){
				
			}
		}		 
		void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			try{
				this.Invoke(this.myDelegate, new object[] {e.Data.ToString()});
			}catch(Exception ex){
				
			}
		}
		void LinkLabel6LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(P != null){
				P.Close();
				DataResources.consoleMessage("Процесс getevent - остановлен");
			}
		}
		void FilenameTextBoxTextChanged(object sender, EventArgs e)
		{
			scriptTextBox.Text = DataResources.initGetevent(folderPcTextBox.Text + filenameTextBox.Text);
		}
		void Button2Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = DataResources.filesPath;
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK){
				folderPcTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
				scriptTextBox.Text = DataResources.initGetevent(folderPcTextBox.Text + filenameTextBox.Text);
			}
		}
		void LinkLabel7LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.InitialDirectory = DataResources.filesPath;
			openFileDialog1.FileName = "events_play.bat";
			openFileDialog1.Filter = "*.bat|*.bat";
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
				try{
					P = new Process();
					P.StartInfo.FileName = openFileDialog1.FileName;
					P.StartInfo.Arguments = "/k";
					P.StartInfo.RedirectStandardError = true;
					P.StartInfo.RedirectStandardInput = true;
					P.StartInfo.RedirectStandardOutput = true;
					P.StartInfo.CreateNoWindow = true;
					P.StartInfo.UseShellExecute = false;
					P.ErrorDataReceived += P_ErrorDataReceived;
					P.OutputDataReceived += P_OutputDataReceived;
					P.Start();
					P.BeginErrorReadLine();
					P.BeginOutputReadLine();
					
				}catch(Exception ex){
					DataResources.consoleMessage("ОШИБКА: " + ex.Message);
				}
			}
		}
		
	}
}
