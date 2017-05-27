/*
 * Создано в SharpDevelop.
 * Пользователь: Somov Studio
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
			if(!Directory.Exists(textBoxFolderConsole.Text)){
				Directory.CreateDirectory(textBoxFolderConsole.Text);
			}
			
			if(!File.Exists(textBoxFolderConsole.Text + "\\console.bat")){ 
				File.Create(textBoxFolderConsole.Text + "\\console.bat").Close();
				FileStream fs = File.OpenWrite(textBoxFolderConsole.Text + "\\console.bat");
				Byte[] info = new UTF8Encoding(true).GetBytes(textBoxConsole.Text);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(textBoxFolderConsole.Text + "\\console.bat");
				File.Create(textBoxFolderConsole.Text + "\\console.bat").Close();
				FileStream fs = File.OpenWrite(textBoxFolderConsole.Text + "\\console.bat");
				Byte[] info = new UTF8Encoding(true).GetBytes(textBoxConsole.Text);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			try{
				Process.Start(textBoxFolderConsole.Text + "\\console.bat");
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		
		void getPackageName(String fileName)
		{
			if(!Directory.Exists(textBoxFolderBuilds.Text)){
				Directory.CreateDirectory(textBoxFolderBuilds.Text);
			}
			
			if(!File.Exists(textBoxFolderBuilds.Text + "\\package_name.bat")){ 
				File.Create(textBoxFolderBuilds.Text + "\\package_name.bat").Close();
				FileStream fs = File.OpenWrite(textBoxFolderBuilds.Text + "\\package_name.bat");
				Byte[] info = new UTF8Encoding(true).GetBytes("aapt dump badging " + fileName + Environment.NewLine + "@pause");
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(textBoxFolderBuilds.Text + "\\package_name.bat");
				File.Create(textBoxFolderBuilds.Text + "\\package_name.bat").Close();
				FileStream fs = File.OpenWrite(textBoxFolderBuilds.Text + "\\package_name.bat");
				Byte[] info = new UTF8Encoding(true).GetBytes("aapt dump badging " + fileName + Environment.NewLine + "@pause");
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			try{
				Process.Start(textBoxFolderBuilds.Text + "\\package_name.bat");
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		
		void initScreenshot()
		{
			String batCommand = 
				"adb devices" + Environment.NewLine +
				"monkeyrunner " + textBoxFolderScreenshots.Text + "script.py";
			textBox5.Text = batCommand;
			
			String screenshotPath = textBoxFolderScreenshots2.Text + textBoxScreenshotFile.Text;
			screenshotPath = screenshotPath.Replace("\\","/");
			
			String pyScript = 
				"from com.android.monkeyrunner import MonkeyRunner, MonkeyDevice" + Environment.NewLine +
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
			String batCommand = 
				"adb devices" + Environment.NewLine +
				"adb logcat -d > " + textBoxFolderLog.Text + "log.txt" + Environment.NewLine +
				"@echo"+ Environment.NewLine +
				"@echo PRESS ANY KEY TO FINISH!"+ Environment.NewLine +
				"@pause";
			textBox9.Text = batCommand;
		}
		
		void initInstallBuild()
		{
			String batCommand = 
				"adb devices" + Environment.NewLine +
				"monkeyrunner " + textBoxFolderBuilds.Text + "script.py";
			textBox4.Text = batCommand;
			
			
			String buildPath = textBox3.Text;
			buildPath = buildPath.Replace("\\","/");
			
			String pyScript = 
				"from com.android.monkeyrunner import MonkeyRunner, MonkeyDevice" + Environment.NewLine +
				"device = MonkeyRunner.waitForConnection();" + Environment.NewLine +
				"device.installPackage('" + buildPath + "');"+ Environment.NewLine +
				"print(\"INSTALL - COMPLETE!\");" + Environment.NewLine + 
				"MonkeyRunner.sleep(5.0);";
			textBox10.Text = pyScript;
		}
		
		void initRemoveBuild()
		{
			String batCommand = 
				"adb devices" + Environment.NewLine +
				"monkeyrunner " + textBoxFolderBuilds.Text + "script.py";
			textBox11.Text = batCommand;
			
			String pyScript = 
				"from com.android.monkeyrunner import MonkeyRunner, MonkeyDevice" + Environment.NewLine +
				"device = MonkeyRunner.waitForConnection();" + Environment.NewLine +
				"device.removePackage('com.package.name');"+ Environment.NewLine +
				"print(\"REMOVE - COMPLETE!\");" + Environment.NewLine + 
				"MonkeyRunner.sleep(5.0);";
			textBox12.Text = pyScript;
		}
		
		void initStartActivity()
		{
			String batCommand = 
				"adb devices" + Environment.NewLine +
				"monkeyrunner " + textBoxFolderBuilds.Text + "script.py";
			textBox13.Text = batCommand;
			
			String pyScript = 
				"from com.android.monkeyrunner import MonkeyRunner, MonkeyDevice" + Environment.NewLine +
				"device = MonkeyRunner.waitForConnection();" + Environment.NewLine +
				"package = 'com.package.name';"+ Environment.NewLine +
				"activity = 'com.activity.package.name';"+ Environment.NewLine +
				"runComponent = package + '/' + activity;"+ Environment.NewLine +
				"device.startActivity(component=runComponent);"+ Environment.NewLine +
				"print(\"START - COMPLETE!\");" + Environment.NewLine + 
				"MonkeyRunner.sleep(5.0);";
			textBox14.Text = pyScript;
		}
		
		void initTouche()
		{
			String batCommand = 
				"adb devices" + Environment.NewLine +
				"monkeyrunner " + textBoxFolderTouch.Text + "script.py";
			textBox15.Text = batCommand;
			
			String pyScript = 
				"from com.android.monkeyrunner import MonkeyRunner, MonkeyDevice" + Environment.NewLine +
				"device = MonkeyRunner.waitForConnection();" + Environment.NewLine +
				"device.touch(640, 650, 'DOWN_AND_UP');"+ Environment.NewLine +
				"print(\"TOUCH - 1\");"+ Environment.NewLine +
				"MonkeyRunner.sleep(5.0);"+ Environment.NewLine +
				"device.touch(250, 350, 'DOWN_AND_UP');"+ Environment.NewLine +
				"print(\"TOUCH - 2\");"+ Environment.NewLine +
				"MonkeyRunner.sleep(5.0);"+ Environment.NewLine +
				"device.touch(50, 150, 'DOWN_AND_UP');"+ Environment.NewLine +
				"print(\"TOUCH - 3\");"+ Environment.NewLine +
				"MonkeyRunner.sleep(5.0);"+ Environment.NewLine +
				"print(\"TOUCHES - END!\");" + Environment.NewLine + 
				"MonkeyRunner.sleep(5.0);";
			textBox16.Text = pyScript;
		}
		
		void initJython()
		{
			String batCommand = 
				textBoxJython.Text + " " + textBoxFolderJython.Text + "script.py" + Environment.NewLine + "@pause";
			textBox17.Text = batCommand;
			richTextBox1.Text = "print(\"hello world!!!\");";
		}
		
		void saveFile(String fileName, String text)
		{
			if(!File.Exists(fileName)){ 
				File.Create(fileName).Close();
				FileStream fs = File.OpenWrite(fileName);
				Byte[] info = new UTF8Encoding(true).GetBytes(text);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(fileName);
				File.Create(fileName).Close();
				FileStream fs = File.OpenWrite(fileName);
				Byte[] info = new UTF8Encoding(true).GetBytes(text);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
		}
		
		String readFile(String fileName)
		{
			if(!File.Exists(fileName)){ 
				MessageBox.Show("Файл " + fileName + " не существует", "Сообщение");
				return null;
			}else{
				
				byte[] b = new byte[1024];
            	UTF8Encoding temp = new UTF8Encoding(true);
                
                String text = "";
                FileStream fs = File.OpenRead(@fileName);
                while (fs.Read(b,0,b.Length) > 0) 
	            {
	                text += temp.GetString(b) + Environment.NewLine;
	            }
                
                fs.Close();
                
                return text;
			}
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
			textBoxFolderConsole.Text = folderResource + "console\\";
			Directory.CreateDirectory(textBoxFolderConsole.Text);
			textBoxFolderJython.Text = folderResource + "jython\\";
			Directory.CreateDirectory(textBoxFolderJython.Text);
			textBoxFolderBuilds.Text = folderResource + "builds\\";
			Directory.CreateDirectory(textBoxFolderBuilds.Text);
			textBoxFolderTouch.Text = folderResource + "touches\\";
			Directory.CreateDirectory(textBoxFolderTouch.Text);
			
			initScreenshot();
			initLog();
			initInstallBuild();
			initRemoveBuild();
			initStartActivity();
			initTouche();
			initJython();
		}
		void ToolStripStatusLabel1Click(object sender, EventArgs e)
		{
			FormAbout FAbout = new FormAbout();
			FAbout.ShowDialog();
		}
		void Button45Click(object sender, EventArgs e)
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
		void Button17Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderConsole.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void Button18Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderJython.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void Button20Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderBuilds.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void Button49Click(object sender, EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) textBoxFolderTouch.Text = folderBrowserDialog1.SelectedPath + "\\";
		}
		void Button12Click(object sender, EventArgs e)
		{
			applyConcole();
		}
		void Button32Click(object sender, EventArgs e)
		{
			saveFileDialogBat.InitialDirectory = textBoxFolderConsole.Text;
			saveFileDialogBat.FileName = "console.bat";
			if(saveFileDialogBat.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogBat.FileName, textBoxConsole.Text);
			}
		}
		void Button31Click(object sender, EventArgs e)
		{
			openFileDialogBat.InitialDirectory = textBoxFolderConsole.Text;
			if(openFileDialogBat.ShowDialog() == DialogResult.OK){
				textBoxConsole.Text = readFile(openFileDialogBat.FileName);
			}
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
			TestingAndroid.ExecuteBatAndPy(textBoxFolderScreenshots2.Text, 
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
		void Button24Click(object sender, EventArgs e)
		{
			saveFileDialogPy.InitialDirectory = textBoxFolderScreenshots.Text;
			saveFileDialogPy.FileName = "script.py";
			if(saveFileDialogPy.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogPy.FileName, textBox6.Text);
			}
		}
		void Button23Click(object sender, EventArgs e)
		{
			openFileDialogPy.InitialDirectory = textBoxFolderScreenshots.Text;
			if(openFileDialogPy.ShowDialog() == DialogResult.OK){
				textBox6.Text = readFile(openFileDialogPy.FileName);
			}
		}
		void Button6Click(object sender, EventArgs e)
		{
			TestingAndroid.ExecuteBat(textBoxFolderLog.Text, textBoxFolderLog.Text + "log.bat", textBox9.Text);
		}
		void Button16Click(object sender, EventArgs e)
		{
			try{
				Process.Start(textBoxFolderLog.Text);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void Button21Click(object sender, EventArgs e)
		{
			saveFileDialogBat.InitialDirectory = textBoxFolderLog.Text;
			saveFileDialogBat.FileName = "log.bat";
			if(saveFileDialogBat.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogBat.FileName, textBox9.Text);
			}
		}
		void Button22Click(object sender, EventArgs e)
		{
			openFileDialogBat.InitialDirectory = textBoxFolderLog.Text;
			if(openFileDialogBat.ShowDialog() == DialogResult.OK){
				textBox9.Text = readFile(openFileDialogBat.FileName);
			}
		}
		void TextBoxFolderLogTextChanged(object sender, EventArgs e)
		{
			initLog();
		}
		void Button1Click(object sender, EventArgs e)
		{
			TestingAndroid.ExecuteBat(textBoxFolderDDMS.Text, textBoxFolderDDMS.Text + "ddms.bat", textBox2.Text);
		}
		void Button30Click(object sender, EventArgs e)
		{
			saveFileDialogBat.InitialDirectory = textBoxFolderDDMS.Text;
			saveFileDialogBat.FileName = "ddms.bat";
			if(saveFileDialogBat.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogBat.FileName, textBox2.Text);
			}
		}
		void Button29Click(object sender, EventArgs e)
		{
			openFileDialogBat.InitialDirectory = textBoxFolderDDMS.Text;
			if(openFileDialogBat.ShowDialog() == DialogResult.OK){
				textBox2.Text = readFile(openFileDialogBat.FileName);
			}
		}
		void Button19Click(object sender, EventArgs e)
		{
			openFileDialogApk.InitialDirectory = textBoxFolderBuilds.Text;
			if(openFileDialogApk.ShowDialog() == DialogResult.OK){
				getPackageName(openFileDialogApk.FileName);
			}
		}
		void Button26Click(object sender, EventArgs e)
		{
			saveFileDialogBat.InitialDirectory = textBoxFolderStress.Text;
			saveFileDialogBat.FileName = "stress.bat";
			if(saveFileDialogBat.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogBat.FileName, textBox8.Text);
			}
		}
		void Button25Click(object sender, EventArgs e)
		{
			openFileDialogBat.InitialDirectory = textBoxFolderStress.Text;
			if(openFileDialogBat.ShowDialog() == DialogResult.OK){
				textBox8.Text = readFile(openFileDialogBat.FileName);
			}
		}
		void Button5Click(object sender, EventArgs e)
		{
			TestingAndroid.ExecuteBat(textBoxFolderStress.Text, textBoxFolderStress.Text + "stress.bat", textBox8.Text);
		}
		void Button4Click(object sender, EventArgs e)
		{
			TestingAndroid.ExecuteBat(textBoxFolderShell.Text, textBoxFolderShell.Text + "shell.bat", textBox7.Text);
		}
		void Button28Click(object sender, EventArgs e)
		{
			saveFileDialogBat.InitialDirectory = textBoxFolderShell.Text;
			saveFileDialogBat.FileName = "shell.bat";
			if(saveFileDialogBat.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogBat.FileName, textBox7.Text);
			}
		}
		void Button27Click(object sender, EventArgs e)
		{
			openFileDialogBat.InitialDirectory = textBoxFolderShell.Text;
			if(openFileDialogBat.ShowDialog() == DialogResult.OK){
				textBox7.Text = readFile(openFileDialogBat.FileName);
			}
		}
		void Button35Click(object sender, EventArgs e)
		{
			openFileDialogApk.InitialDirectory = textBoxFolderBuilds.Text;
			if(openFileDialogApk.ShowDialog() == DialogResult.OK){
				textBox3.Text = openFileDialogApk.FileName;
				initInstallBuild();
			}
		}
		void Button37Click(object sender, EventArgs e)
		{
			TestingAndroid.ExecuteBatAndPy(textBoxFolderBuilds.Text,
			                               textBoxFolderBuilds.Text + "install.bat",
			                               textBox4.Text,
			                               textBoxFolderBuilds.Text + "script.py",
			                               textBox10.Text);
		}
		void Button34Click(object sender, EventArgs e)
		{
			saveFileDialogPy.InitialDirectory = textBoxFolderBuilds.Text;
			saveFileDialogPy.FileName = "script.py";
			if(saveFileDialogPy.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogPy.FileName, textBox10.Text);
			}
		}
		void Button33Click(object sender, EventArgs e)
		{
			openFileDialogPy.InitialDirectory = textBoxFolderBuilds.Text;
			if(openFileDialogPy.ShowDialog() == DialogResult.OK){
				textBox10.Text = readFile(openFileDialogPy.FileName);
			}
		}
		void Button40Click(object sender, EventArgs e)
		{
			openFileDialogApk.InitialDirectory = textBoxFolderBuilds.Text;
			if(openFileDialogApk.ShowDialog() == DialogResult.OK){
				getPackageName(openFileDialogApk.FileName);
			}
		}
		void Button39Click(object sender, EventArgs e)
		{
			TestingAndroid.ExecuteBatAndPy(textBoxFolderBuilds.Text,
			                               textBoxFolderBuilds.Text + "remove.bat",
			                               textBox11.Text,
			                               textBoxFolderBuilds.Text + "script.py",
			                               textBox12.Text);
		}
		void Button38Click(object sender, EventArgs e)
		{
			saveFileDialogPy.InitialDirectory = textBoxFolderBuilds.Text;
			saveFileDialogPy.FileName = "script.py";
			if(saveFileDialogPy.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogPy.FileName, textBox12.Text);
			}
		}
		void Button36Click(object sender, EventArgs e)
		{
			openFileDialogPy.InitialDirectory = textBoxFolderBuilds.Text;
			if(openFileDialogPy.ShowDialog() == DialogResult.OK){
				textBox12.Text = readFile(openFileDialogPy.FileName);
			}
		}
		void Button41Click(object sender, EventArgs e)
		{
			openFileDialogApk.InitialDirectory = textBoxFolderBuilds.Text;
			if(openFileDialogApk.ShowDialog() == DialogResult.OK){
				getPackageName(openFileDialogApk.FileName);
			}
		}
		void Button44Click(object sender, EventArgs e)
		{
			TestingAndroid.ExecuteBatAndPy(textBoxFolderBuilds.Text,
			                               textBoxFolderBuilds.Text + "start.bat",
			                               textBox13.Text,
			                               textBoxFolderBuilds.Text + "script.py",
			                               textBox14.Text);
		}
		void Button43Click(object sender, EventArgs e)
		{
			saveFileDialogPy.InitialDirectory = textBoxFolderBuilds.Text;
			saveFileDialogPy.FileName = "script.py";
			if(saveFileDialogPy.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogPy.FileName, textBox14.Text);
			}
		}
		void Button42Click(object sender, EventArgs e)
		{
			openFileDialogPy.InitialDirectory = textBoxFolderBuilds.Text;
			if(openFileDialogPy.ShowDialog() == DialogResult.OK){
				textBox14.Text = readFile(openFileDialogPy.FileName);
			}
		}
		void Button48Click(object sender, EventArgs e)
		{
			TestingAndroid.ExecuteBatAndPy(textBoxFolderTouch.Text,
			                               textBoxFolderTouch.Text + "touches.bat",
			                               textBox15.Text,
			                               textBoxFolderTouch.Text + "script.py",
			                               textBox16.Text);
		}
		void Button47Click(object sender, EventArgs e)
		{
			saveFileDialogPy.InitialDirectory = textBoxFolderTouch.Text;
			saveFileDialogPy.FileName = "script.py";
			if(saveFileDialogPy.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogPy.FileName, textBox16.Text);
			}
		}
		void Button46Click(object sender, EventArgs e)
		{
			openFileDialogPy.InitialDirectory = textBoxFolderTouch.Text;
			if(openFileDialogPy.ShowDialog() == DialogResult.OK){
				textBox16.Text = readFile(openFileDialogPy.FileName);
			}
		}
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			saveFileDialogPy.InitialDirectory = textBoxFolderJython.Text;
			saveFileDialogPy.FileName = "script.py";
			if(saveFileDialogPy.ShowDialog() == DialogResult.OK){
				saveFile(saveFileDialogPy.FileName, richTextBox1.Text);
			}
		}
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			openFileDialogPy.InitialDirectory = textBoxFolderJython.Text;
			if(openFileDialogPy.ShowDialog() == DialogResult.OK){
				richTextBox1.Text = readFile(openFileDialogPy.FileName);
			}
		}
		void ToolStripButton3Click(object sender, EventArgs e)
		{
			if(!File.Exists(textBoxJython.Text)){
				MessageBox.Show("Программа Jython не найдена." + Environment.NewLine + "Пожалуйста укажите пусть к программе Jython", "Сообщение");
				if(openFileDialogJython.ShowDialog() == DialogResult.OK) textBoxJython.Text = openFileDialogJython.FileName;
			}TestingAndroid.ExecuteBatAndPy(textBoxFolderJython.Text,
			                               textBoxFolderJython.Text + "run.bat",
			                               textBox17.Text,
			                               textBoxFolderJython.Text + "script.py",
			                               richTextBox1.Text);
		}
		void ToolStripButton4Click(object sender, EventArgs e)
		{
			try{
				Process.Start(textBoxJython.Text);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		void Button50Click(object sender, EventArgs e)
		{
			if(openFileDialogJython.ShowDialog() == DialogResult.OK) textBoxJython.Text = openFileDialogJython.FileName;
		}
		
		
		
		
		
	}
}
