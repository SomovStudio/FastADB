/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 08.10.2018
 * Time: 11:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FastADB.client
{
	partial class ConverterForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label pathLabel1;
		private System.Windows.Forms.Label pathLabel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterForm));
			this.label7 = new System.Windows.Forms.Label();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.pathLabel1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pathLabel2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel2.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label7.Location = new System.Drawing.Point(3, 316);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(165, 31);
			this.label7.TabIndex = 11;
			this.label7.Text = "Выполнить конвертацию данных.";
			// 
			// linkLabel5
			// 
			this.linkLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel5.Location = new System.Drawing.Point(3, 298);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(165, 18);
			this.linkLabel5.TabIndex = 10;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "Конвертировать";
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel5LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel3.Location = new System.Drawing.Point(5, 354);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(165, 18);
			this.linkLabel3.TabIndex = 6;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Сохранить файл как...";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3LinkClicked);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label3.Location = new System.Drawing.Point(5, 372);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 31);
			this.label3.TabIndex = 7;
			this.label3.Text = "Сохранить результат конвертации в файл.";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label6.Location = new System.Drawing.Point(3, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 31);
			this.label6.TabIndex = 3;
			this.label6.Text = "Открыть внешний файл в котором описаны события.";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.linkLabel5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.linkLabel3);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.linkLabel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(171, 411);
			this.panel2.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Location = new System.Drawing.Point(5, 293);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(158, 1);
			this.panel5.TabIndex = 22;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel1.Location = new System.Drawing.Point(3, 9);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(165, 18);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Открыть файл getevents.txt";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Size = new System.Drawing.Size(624, 411);
			this.splitContainer1.SplitterDistance = 449;
			this.splitContainer1.TabIndex = 4;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.pathLabel1);
			this.splitContainer2.Panel1.Controls.Add(this.label1);
			this.splitContainer2.Panel1.Controls.Add(this.panel3);
			this.splitContainer2.Panel1.Controls.Add(this.label4);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.pathLabel2);
			this.splitContainer2.Panel2.Controls.Add(this.label5);
			this.splitContainer2.Panel2.Controls.Add(this.panel1);
			this.splitContainer2.Panel2.Controls.Add(this.label8);
			this.splitContainer2.Size = new System.Drawing.Size(449, 411);
			this.splitContainer2.SplitterDistance = 204;
			this.splitContainer2.TabIndex = 0;
			// 
			// pathLabel1
			// 
			this.pathLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathLabel1.ForeColor = System.Drawing.Color.Gray;
			this.pathLabel1.Location = new System.Drawing.Point(12, 181);
			this.pathLabel1.Name = "pathLabel1";
			this.pathLabel1.Size = new System.Drawing.Size(433, 14);
			this.pathLabel1.TabIndex = 29;
			this.pathLabel1.Text = "...";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(434, 2);
			this.label1.TabIndex = 27;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.richTextBox1);
			this.panel3.Location = new System.Drawing.Point(12, 25);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(434, 153);
			this.panel3.TabIndex = 28;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(432, 151);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 15);
			this.label4.TabIndex = 26;
			this.label4.Text = "Входные данные: getevents.txt";
			// 
			// pathLabel2
			// 
			this.pathLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathLabel2.ForeColor = System.Drawing.Color.Gray;
			this.pathLabel2.Location = new System.Drawing.Point(12, 180);
			this.pathLabel2.Name = "pathLabel2";
			this.pathLabel2.Size = new System.Drawing.Size(433, 14);
			this.pathLabel2.TabIndex = 33;
			this.pathLabel2.Text = "...";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label5.Location = new System.Drawing.Point(12, 25);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(434, 2);
			this.label5.TabIndex = 31;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.richTextBox2);
			this.panel1.Location = new System.Drawing.Point(12, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(434, 151);
			this.panel1.TabIndex = 32;
			// 
			// richTextBox2
			// 
			this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.richTextBox2.Location = new System.Drawing.Point(0, 0);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(432, 149);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(12, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(200, 15);
			this.label8.TabIndex = 30;
			this.label8.Text = "Результат конвертации: *.bat";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "*.bat|*.bat";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "*.bat|*.bat";
			// 
			// ConverterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(624, 411);
			this.Controls.Add(this.splitContainer1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConverterForm";
			this.Text = "Converter events - конвертирует полученные события для из воспроизведения.";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConverterFormFormClosed);
			this.Load += new System.EventHandler(this.ConverterFormLoad);
			this.panel2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
