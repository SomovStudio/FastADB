/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 17:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FastADB.client
{
	partial class HelpForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Panel panel1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button19 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label3.Location = new System.Drawing.Point(3, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(546, 2);
			this.label3.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 15);
			this.label2.TabIndex = 26;
			this.label2.Text = "Советы:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 33);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(536, 20);
			this.textBox1.TabIndex = 25;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.White;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(544, 310);
			this.richTextBox1.TabIndex = 18;
			this.richTextBox1.Text = "";
			this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBox1LinkClicked);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button19);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 344);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(553, 48);
			this.panel2.TabIndex = 29;
			// 
			// button19
			// 
			this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button19.ForeColor = System.Drawing.Color.Silver;
			this.button19.Location = new System.Drawing.Point(461, 12);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(80, 23);
			this.button19.TabIndex = 2;
			this.button19.Text = "Закрыть";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.Button19Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBox1.ForeColor = System.Drawing.Color.Silver;
			this.checkBox1.Location = new System.Drawing.Point(12, 12);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(181, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Показывать при старте";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Location = new System.Drawing.Point(3, 18);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(546, 312);
			this.panel1.TabIndex = 28;
			// 
			// HelpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(553, 392);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "HelpForm";
			this.Text = "Помощь";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelpFormFormClosed);
			this.Load += new System.EventHandler(this.HelpFormLoad);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
