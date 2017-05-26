/*
 * Создано в SharpDevelop.
 * Пользователь: Cartish
 * Дата: 26.05.2017
 * Время: 9:08
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SomovStudio.QA;

namespace FastADB
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		String programPath;
		String folderResource;
		
		void applyConcole()
		{
			if(!Directory.Exists(folderResource)){
				Directory.CreateDirectory(folderResource);
			}
			
			if(!File.Exists(folderResource + "\\console.bat")){ 
				File.Create(folderResource + "\\console.bat").Close();
				FileStream fs = File.OpenWrite(folderResource + "\\console.bat");
				Byte[] info = new UTF8Encoding(true).GetBytes(textBoxConsole.Text);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(folderResource + "\\console.bat");
				File.Create(folderResource + "\\console.bat").Close();
				FileStream fs = File.OpenWrite(folderResource + "\\console.bat");
				Byte[] info = new UTF8Encoding(true).GetBytes(textBoxConsole.Text);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			try{
				Process.Start(folderResource + "\\console.bat");
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		
		void initScreenshot()
		{
			String batCommand = "adb devices" + Environment.NewLine + 
				"monkeyrunner " + textBoxFolderScreenshots.Text + "script.py";
			textBox5.Text = batCommand;
			
			String screenshotPath = textBoxFolderScreenshots2.Text + textBoxScreenshotFile.Text;
			screenshotPath = screenshotPath.Replace("\\","/");
			
			String pyScript = "from com.android.monkeyrunner import MonkeyRunner, MonkeyDevice" + Environment.NewLine + 
				"device = MonkeyRunner.waitForConnection();" + Environment.NewLine + Environment.NewLine + 
				"# SAVE - SCREENSHOT" + Environment.NewLine + 
				"result = device.takeSnapshot();" + Environment.NewLine + 
				"result.writeToFile('" + screenshotPath + "','png')" + Environment.NewLine + 
				"print(\"SAVE - SCREENSHOT!\");" + Environment.NewLine + 
				"MonkeyRunner.sleep(5.0);";
			textBox6.Text = pyScript;
		}
		
		void initLog()
		{
			String batCommand = "adb devices" + Environment.NewLine + 
				"adb logcat -d > " + textBoxFolderLog.Text + "log.txt" + Environment.NewLine +
				"@echo"+ Environment.NewLine +
				"@echo PRESS ANY KEY TO FINISH!"+ Environment.NewLine +
				"@pause";
			textBox9.Text = batCommand;
		}
		
		/* =================================================================================================
		 * РАЗДЕЛ: СОБЫТИЙ
		 * =================================================================================================
		 */	
		void MainFormLoad(object sender, EventArgs e)
		{
			//определяем расположение программы (путь)
			programPath = Environment.CurrentDirectory + "\\";
			//расположение папки ресурсов
			folderResource = programPath + "resource\\";
			
			//Проверка существования папки
			if(!Directory.Exists(folderResource)){
				//папки нет, она будет создана заново
				Directory.CreateDirectory(folderResource);
			}
			
			textBoxFolderResource.Text = folderResource;
			textBoxFolderScreenshots.Text = folderResource + "screenshots\\";
			textBoxFolderScreenshots2.Text = textBoxFolderScreenshots.Text;
			Directory.CreateDirectory(textBoxFolderScreenshots.Text);
			textBoxFolderLog.Text = folderResource + "logs\\";
			Directory.CreateDirectory(textBoxFolderLog.Text);
			textBoxFolderDDMS.Text = folderResource + "ddms\\";
			Directory.CreateDirectory(textBoxFolderDDMS.Text);
			textBoxFolderShell.Text = folderResource + "shell\\";
			Directory.CreateDirectory(textBoxFolderShell.Text);
			textBoxFolderStress.Text = folderResource + "stress\\";
			Directory.CreateDirectory(textBoxFolderStress.Text);
			
			initScreenshot();
			initLog();
		}
		void ToolStripStatusLabel1Click(object sender, EventArgs e)
		{
			FormAbout FAbout = new FormAbout();
			FAbout.ShowDialog();
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(linkLabel1.Text);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(linkLabel2.Text);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(linkLabel3.Text);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void Button7Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderResource.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void Button8Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderScreenshots.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void Button9Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				textBoxFolderLog.Text = folderBrowserDialog1.SelectedPath + "\\";
				initLog();
			}
		}
		void Button10Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderDDMS.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void Button11Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderShell.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void ButtonFolderStressClick(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderStress.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void Button12Click(object sender, EventArgs e)
		{
			applyConcole();
		}
		void Button13Click(object sender, EventArgs e)
		{
			try{
				Process.Start("cmd.exe");
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void TextBoxScreenshotFileTextChanged(object sender, EventArgs e)
		{
			initScreenshot();
		}
		void Button3Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK){
				textBoxFolderScreenshots2.Text = folderBrowserDialog1.SelectedPath + "\\";
				initScreenshot();
			}
		}
		void TextBoxFolderScreenshots2TextChanged(object sender, EventArgs e)
		{
			initScreenshot();
		}
		void Button2Click(object sender, EventArgs e)
		{
			TestingAndroid.AdbScreenshot(textBoxFolderScreenshots2.Text, 
			                             textBoxFolderScreenshots.Text + "screenshot.bat",
			                             textBox5.Text,
			                             textBoxFolderScreenshots.Text + "script.py",
			                             textBox6.Text);
		}
		void Button14Click(object sender, EventArgs e)
		{
			try{
				if(File.Exists(textBoxFolderScreenshots2.Text + textBoxScreenshotFile.Text)){
					Process.Start(textBoxFolderScreenshots2.Text + textBoxScreenshotFile.Text);
				}else{
					MessageBox.Show("Программа не смогла найти файл " + textBoxFolderScreenshots2.Text + textBoxScreenshotFile.Text, "Сообщение");
				}
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void Button15Click(object sender, EventArgs e)
		{
			try{
				Process.Start(textBoxFolderScreenshots2.Text);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void Button6Click(object sender, EventArgs e)
		{
			TestingAndroid.AdbLog(textBoxFolderLog.Text, textBoxFolderLog.Text + "log.bat", textBox9.Text);
		}
		void Button16Click(object sender, EventArgs e)
		{
			try{
				Process.Start(textBoxFolderLog.Text);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void TextBoxFolderLogTextChanged(object sender, EventArgs e)
		{
			initLog();
		}
		void Button1Click(object sender, EventArgs e)
		{
			TestingAndroid.AdbDDMS(textBoxFolderDDMS.Text, textBoxFolderDDMS.Text + "ddms.bat", textBox2.Text);
		}
	}
}
