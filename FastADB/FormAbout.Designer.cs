/*
 * Создано в SharpDevelop.
 * Пользователь: Cartish
 * Дата: 09.05.2017
 * Время: 12:51
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace FastADB
{
	partial class FormAbout
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 57);
			this.label1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(0, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(284, 57);
			this.label2.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(260, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "Программа: FastADB";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 76);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(260, 19);
			this.label4.TabIndex = 4;
			this.label4.Text = "Разработчик: Somov Studio";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(260, 19);
			this.label5.TabIndex = 5;
			this.label5.Text = "Лицензия: GNU";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(260, 19);
			this.label6.TabIndex = 6;
			this.label6.Text = "Версия: 1.0";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(260, 19);
			this.label7.TabIndex = 7;
			this.label7.Text = "Дата: 25.05.2017";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(260, 19);
			this.label8.TabIndex = 8;
			this.label8.Text = "Почта:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 171);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(260, 19);
			this.label9.TabIndex = 9;
			this.label9.Text = "Сайт:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(55, 152);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(217, 23);
			this.linkLabel1.TabIndex = 10;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "somov.studio@gmail.com";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.Location = new System.Drawing.Point(55, 171);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(217, 23);
			this.linkLabel2.TabIndex = 11;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "http://somov.hol.es/";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "О программе";
			this.ResumeLayout(false);

		}
	}
}
