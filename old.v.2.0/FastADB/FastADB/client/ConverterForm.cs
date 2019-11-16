/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 08.10.2018
 * Time: 11:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using FastADB.data;

namespace FastADB.client
{
	/// <summary>
	/// Description of ConverterForm.
	/// </summary>
	public partial class ConverterForm : Form
	{
		public ConverterForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			openFileDialog1.InitialDirectory = DataResources.filesPath;
			openFileDialog1.Filter = "*.txt|*.txt|*.*|*.*";
			openFileDialog1.FileName = "getevents.txt";
			if(openFileDialog1.ShowDialog() == DialogResult.OK){
				richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
				pathLabel1.Text = openFileDialog1.FileName;
			}
		}
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			saveFileDialog1.InitialDirectory = DataResources.filesPath;
			saveFileDialog1.Filter = "*.bat|*.bat";
			saveFileDialog1.FileName = "events_play.bat";
			if(saveFileDialog1.ShowDialog() == DialogResult.OK){
				if(DataResources.saveFile(saveFileDialog1.FileName, richTextBox2.Text) == true){
					pathLabel2.Text = saveFileDialog1.FileName;
					DataResources.consoleMessage("Файл " + pathLabel2.Text + " сохранён");
				}
			}
		}
		void LinkLabel5LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(pathLabel1.Text == "..."){
				DataResources.consoleMessage("Конвертация невозможна! Вы не открыли файл событий getevents.txt");
				return;
			}
			
			String text = "";
			String command = "";
			if(DataResources.adbSysPath == "" ){
				command = "adb shell sendevent ";
			}else{
				command = DataResources.adbSysPath + " shell sendevent ";
			}
			String dev = "";
			String num1 = "";
			String num2 = "";
			String num3 = "";
			
			String[] words = richTextBox1.Text.Split(new Char[] {' '});
			int count = words.Length - 1;
			int length = 0;
			for(int i = 0; i < count; i++)
			{
				length = words[i].Length;
				if(length == 0) continue;
				if(words[i][0].ToString() == "/" && words[i][length-1].ToString() == ":"){
					
					dev = words[i].Substring(0, length-1);
					num1 = " " + Convert.ToInt32(words[i+1], 16);
					num2 = " " + Convert.ToInt32(words[i+2], 16);
					num3 = " " + Convert.ToInt32(words[i+3], 16);
					
					text += command + dev + num1 + num2 + num3 + Environment.NewLine;
				}
			}
			richTextBox2.Text = text;
		}
		void ConverterFormLoad(object sender, EventArgs e)
		{
			
		}
		void ConverterFormFormClosed(object sender, FormClosedEventArgs e)
		{
			DataForms.FConverter = null;
		}
	}
}
