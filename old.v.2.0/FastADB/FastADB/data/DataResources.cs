/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 8:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text;

namespace FastADB.data
{
	/// <summary>
	/// Description of DataResources.
	/// </summary>
	public static class DataResources
	{
		public static String programPath;
		public static String folderResource;
		
		public static bool helpShow = false;
		
		public static String adbSysPath = "";
		public static String ddmsSysPath = "";
		public static String aaptSysPath = "";
		
		public static String commandsPath = "commands\\";
		public static String filesPath = "files\\";
		public static String buildsPath = "builds\\";
		
		public static bool saveFile(String fileName, String text)
		{
			try{
				if(!File.Exists(fileName)){ 
					File.Create(fileName).Close();
					FileStream fs = File.OpenWrite(fileName);
					Byte[] info = new UTF8Encoding(true).GetBytes(text);
	                fs.Write(info, 0, info.Length);
	                fs.Close();
	                return true;
				}else{
					File.Delete(fileName);
					File.Create(fileName).Close();
					FileStream fs = File.OpenWrite(fileName);
					Byte[] info = new UTF8Encoding(true).GetBytes(text);
	                fs.Write(info, 0, info.Length);
	                fs.Close();
	                return true;
				}
			}catch(Exception ex){
				consoleMessage("[ERROR] " + ex.Message);
				return false;
			}
		}
		
		public static String readFile(String fileName)
		{
			if(!File.Exists(fileName)){ 
				consoleMessage("[ERROR] File " + fileName + " does not exist");
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
		
		public static void consoleMessage(String message)
		{
			if(DataForms.FClient != null){
				DataForms.FClient.consoleMessage(message);
			}
		}
		
		public static void createResourceFolder()
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
			
			commandsPath = folderResource + commandsPath;
			if(!Directory.Exists(commandsPath)) Directory.CreateDirectory(commandsPath);
			
			filesPath = folderResource + filesPath;
			if(!Directory.Exists(filesPath)) Directory.CreateDirectory(filesPath);
			
			buildsPath = folderResource + buildsPath;
			if(!Directory.Exists(buildsPath)) Directory.CreateDirectory(buildsPath);
		}
		
		public static void checkFolders()
		{
			if(!Directory.Exists(commandsPath)) Directory.CreateDirectory(commandsPath);
			if(!Directory.Exists(filesPath)) Directory.CreateDirectory(filesPath);
			if(!Directory.Exists(buildsPath)) Directory.CreateDirectory(buildsPath);
		}
		
		public static void createConfigFile()
		{
			if(!File.Exists(folderResource + "config.cfg")){
				String config =
					"True" + Environment.NewLine +
					adbSysPath + Environment.NewLine +
					ddmsSysPath + Environment.NewLine +
					aaptSysPath + Environment.NewLine +
					commandsPath + Environment.NewLine +
					filesPath + Environment.NewLine +
					buildsPath + Environment.NewLine;
				saveFile(folderResource + "config.cfg", config);
			}
		}
		
		public static void saveConfigFile()
		{
			String config =
				helpShow.ToString() + Environment.NewLine +
				adbSysPath + Environment.NewLine +
				ddmsSysPath + Environment.NewLine +
				aaptSysPath + Environment.NewLine +
				commandsPath + Environment.NewLine +
				filesPath + Environment.NewLine +
				buildsPath + Environment.NewLine;
			saveFile(folderResource + "config.cfg", config);
		}
		
		public static void readConfigFile()
		{
			String configFileName = folderResource + "config.cfg";
			if(File.Exists(configFileName)){
				
				String data = readFile(configFileName);
				String[] lines = data.Split('\n');
				String text;
				for(int i = 0; i < lines.Length; i++){
					text = lines[i];
					if(text.Length > 0){
						text = text.Remove(text.Length-1, 1);
		                if(i == 0 && text == "True") helpShow = true;
		                if(i == 1) adbSysPath = text;
		                if(i == 2) ddmsSysPath = text;
		                if(i == 3) aaptSysPath = text;
		                if(i == 4) commandsPath = text;
		                if(i == 5) filesPath = text;
		                if(i == 6) buildsPath = text;
					}
				}
			}
		}
		
		public static void createDefaultScripts()
		{
			String filename = commandsPath + "adb_devices.bat";
			if(!File.Exists(filename)) saveFile(filename, initDevices());
			
			filename = commandsPath + "adb_logcat.bat";
			if(!File.Exists(filename)) saveFile(filename, initLog(filesPath + "log.txt"));
			
			filename = commandsPath + "adb_screencap.bat";
			if(!File.Exists(filename)) saveFile(filename, initScreenshot("screen.png", "/sdcard/", filesPath));
			
			filename = commandsPath + "adb_screenrecord.bat";
			if(!File.Exists(filename)) saveFile(filename, initScreenrecord("video.mp4", "/sdcard/"));
			
			filename = commandsPath + "adb_pull_rm.bat";
			if(!File.Exists(filename)) saveFile(filename, initPullAndRm("video.mp4", "/sdcard/", filesPath));
			
			filename = commandsPath + "adb_pull.bat";
			if(!File.Exists(filename)) saveFile(filename, initPull("video.mp4", "/sdcard/", filesPath));
			
			filename = commandsPath + "adb_install.bat";
			if(!File.Exists(filename)) saveFile(filename, initInstall(buildsPath + "build.apk", false));
			
			filename = commandsPath + "adb_monkey.bat";
			if(!File.Exists(filename)) saveFile(filename, initMonkey("com.package.name"));
			
			filename = commandsPath + "aapt_dump_badging.bat";
			if(!File.Exists(filename)) saveFile(filename, initAAPT("com.package.name"));
			
			filename = commandsPath + "ddms.bat";
			if(!File.Exists(filename)) saveFile(filename, initDDMS());
			
			filename = commandsPath + "adb_getevent.bat";
			if(!File.Exists(filename)) saveFile(filename, initGetevent(filesPath + "getevents.txt"));
		}
		
		public static void updateDefaultScripts()
		{
			String filename = commandsPath + "adb_devices.bat";
			saveFile(filename, initDevices());
			
			filename = commandsPath + "adb_logcat.bat";
			saveFile(filename, initLog(filesPath + "log.txt"));
			
			filename = commandsPath + "adb_screencap.bat";
			saveFile(filename, initScreenshot("screen.png", "/sdcard/", filesPath));
			
			filename = commandsPath + "adb_screenrecord.bat";
			saveFile(filename, initScreenrecord("video.mp4", "/sdcard/"));
			
			filename = commandsPath + "adb_pull_rm.bat";
			saveFile(filename, initPullAndRm("video.mp4", "/sdcard/", filesPath));
			
			filename = commandsPath + "adb_pull.bat";
			saveFile(filename, initPull("video.mp4", "/sdcard/", filesPath));
			
			filename = commandsPath + "adb_install.bat";
			saveFile(filename, initInstall(buildsPath + "build.apk", false));
			
			filename = commandsPath + "adb_monkey.bat";
			saveFile(filename, initMonkey("com.package.name"));
			
			filename = commandsPath + "aapt_dump_badging.bat";
			saveFile(filename, initAAPT("com.package.name"));
			
			filename = commandsPath + "ddms.bat";
			saveFile(filename, initDDMS());
			
			filename = commandsPath + "adb_getevent.bat";
			saveFile(filename, initGetevent(filesPath + "getevents.txt"));
		}
		
		public static String initDevices()
		{
			String batCommand = "";
			if(adbSysPath == "") batCommand = "adb devices";
			else batCommand = adbSysPath + " devices";
			return batCommand;
		}
		
		public static String initLog(String filename)
		{
			String batCommand = "";
			if(adbSysPath == ""){
				batCommand = "adb logcat -d > " + filename;
			}else{
				batCommand = adbSysPath + " logcat -d > " + filename;
			}
			return batCommand;
		}
		
		public static String initScreenshot(String filename, String folderDevice, String folderPC)
		{
			String batCommand = "";
			if(adbSysPath == ""){
				batCommand = 
					"adb shell screencap -p " + folderDevice + filename + Environment.NewLine +
					"adb pull " + folderDevice + filename + " " + folderPC + filename + Environment.NewLine + 
					"adb shell rm " + folderDevice + filename;
			}else{
				batCommand = 
					adbSysPath +" shell screencap -p " + folderDevice + filename + Environment.NewLine +
					adbSysPath +" pull " + folderDevice + filename + " " + folderPC + filename + Environment.NewLine + 
					adbSysPath +" shell rm " + folderDevice + filename;
			}
			return batCommand;
		}
		
		public static String initScreenrecord(String filename, String folderDevice)
		{
			String batCommand = "";
			if(adbSysPath == ""){
				batCommand = 
					"adb shell screenrecord " + folderDevice + filename;
			}else{
				batCommand = 
					adbSysPath +" shell screenrecord " + folderDevice + filename;
			}
			return batCommand;
		}
		
		public static String initPullAndRm(String filename, String folderDevice, String folderPC)
		{
			String batCommand = "";
			if(adbSysPath == ""){
				batCommand = 
					"adb shell ls " + folderDevice + Environment.NewLine +
					"adb pull " + folderDevice + filename + " " + folderPC + filename + Environment.NewLine +
					"adb shell rm " + folderDevice + filename;
			}else{
				batCommand = 
					adbSysPath + " shell ls " + folderDevice + Environment.NewLine +
					adbSysPath + " pull " + folderDevice + filename + " " + folderPC + filename + Environment.NewLine +
					adbSysPath + " shell rm " + folderDevice + filename;
			}
			return batCommand;
		}
		
		public static String initPull(String filename, String folderDevice, String folderPC)
		{
			String batCommand = "";
			if(adbSysPath == ""){
				batCommand = 
					"adb shell ls " + folderDevice + Environment.NewLine +
					"adb pull " + folderDevice + filename + " " + folderPC + filename;
			}else{
				batCommand = 
					adbSysPath + " shell ls " + folderDevice + Environment.NewLine +
					adbSysPath + " pull " + folderDevice + filename + " " + folderPC + filename;
			}
			return batCommand;
		}
		
		public static String initInstall(String filename, Boolean sdcard)
		{
			String batCommand = "";
			if(adbSysPath == "" && sdcard == false){
				batCommand = "adb install " + filename;
			}else if(adbSysPath == "" && sdcard == true){
				batCommand = "adb install -s " + filename;
			}else if(adbSysPath != "" && sdcard == false){
				batCommand = adbSysPath + " install " + filename;
			}else if(adbSysPath != "" && sdcard == true){
				batCommand = adbSysPath + " install -s " + filename;
			}else{
				batCommand = "adb install " + filename;
			}
			return batCommand;
		}
		
		public static String initMonkey(String packagename)
		{
			String batCommand = "";
			if(adbSysPath == ""){
				batCommand = "adb shell monkey -p " + packagename + " -v 5000 -s 1000 --pct-touch 20 --pct-motion 20 --pct-nav 40 --pct-majornav 60 --pct-syskeys 20 --pct-appswitch 50 --ignore-security-exceptions";
			}else{
				batCommand = adbSysPath + " shell monkey -p " + packagename + " -v 5000 -s 1000 --pct-touch 20 --pct-motion 20 --pct-nav 40 --pct-majornav 60 --pct-syskeys 20 --pct-appswitch 50 --ignore-security-exceptions";
			}
			return batCommand;
		}
		
		public static String initAAPT(String filename)
		{
			String batCommand = "";
			if(aaptSysPath == ""){
				batCommand = "aapt dump badging " + filename;
			}else{
				batCommand = aaptSysPath + " dump badging " + filename;
			}
			return batCommand;
		}
		
		public static String initDDMS()
		{
			String batCommand = "";
			if(ddmsSysPath == ""){
				batCommand = "ddms";
			}else{
				batCommand = ddmsSysPath;
			}
			return batCommand;
		}
		
		public static String initGetevent(String filename)
		{
			String batCommand = "";
			if(adbSysPath == ""){
				batCommand = "adb shell getevent -t > " + filename;
			}else{
				batCommand = adbSysPath + " shell getevent -t > " + filename;
			}
			return batCommand;
		}
	}
}
