/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 17:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FastADB.client
{
	partial class SettingsForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox pathMonitorTextBox;
		private System.Windows.Forms.TextBox pathAaptTextBox;
		private System.Windows.Forms.TextBox pathAdbTextBox;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.TextBox pathFilesTextBox;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.TextBox pathCommandsTextBox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox pathBuildsTextBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button19 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pathMonitorTextBox = new System.Windows.Forms.TextBox();
			this.pathAaptTextBox = new System.Windows.Forms.TextBox();
			this.pathAdbTextBox = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.pathFilesTextBox = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.pathCommandsTextBox = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.pathBuildsTextBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button19);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 326);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(673, 48);
			this.panel1.TabIndex = 1;
			// 
			// button19
			// 
			this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button19.ForeColor = System.Drawing.Color.Silver;
			this.button19.Location = new System.Drawing.Point(581, 12);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(80, 23);
			this.button19.TabIndex = 2;
			this.button19.Text = "Отмена";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.Button19Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Silver;
			this.button1.Location = new System.Drawing.Point(495, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label3.Location = new System.Drawing.Point(12, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(649, 2);
			this.label3.TabIndex = 22;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.button4);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.pathMonitorTextBox);
			this.panel3.Controls.Add(this.pathAaptTextBox);
			this.panel3.Controls.Add(this.pathAdbTextBox);
			this.panel3.Controls.Add(this.button3);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Location = new System.Drawing.Point(12, 25);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(649, 126);
			this.panel3.TabIndex = 23;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.Gray;
			this.button4.Location = new System.Drawing.Point(613, 41);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(30, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "...";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.Gray;
			this.button2.Location = new System.Drawing.Point(613, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(30, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pathMonitorTextBox
			// 
			this.pathMonitorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathMonitorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.pathMonitorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathMonitorTextBox.Enabled = false;
			this.pathMonitorTextBox.Location = new System.Drawing.Point(179, 83);
			this.pathMonitorTextBox.Name = "pathMonitorTextBox";
			this.pathMonitorTextBox.Size = new System.Drawing.Size(428, 20);
			this.pathMonitorTextBox.TabIndex = 5;
			// 
			// pathAaptTextBox
			// 
			this.pathAaptTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathAaptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.pathAaptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathAaptTextBox.Enabled = false;
			this.pathAaptTextBox.Location = new System.Drawing.Point(179, 43);
			this.pathAaptTextBox.Name = "pathAaptTextBox";
			this.pathAaptTextBox.Size = new System.Drawing.Size(428, 20);
			this.pathAaptTextBox.TabIndex = 9;
			// 
			// pathAdbTextBox
			// 
			this.pathAdbTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathAdbTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.pathAdbTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathAdbTextBox.Enabled = false;
			this.pathAdbTextBox.Location = new System.Drawing.Point(179, 5);
			this.pathAdbTextBox.Name = "pathAdbTextBox";
			this.pathAdbTextBox.Size = new System.Drawing.Size(428, 20);
			this.pathAdbTextBox.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.Gray;
			this.button3.Location = new System.Drawing.Point(613, 81);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(30, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "...";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label10.Location = new System.Drawing.Point(3, 46);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(139, 23);
			this.label10.TabIndex = 8;
			this.label10.Text = "Путь к файлу aapt.exe";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label9.ForeColor = System.Drawing.Color.Gray;
			this.label9.Location = new System.Drawing.Point(179, 63);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(465, 20);
			this.label9.TabIndex = 11;
			this.label9.Text = "например C:\\Users\\UserName\\AppData\\Local\\Android\\sdk\\build-tools\\28.0.3\\aapt.exe";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label7.ForeColor = System.Drawing.Color.Gray;
			this.label7.Location = new System.Drawing.Point(179, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(465, 20);
			this.label7.TabIndex = 7;
			this.label7.Text = "например C:\\Users\\UserName\\AppData\\Local\\Android\\Sdk\\tools\\lib\\monitor-x86\\monito" +
	"r.exe";
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label8.Location = new System.Drawing.Point(3, 86);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(139, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "Путь к файлу monitor.exe";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.ForeColor = System.Drawing.Color.Gray;
			this.label6.Location = new System.Drawing.Point(179, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(465, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "например C:\\Users\\UserName\\AppData\\Local\\Android\\sdk\\platform-tools\\adb.exe";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label5.Location = new System.Drawing.Point(3, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Путь к файлу adb.exe";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 15);
			this.label2.TabIndex = 21;
			this.label2.Text = "Android SDK:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label1.Location = new System.Drawing.Point(12, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(649, 2);
			this.label1.TabIndex = 25;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.button8);
			this.panel4.Controls.Add(this.pathFilesTextBox);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.button7);
			this.panel4.Controls.Add(this.pathCommandsTextBox);
			this.panel4.Controls.Add(this.label15);
			this.panel4.Controls.Add(this.button6);
			this.panel4.Controls.Add(this.pathBuildsTextBox);
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.label13);
			this.panel4.Location = new System.Drawing.Point(12, 179);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(649, 139);
			this.panel4.TabIndex = 26;
			// 
			// button8
			// 
			this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.ForeColor = System.Drawing.Color.Gray;
			this.button8.Location = new System.Drawing.Point(613, 80);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(30, 23);
			this.button8.TabIndex = 24;
			this.button8.Text = "...";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// pathFilesTextBox
			// 
			this.pathFilesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathFilesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.pathFilesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathFilesTextBox.Enabled = false;
			this.pathFilesTextBox.Location = new System.Drawing.Point(179, 81);
			this.pathFilesTextBox.Name = "pathFilesTextBox";
			this.pathFilesTextBox.Size = new System.Drawing.Size(428, 20);
			this.pathFilesTextBox.TabIndex = 23;
			// 
			// label16
			// 
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label16.Location = new System.Drawing.Point(1, 86);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(139, 23);
			this.label16.TabIndex = 22;
			this.label16.Text = "Папка для files";
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = System.Drawing.Color.Gray;
			this.button7.Location = new System.Drawing.Point(613, 54);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(30, 23);
			this.button7.TabIndex = 21;
			this.button7.Text = "...";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// pathCommandsTextBox
			// 
			this.pathCommandsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathCommandsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.pathCommandsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathCommandsTextBox.Enabled = false;
			this.pathCommandsTextBox.Location = new System.Drawing.Point(179, 55);
			this.pathCommandsTextBox.Name = "pathCommandsTextBox";
			this.pathCommandsTextBox.Size = new System.Drawing.Size(428, 20);
			this.pathCommandsTextBox.TabIndex = 20;
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label15.Location = new System.Drawing.Point(1, 60);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(139, 23);
			this.label15.TabIndex = 19;
			this.label15.Text = "Папка для commands";
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = System.Drawing.Color.Gray;
			this.button6.Location = new System.Drawing.Point(613, 27);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(30, 23);
			this.button6.TabIndex = 18;
			this.button6.Text = "...";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// pathBuildsTextBox
			// 
			this.pathBuildsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pathBuildsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
			this.pathBuildsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathBuildsTextBox.Enabled = false;
			this.pathBuildsTextBox.Location = new System.Drawing.Point(179, 29);
			this.pathBuildsTextBox.Name = "pathBuildsTextBox";
			this.pathBuildsTextBox.Size = new System.Drawing.Size(428, 20);
			this.pathBuildsTextBox.TabIndex = 17;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label14.Location = new System.Drawing.Point(1, 34);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(139, 23);
			this.label14.TabIndex = 16;
			this.label14.Text = "Папка для builds";
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label13.Location = new System.Drawing.Point(1, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(725, 18);
			this.label13.TabIndex = 0;
			this.label13.Text = "Перечень адресов к папкам внутри каталога resource";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(12, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 15);
			this.label4.TabIndex = 24;
			this.label4.Text = "Ресурсы:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(673, 374);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SettingsForm";
			this.Text = "Настройки";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsFormFormClosed);
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
