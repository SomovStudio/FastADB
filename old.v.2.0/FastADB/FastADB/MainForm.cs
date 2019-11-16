/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 8:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FastADB.data;
using FastADB.client;

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
		void MainFormLoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			Dispose();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			
			try {
				DataResources.createResourceFolder();
				DataResources.createDefaultScripts();
				DataResources.createConfigFile();
				DataResources.readConfigFile();
				showClient();
			}catch(Exception ex){
				MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Запустите программу от имени администратора.", "Сообщение");
				DataConfig.programClose = true;
				Application.Exit();
			}
		}
		
		void showClient()
		{
			DataForms.FMain = this;
			DataForms.FMain.Visible = false;
			DataConfig.programClose = false;
			
			DataForms.FClient = new ClientForm();
			DataForms.FClient.Show();
		}
		
	}
}
