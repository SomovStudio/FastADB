/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FastADB.client;

namespace FastADB.data
{
	/// <summary>
	/// Description of DataForms.
	/// </summary>
	public static class DataForms
	{
		public static MainForm FMain;
		
		/*Клиент*/
		public static ConverterForm FConverter;
		
		public static ClientForm FClient;
		public static SettingsForm FSettings;
		public static HelpForm FHelp;
		public static LogForm FLog;
		public static ScreenshotForm FScreenhot;
		public static ScreenrecordForm FScreenrecord;
		public static PullForm FPull;
		public static InstallForm FInstall;
		public static MonkeyForm FMonkey;
		public static GeteventForm FGetevent;
	}
}
