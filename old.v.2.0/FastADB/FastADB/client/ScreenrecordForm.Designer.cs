/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 07.10.2018
 * Time: 10:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FastADB.client
{
	partial class ScreenrecordForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox folderPcTextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox folderDeviceTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox filenameTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label pathLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox scriptTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenrecordForm));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.folderPcTextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.folderDeviceTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.filenameTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.pathLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.scriptTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.linkLabel6 = new System.Windows.Forms.LinkLabel();
			this.label7 = new System.Windows.Forms.Label();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.label5 = new System.Windows.Forms.Label();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "*.bat|*.bat";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label9);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			this.splitContainer1.Panel1.Controls.Add(this.label12);
			this.splitContainer1.Panel1.Controls.Add(this.pathLabel);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.panel3);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Size = new System.Drawing.Size(624, 411);
			this.splitContainer1.SplitterDistance = 449;
			this.splitContainer1.TabIndex = 5;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label9.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label9.Location = new System.Drawing.Point(12, 27);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(434, 2);
			this.label9.TabIndex = 29;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.folderPcTextBox);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.folderDeviceTextBox);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.filenameTextBox);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Location = new System.Drawing.Point(12, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(434, 81);
			this.panel1.TabIndex = 30;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Gray;
			this.button1.Location = new System.Drawing.Point(399, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// folderPcTextBox
			// 
			this.folderPcTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.folderPcTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.folderPcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.folderPcTextBox.Enabled = false;
			this.folderPcTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.folderPcTextBox.Location = new System.Drawing.Point(169, 57);
			this.folderPcTextBox.Name = "folderPcTextBox";
			this.folderPcTextBox.Size = new System.Drawing.Size(224, 20);
			this.folderPcTextBox.TabIndex = 8;
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label13.Location = new System.Drawing.Point(2, 59);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(161, 23);
			this.label13.TabIndex = 7;
			this.label13.Text = "Путь к папке на компьютере:";
			// 
			// folderDeviceTextBox
			// 
			this.folderDeviceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.folderDeviceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.folderDeviceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.folderDeviceTextBox.ForeColor = System.Drawing.Color.Silver;
			this.folderDeviceTextBox.Location = new System.Drawing.Point(169, 30);
			this.folderDeviceTextBox.Name = "folderDeviceTextBox";
			this.folderDeviceTextBox.Size = new System.Drawing.Size(260, 20);
			this.folderDeviceTextBox.TabIndex = 5;
			this.folderDeviceTextBox.Text = "/sdcard/";
			this.folderDeviceTextBox.TextChanged += new System.EventHandler(this.FolderDeviceTextBoxTextChanged);
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label10.Location = new System.Drawing.Point(2, 32);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(161, 23);
			this.label10.TabIndex = 4;
			this.label10.Text = "Путь к папке на устройстве:";
			// 
			// filenameTextBox
			// 
			this.filenameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.filenameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.filenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.filenameTextBox.ForeColor = System.Drawing.Color.Silver;
			this.filenameTextBox.Location = new System.Drawing.Point(169, 4);
			this.filenameTextBox.Name = "filenameTextBox";
			this.filenameTextBox.Size = new System.Drawing.Size(260, 20);
			this.filenameTextBox.TabIndex = 3;
			this.filenameTextBox.Text = "video.mp4";
			this.filenameTextBox.TextChanged += new System.EventHandler(this.FilenameTextBoxTextChanged);
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label11.Location = new System.Drawing.Point(2, 6);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(139, 23);
			this.label11.TabIndex = 2;
			this.label11.Text = "Имя видео файла:";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(12, 12);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(128, 15);
			this.label12.TabIndex = 28;
			this.label12.Text = "Настройки:";
			// 
			// pathLabel
			// 
			this.pathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathLabel.ForeColor = System.Drawing.Color.Gray;
			this.pathLabel.Location = new System.Drawing.Point(12, 388);
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.Size = new System.Drawing.Size(433, 14);
			this.pathLabel.TabIndex = 26;
			this.pathLabel.Text = "Адрес:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label1.Location = new System.Drawing.Point(12, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(434, 2);
			this.label1.TabIndex = 24;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.scriptTextBox);
			this.panel3.Location = new System.Drawing.Point(12, 142);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(434, 243);
			this.panel3.TabIndex = 25;
			// 
			// scriptTextBox
			// 
			this.scriptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.scriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.scriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.scriptTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.scriptTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.scriptTextBox.Location = new System.Drawing.Point(3, 0);
			this.scriptTextBox.Multiline = true;
			this.scriptTextBox.Name = "scriptTextBox";
			this.scriptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.scriptTextBox.Size = new System.Drawing.Size(429, 241);
			this.scriptTextBox.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 15);
			this.label4.TabIndex = 23;
			this.label4.Text = "Скрипт:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.linkLabel7);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.linkLabel6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.linkLabel5);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.linkLabel4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.linkLabel3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.linkLabel2);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.linkLabel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(171, 411);
			this.panel2.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label14.Location = new System.Drawing.Point(3, 238);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(165, 31);
			this.label14.TabIndex = 24;
			this.label14.Text = "Переносит видео файл с устройства на компьютер.";
			// 
			// linkLabel7
			// 
			this.linkLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel7.Location = new System.Drawing.Point(3, 220);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(165, 18);
			this.linkLabel7.TabIndex = 23;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "Перенести видео на пк";
			this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel7LinkClicked);
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
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label8.Location = new System.Drawing.Point(3, 371);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 31);
			this.label8.TabIndex = 13;
			this.label8.Text = "Остановить выполнение текущего скрипта.";
			// 
			// linkLabel6
			// 
			this.linkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel6.Location = new System.Drawing.Point(3, 353);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(165, 18);
			this.linkLabel6.TabIndex = 12;
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = "Остановить";
			this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel6LinkClicked);
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
			this.label7.Text = "Выполнить текущий открытый скрипт.";
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
			this.linkLabel5.Text = "Выполнить";
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel5LinkClicked);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label5.Location = new System.Drawing.Point(3, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 31);
			this.label5.TabIndex = 9;
			this.label5.Text = "Откроется папка с видео файлами.";
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel4.Location = new System.Drawing.Point(3, 169);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(165, 18);
			this.linkLabel4.TabIndex = 8;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "Открыть папку с видео";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4LinkClicked);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label3.Location = new System.Drawing.Point(3, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 31);
			this.label3.TabIndex = 7;
			this.label3.Text = "Сохранить текущий файл скрипта с выбором пути.";
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel3.Location = new System.Drawing.Point(3, 113);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(165, 18);
			this.linkLabel3.TabIndex = 6;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Сохранить файл как...";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3LinkClicked);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label2.Location = new System.Drawing.Point(3, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 31);
			this.label2.TabIndex = 5;
			this.label2.Text = "Перезаписать текущий файл скрипта.";
			// 
			// linkLabel2
			// 
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel2.Location = new System.Drawing.Point(3, 60);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(165, 18);
			this.linkLabel2.TabIndex = 4;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Сохранить файл";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
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
			this.label6.Text = "Открыть внешний файл скрипта.";
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
			this.linkLabel1.Text = "Открыть скрипт";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "*.bat|*.bat";
			// 
			// ScreenrecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(624, 411);
			this.Controls.Add(this.splitContainer1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ScreenrecordForm";
			this.Text = "ADB: Screenrecord - записать видео с экрана устройства.";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScreenrecordFormFormClosed);
			this.Load += new System.EventHandler(this.ScreenrecordFormLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
