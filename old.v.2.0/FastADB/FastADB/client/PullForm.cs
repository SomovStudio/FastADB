/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 07.10.2018
 * Time: 12:05
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
	/// Description of PullForm.
	/// </summary>
	public partial class PullForm : Form
	{
		public PullForm()
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
		
		void PullFormLoad(object sender, EventArgs e)
		{
			myDelegate = new AddConsoleItem(addConsoleItemMethod);

			DataResources.checkFolders();
			String filename = DataResources.commandsPath + "adb_pull.bat";
			if(!File.Exists(filename)){
				DataResources.saveFile(filename, DataResources.initPull("video.mp4", "/sdcard/", DataResources.filesPath));
			}
			scriptTextBox.Text = DataResources.readFile(filename);
			
			filenameTextBox.Text = "video.mp4";
			folderDeviceTextBox.Text = "/sdcard/";
			folderPcTextBox.Text = DataResources.filesPath;
			
			linkLabel5.Select();
			pathLabel.Text = filename;
		}
		void PullFormFormClosed(object sender, FormClosedEventArgs e)
		{
			if(P != null){
				P.Close();
				DataResources.consoleMessage("Процесс pull - остановлен");
			}
			DataForms.FPull = null;
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.InitialDirectory = DataResources.commandsPath;
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
			saveFileDialog1.FileName = "adb_pull.bat";
			if(saveFileDialog1.ShowDialog() == DialogResult.OK){
				pathLabel.Text = saveFileDialog1.FileName;
				if(DataResources.saveFile(saveFileDialog1.FileName, scriptTextBox.Text) == true){
					DataResources.consoleMessage("Файл " + pathLabel.Text + " сохранён");
				}
			}
		}
		void LinkLabel4LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				Process.Start(folderPcTextBox.Text);
			}catch(Exception ex){
				DataResources.consoleMessage("ОШИБКА: " + ex.Message);
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
				P = null;
				DataResources.consoleMessage("Процесс screencap - остановлен");
			}
		}
		void FilenameTextBoxTextChanged(object sender, EventArgs e)
		{
			scriptTextBox.Text = DataResources.initPull(filenameTextBox.Text, folderDeviceTextBox.Text, folderPcTextBox.Text);
		}
		void FolderDeviceTextBoxTextChanged(object sender, EventArgs e)
		{
			scriptTextBox.Text = DataResources.initPull(filenameTextBox.Text, folderDeviceTextBox.Text, folderPcTextBox.Text);
		}
		void Button1Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = DataResources.filesPath;
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK){
				folderPcTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
				scriptTextBox.Text = DataResources.initPull(filenameTextBox.Text, folderDeviceTextBox.Text, folderPcTextBox.Text);
			}
		}
		void LinkLabel7LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			scriptTextBox.Text = DataResources.initPullAndRm(filenameTextBox.Text, folderDeviceTextBox.Text, folderPcTextBox.Text);
		}
		
	}
}
