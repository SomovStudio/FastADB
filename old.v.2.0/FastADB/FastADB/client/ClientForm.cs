/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using FastADB.data;

namespace FastADB.client
{
	/// <summary>
	/// Description of ClientForm.
	/// </summary>
	public partial class ClientForm : Form
	{
		public ClientForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/* ===============================================================================
		 * ПРОВЕРКА ПОДКЛЮЧЕНИЯ УСТРОЙСТВА
		 */		
		delegate void AddConsoleItem(String message);
      	AddConsoleItem myDelegate;
		Process process;
		
		public void addConsoleItemMethod(String message)
		{
			DataResources.consoleMessage(message);
		}
		
		public void checkDeviceConnect()
		{
			try{
				
				process = new Process();
				process.StartInfo.FileName = @DataResources.commandsPath + "adb_devices.bat";
				process.StartInfo.Arguments = "/k";
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.UseShellExecute = false;
				process.ErrorDataReceived += P_ErrorDataReceived;
				process.OutputDataReceived += P_OutputDataReceived;
				process.Start();
				process.BeginErrorReadLine();
				process.BeginOutputReadLine();
				
			}catch(Exception ex){
				//DataResources.consoleMessage("ОШИБКА: Прогремме не удалось запустить процесс adb devices");
				DataResources.consoleMessage("ОШИБКА: " + ex.Message);
			}
		}
		
		void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
		{
			try{
				this.Invoke(this.myDelegate, new object[] {e.Data.ToString()});
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
		/* =============================================================================== */
		
		
		public void consoleMessage(String message)
		{
      		consoleRichTextBox.Text = consoleRichTextBox.Text + message + Environment.NewLine;
			consoleRichTextBox.Select(consoleRichTextBox.Text.Length, consoleRichTextBox.Text.Length);
      		consoleRichTextBox.ScrollToCaret();
		}
		
		void ClientFormLoad(object sender, EventArgs e)
		{
			myDelegate = new AddConsoleItem(addConsoleItemMethod);
			
			if(DataResources.helpShow){
				DataForms.FHelp = new HelpForm();
				DataForms.FHelp.MdiParent = DataForms.FClient;
				DataForms.FHelp.Show();
			}

			DataResources.consoleMessage("FastADB версия 1.1 (последнее обновление: 08.11.2018)");
			DataResources.consoleMessage("Проверка подключения устройства...");
			checkDeviceConnect();
		}
		void ClientFormFormClosed(object sender, FormClosedEventArgs e)
		{
			foreach(var p in Process.GetProcessesByName("adb"))
			{
				p.Kill();
			}
			DataResources.consoleMessage("Все процессы ADB удалены");
			DataForms.FMain.Close();
		}
		void ПапкаПрограммыToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				Process.Start(DataResources.folderResource);
			}catch(Exception ex){
				DataResources.consoleMessage("ОШИБКА: " + ex.Message);
			}
		}
		void ЗакрытьПрограммуToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		void ADBDevicesToolStripMenuItemClick(object sender, EventArgs e)
		{
			checkDeviceConnect();
		}
		void LinkLabel10LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			checkDeviceConnect();
		}
		void УдалитьВсеПроцессыADBToolStripMenuItemClick(object sender, EventArgs e)
		{
			foreach(var p in Process.GetProcessesByName("adb"))
			{
				p.Kill();
			}
			DataResources.consoleMessage("Все процессы ADB удалены");
		}
		void LinkLabel11LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			foreach(var p in Process.GetProcessesByName("adb"))
			{
				p.Kill();
			}
			DataResources.consoleMessage("Все процессы ADB удалены");
		}
		void ДиспетчерУстройствToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				Process.Start("devmgmt.msc");
			}catch(Exception ex){
				DataResources.consoleMessage("ОШИБКА: " + ex.Message);
			}
		}
		void СистемнаяКонсольToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				Process.Start("cmd.exe");
			}catch(Exception ex){
				DataResources.consoleMessage("ОШИБКА: " + ex.Message);
			}
		}
		void ADBLogToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FLog == null){
				DataForms.FLog = new LogForm();
				DataForms.FLog.MdiParent = DataForms.FClient;
				DataForms.FLog.Show();
			}
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataForms.FLog == null){
				DataForms.FLog = new LogForm();
				DataForms.FLog.MdiParent = DataForms.FClient;
				DataForms.FLog.Show();
			}
		}
		void ПомощьToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FHelp == null){
				DataForms.FHelp = new HelpForm();
				DataForms.FHelp.MdiParent = DataForms.FClient;
				DataForms.FHelp.Show();
			}
		}
		void НастройкиToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FSettings == null){
				DataForms.FSettings = new SettingsForm();
				DataForms.FSettings.MdiParent = DataForms.FClient;
				DataForms.FSettings.Show();
			}
		}
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataForms.FScreenhot == null){
				DataForms.FScreenhot = new ScreenshotForm();
				DataForms.FScreenhot.MdiParent = DataForms.FClient;
				DataForms.FScreenhot.Show();
			}
		}
		void ADBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FScreenhot == null){
				DataForms.FScreenhot = new ScreenshotForm();
				DataForms.FScreenhot.MdiParent = DataForms.FClient;
				DataForms.FScreenhot.Show();
			}
		}
		void ADBScreenrecordToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FScreenrecord == null){
				DataForms.FScreenrecord = new ScreenrecordForm();
				DataForms.FScreenrecord.MdiParent = DataForms.FClient;
				DataForms.FScreenrecord.Show();
			}
		}
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataForms.FScreenrecord == null){
				DataForms.FScreenrecord = new ScreenrecordForm();
				DataForms.FScreenrecord.MdiParent = DataForms.FClient;
				DataForms.FScreenrecord.Show();
			}
		}
		void ADBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FPull == null){
				DataForms.FPull = new PullForm();
				DataForms.FPull.MdiParent = DataForms.FClient;
				DataForms.FPull.Show();
			}
		}
		void LinkLabel4LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataForms.FInstall == null){
				DataForms.FInstall = new InstallForm();
				DataForms.FInstall.MdiParent = DataForms.FClient;
				DataForms.FInstall.Show();
			}
		}
		void ADBInstallToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FInstall == null){
				DataForms.FInstall = new InstallForm();
				DataForms.FInstall.MdiParent = DataForms.FClient;
				DataForms.FInstall.Show();
			}
		}
		void LinkLabel5LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataForms.FMonkey == null){
				DataForms.FMonkey = new MonkeyForm();
				DataForms.FMonkey.MdiParent = DataForms.FClient;
				DataForms.FMonkey.Show();
			}
		}
		void ADBMonkeyToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FMonkey == null){
				DataForms.FMonkey = new MonkeyForm();
				DataForms.FMonkey.MdiParent = DataForms.FClient;
				DataForms.FMonkey.Show();
			}
		}
		void AAPTDumpBadgingToolStripMenuItemClick(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = DataResources.buildsPath;
			openFileDialog1.Filter = "*.apk|*.apk";
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
				String filename = DataResources.commandsPath + "aapt_dump_badging.bat";
				DataResources.saveFile(filename, DataResources.initAAPT(openFileDialog1.FileName));
				
				try{
					process = new Process();
					process.StartInfo.FileName = filename;
					process.StartInfo.Arguments = "/k";
					process.StartInfo.RedirectStandardError = true;
					process.StartInfo.RedirectStandardInput = true;
					process.StartInfo.RedirectStandardOutput = true;
					process.StartInfo.CreateNoWindow = true;
					process.StartInfo.UseShellExecute = false;
					process.ErrorDataReceived += P_ErrorDataReceived;
					process.OutputDataReceived += P_OutputDataReceived;
					process.Start();
					process.BeginErrorReadLine();
					process.BeginOutputReadLine(); 
					
				}catch(Exception ex){
					DataResources.consoleMessage("ОШИБКА: " + ex.Message);
				}
			}
		}
		void DDMSToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				process = new Process();
				process.StartInfo.FileName = DataResources.commandsPath + "ddms.bat";
				process.StartInfo.Arguments = "/k";
				process.StartInfo.RedirectStandardError = true;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.UseShellExecute = false;
				process.ErrorDataReceived += P_ErrorDataReceived;
				process.OutputDataReceived += P_OutputDataReceived;
				process.Start();
				process.BeginErrorReadLine();
				process.BeginOutputReadLine(); 
				
			}catch(Exception ex){
				DataResources.consoleMessage("ОШИБКА: " + ex.Message);
			}
		}
		void КонвертерСобытийToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FConverter == null){
				DataForms.FConverter = new ConverterForm();
				DataForms.FConverter.MdiParent = DataForms.FClient;
				DataForms.FConverter.Show();
			}
		}
		void LinkLabel6LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataForms.FGetevent == null){
				DataForms.FGetevent = new GeteventForm();
				DataForms.FGetevent.MdiParent = DataForms.FClient;
				DataForms.FGetevent.Show();
			}
		}
		void ADBGeteventToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(DataForms.FGetevent == null){
				DataForms.FGetevent = new GeteventForm();
				DataForms.FGetevent.MdiParent = DataForms.FClient;
				DataForms.FGetevent.Show();
			}
		}
		void LinkLabel7LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(DataForms.FPull == null){
				DataForms.FPull = new PullForm();
				DataForms.FPull.MdiParent = DataForms.FClient;
				DataForms.FPull.Show();
			}
		}
		void ОПрограммеToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Программа: FastADB" + Environment.NewLine +
			                "Разработчик: Сомов Евгений Павлович" + Environment.NewLine +
			                "Лицензия: GNU" + Environment.NewLine +
			                "Версия 1.1" + Environment.NewLine +
			                "Дата последнего обновления: 08.11.2018" + Environment.NewLine +
			                "Сайт разработчика: https://somov-qa.github.io/",
			                "О программе", MessageBoxButtons.OK);
		}
		void ОчиститьКонсольToolStripMenuItemClick(object sender, EventArgs e)
		{
			consoleRichTextBox.Clear();
			DataResources.consoleMessage("FastADB версия 1.1 (последнее обновление: 08.11.2018)");
			DataResources.consoleMessage("Проверка подключения устройства...");
			checkDeviceConnect();
		}
		void КопироватьToolStripMenuItemClick(object sender, EventArgs e)
		{
			try{
				Clipboard.SetText(consoleRichTextBox.SelectedText);	
			}catch{
				
			}
		}
		
		
	}
}
