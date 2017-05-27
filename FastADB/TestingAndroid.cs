/*
 * Создано в SharpDevelop.
 * Пользователь: Cartish
 * Дата: 25.05.2017
 * Время: 9:14
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SomovStudio.QA
{
	/// <summary>
	/// Description of TestingAndroid.
	/// </summary>
	public static class TestingAndroid
	{
		public static void AdbDDMS(String folderName, String batFile, String batCommand)
		{
			if(!Directory.Exists(folderName)){
				Directory.CreateDirectory(folderName);
			}
			
						
			if(!File.Exists(batFile)){ 
				File.Create(batFile).Close();
				FileStream fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(batFile);
				File.Create(batFile).Close();
				FileStream fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			try{
				Process.Start(batFile);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		
		public static void AdbScreenshot(String folderName, String batFile, String batCommand, String pyFile, String pyCommand)
		{
			if(!Directory.Exists(folderName)){
				Directory.CreateDirectory(folderName);
			}
			FileStream fs;
			if(!File.Exists(batFile)){ 
				File.Create(batFile).Close();
				fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(batFile);
				File.Create(batFile).Close();
				fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			if(!File.Exists(pyFile)){
				File.Create(pyFile).Close();
				fs = File.OpenWrite(pyFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(pyCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(pyFile);
				File.Create(pyFile).Close();
				fs = File.OpenWrite(pyFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(pyCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			try{
				Process.Start(batFile);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		
		public static void AdbLog(String folderName, String batFile, String batCommand)
		{
			if(!Directory.Exists(folderName)){
				Directory.CreateDirectory(folderName);
			}
			
			if(!File.Exists(batFile)){ 
				File.Create(batFile).Close();
				FileStream fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(batFile);
				File.Create(batFile).Close();
				FileStream fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			try{
				Process.Start(batFile);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		
		public static void AdbStress(String folderName, String batFile, String batCommand)
		{
			if(!Directory.Exists(folderName)){
				Directory.CreateDirectory(folderName);
			}
			
			if(!File.Exists(batFile)){ 
				File.Create(batFile).Close();
				FileStream fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(batFile);
				File.Create(batFile).Close();
				FileStream fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			try{
				Process.Start(batFile);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		
		public static void AdbShell(String folderName, String batFile, String batCommand)
		{
			if(!Directory.Exists(folderName)){
				Directory.CreateDirectory(folderName);
			}
			
			if(!File.Exists(batFile)){ 
				File.Create(batFile).Close();
				FileStream fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}else{
				File.Delete(batFile);
				File.Create(batFile).Close();
				FileStream fs = File.OpenWrite(batFile);
				Byte[] info = new UTF8Encoding(true).GetBytes(batCommand);
                fs.Write(info, 0, info.Length);
                fs.Close();
			}
			
			try{
				Process.Start(batFile);
			}catch(Exception ex){
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}
		
	}
}
