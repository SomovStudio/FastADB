/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 17:32
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
	/// Description of HelpForm.
	/// </summary>
	public partial class HelpForm : Form
	{
		public HelpForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void HelpFormLoad(object sender, EventArgs e)
		{
			checkBox1.Checked = DataResources.helpShow;
			richTextBox1.Rtf = textBox1.Text;
		}
		void HelpFormFormClosed(object sender, FormClosedEventArgs e)
		{
			DataResources.helpShow = checkBox1.Checked;
			DataResources.saveConfigFile();
			DataResources.updateDefaultScripts();
			DataForms.FHelp = null;
		}
		void Button19Click(object sender, EventArgs e)
		{
			Close();
		}
		void RichTextBox1LinkClicked(object sender, LinkClickedEventArgs e)
		{
			try{
				System.Diagnostics.Process.Start(e.LinkText);
			}catch(Exception ex){
				DataResources.consoleMessage("ОШИБКА " + ex.Message);
			}
		}
	}
}
