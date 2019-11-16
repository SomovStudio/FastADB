/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 17:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FastADB.data;

namespace FastADB.client
{
	/// <summary>
	/// Description of SettingsForm.
	/// </summary>
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void SettingsFormLoad(object sender, EventArgs e)
		{
			DataResources.checkFolders();
			
			pathAdbTextBox.Text = DataResources.adbSysPath;
			pathAaptTextBox.Text = DataResources.aaptSysPath;
			pathMonitorTextBox.Text = DataResources.ddmsSysPath;
			pathBuildsTextBox.Text = DataResources.buildsPath;
			pathCommandsTextBox.Text = DataResources.commandsPath;
			pathFilesTextBox.Text = DataResources.filesPath;
			
		}
		void SettingsFormFormClosed(object sender, FormClosedEventArgs e)
		{
			DataForms.FSettings = null;
		}
		void Button2Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "adb.exe";
			openFileDialog1.Filter = "adb.exe|adb.exe|*.*|*.*";
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
				pathAdbTextBox.Text = openFileDialog1.FileName;
			}
		}
		void Button4Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "aapt.exe";
			openFileDialog1.Filter = "aapt.exe|aapt.exe|*.*|*.*";
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
				pathAaptTextBox.Text = openFileDialog1.FileName;
			}
		}
		void Button3Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "monitor.exe";
			openFileDialog1.Filter = "monitor.exe|monitor.exe|*.*|*.*";
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
				pathMonitorTextBox.Text = openFileDialog1.FileName;
			}
		}
		void Button6Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = DataResources.buildsPath;
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK){
				pathBuildsTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
			}
		}
		void Button7Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = DataResources.commandsPath;
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK){
				pathCommandsTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
			}
		}
		void Button8Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = DataResources.filesPath;
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK){
				pathFilesTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
			}
		}
		void Button19Click(object sender, EventArgs e)
		{
			Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			DataResources.adbSysPath = pathAdbTextBox.Text;
			DataResources.aaptSysPath = pathAaptTextBox.Text;
			DataResources.ddmsSysPath = pathMonitorTextBox.Text;
			DataResources.buildsPath = pathBuildsTextBox.Text;
			DataResources.commandsPath = pathCommandsTextBox.Text;
			DataResources.filesPath = pathFilesTextBox.Text;
			
			DataResources.saveConfigFile();
			DataResources.updateDefaultScripts();
			Close();
		}
		
		
	}
}
