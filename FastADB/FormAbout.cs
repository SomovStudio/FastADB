/*
 * Создано в SharpDevelop.
 * Пользователь: Cartish
 * Дата: 09.05.2017
 * Время: 12:51
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FastADB
{
	/// <summary>
	/// Description of FormAbout.
	/// </summary>
	public partial class FormAbout : Form
	{
		public FormAbout()
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
			try{
				System.Diagnostics.Process.Start("mailto:" + linkLabel1.Text);
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
	}
}
