/*
 * Created by SharpDevelop.
 * User: Catfish
 * Date: 02.10.2018
 * Time: 8:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FastADB.client
{
	partial class ClientForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem очиститьКонсольToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem папкаПрограммыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem закрытьПрограммуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem командыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDBDevicesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDBLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьВсеПроцессыADBToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem утилитыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem диспетчерУстройствToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem системнаяКонсольToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.RichTextBox consoleRichTextBox;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.LinkLabel linkLabel11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.LinkLabel linkLabel10;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.ToolStripMenuItem aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDBScreenrecordToolStripMenuItem;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.ToolStripMenuItem aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.ToolStripMenuItem aDBInstallToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDBMonkeyToolStripMenuItem;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.ToolStripMenuItem aAPTDumpBadgingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dDMSToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem конвертерСобытийToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDBGeteventToolStripMenuItem;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.очиститьКонсольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.папкаПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.закрытьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.командыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDBDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьВсеПроцессыADBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.aDBLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDBScreenrecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDBInstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDBMonkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDBGeteventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.утилитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aAPTDumpBadgingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dDMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.конвертерСобытийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.диспетчерУстройствToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.системнаяКонсольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.consoleRichTextBox = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.label11 = new System.Windows.Forms.Label();
			this.linkLabel6 = new System.Windows.Forms.LinkLabel();
			this.label10 = new System.Windows.Forms.Label();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.label9 = new System.Windows.Forms.Label();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.label8 = new System.Windows.Forms.Label();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.label7 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label16 = new System.Windows.Forms.Label();
			this.linkLabel11 = new System.Windows.Forms.LinkLabel();
			this.label15 = new System.Windows.Forms.Label();
			this.linkLabel10 = new System.Windows.Forms.LinkLabel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.очиститьКонсольToolStripMenuItem,
			this.копироватьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(244, 70);
			// 
			// очиститьКонсольToolStripMenuItem
			// 
			this.очиститьКонсольToolStripMenuItem.Name = "очиститьКонсольToolStripMenuItem";
			this.очиститьКонсольToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.очиститьКонсольToolStripMenuItem.Text = "Очистить консоль";
			this.очиститьКонсольToolStripMenuItem.Click += new System.EventHandler(this.ОчиститьКонсольToolStripMenuItemClick);
			// 
			// копироватьToolStripMenuItem
			// 
			this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
			this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
			this.копироватьToolStripMenuItem.Text = "Копировать выделенный текст";
			this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.КопироватьToolStripMenuItemClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.файлToolStripMenuItem,
			this.командыToolStripMenuItem,
			this.утилитыToolStripMenuItem,
			this.сервисToolStripMenuItem,
			this.настройкиToolStripMenuItem,
			this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.папкаПрограммыToolStripMenuItem,
			this.закрытьПрограммуToolStripMenuItem});
			this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// папкаПрограммыToolStripMenuItem
			// 
			this.папкаПрограммыToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.папкаПрограммыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.папкаПрограммыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("папкаПрограммыToolStripMenuItem.Image")));
			this.папкаПрограммыToolStripMenuItem.Name = "папкаПрограммыToolStripMenuItem";
			this.папкаПрограммыToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.папкаПрограммыToolStripMenuItem.Text = "Открыть папку ресурсов";
			this.папкаПрограммыToolStripMenuItem.Click += new System.EventHandler(this.ПапкаПрограммыToolStripMenuItemClick);
			// 
			// закрытьПрограммуToolStripMenuItem
			// 
			this.закрытьПрограммуToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.закрытьПрограммуToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.закрытьПрограммуToolStripMenuItem.Name = "закрытьПрограммуToolStripMenuItem";
			this.закрытьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.закрытьПрограммуToolStripMenuItem.Text = "Закрыть программу";
			this.закрытьПрограммуToolStripMenuItem.Click += new System.EventHandler(this.ЗакрытьПрограммуToolStripMenuItemClick);
			// 
			// командыToolStripMenuItem
			// 
			this.командыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aDBDevicesToolStripMenuItem,
			this.удалитьВсеПроцессыADBToolStripMenuItem,
			this.toolStripSeparator1,
			this.aDBLogToolStripMenuItem,
			this.aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem,
			this.aDBScreenrecordToolStripMenuItem,
			this.aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem,
			this.aDBInstallToolStripMenuItem,
			this.aDBMonkeyToolStripMenuItem,
			this.aDBGeteventToolStripMenuItem});
			this.командыToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.командыToolStripMenuItem.Name = "командыToolStripMenuItem";
			this.командыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.командыToolStripMenuItem.Text = "Команды";
			// 
			// aDBDevicesToolStripMenuItem
			// 
			this.aDBDevicesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.aDBDevicesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.aDBDevicesToolStripMenuItem.Name = "aDBDevicesToolStripMenuItem";
			this.aDBDevicesToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.aDBDevicesToolStripMenuItem.Text = "Проверить подключение устройств";
			this.aDBDevicesToolStripMenuItem.Click += new System.EventHandler(this.ADBDevicesToolStripMenuItemClick);
			// 
			// удалитьВсеПроцессыADBToolStripMenuItem
			// 
			this.удалитьВсеПроцессыADBToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.удалитьВсеПроцессыADBToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.удалитьВсеПроцессыADBToolStripMenuItem.Name = "удалитьВсеПроцессыADBToolStripMenuItem";
			this.удалитьВсеПроцессыADBToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.удалитьВсеПроцессыADBToolStripMenuItem.Text = "Удалить все процессы adb";
			this.удалитьВсеПроцессыADBToolStripMenuItem.Click += new System.EventHandler(this.УдалитьВсеПроцессыADBToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(438, 6);
			// 
			// aDBLogToolStripMenuItem
			// 
			this.aDBLogToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.aDBLogToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.aDBLogToolStripMenuItem.Name = "aDBLogToolStripMenuItem";
			this.aDBLogToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.aDBLogToolStripMenuItem.Text = "ADB: logcat (получить лог с устройства)";
			this.aDBLogToolStripMenuItem.Click += new System.EventHandler(this.ADBLogToolStripMenuItemClick);
			// 
			// aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem
			// 
			this.aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem.Name = "aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem";
			this.aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem.Text = "ADB: screencap (снять скрин с экрана устройства)";
			this.aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem.Click += new System.EventHandler(this.ADBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItemClick);
			// 
			// aDBScreenrecordToolStripMenuItem
			// 
			this.aDBScreenrecordToolStripMenuItem.Name = "aDBScreenrecordToolStripMenuItem";
			this.aDBScreenrecordToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.aDBScreenrecordToolStripMenuItem.Text = "ADB: screenrecord (записать видео с экрана устройства)";
			this.aDBScreenrecordToolStripMenuItem.Click += new System.EventHandler(this.ADBScreenrecordToolStripMenuItemClick);
			// 
			// aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem
			// 
			this.aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem.Name = "aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem";
			this.aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem.Text = "ADB: pull (копирование файла с устройства на компьютер)";
			this.aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem.Click += new System.EventHandler(this.ADBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItemClick);
			// 
			// aDBInstallToolStripMenuItem
			// 
			this.aDBInstallToolStripMenuItem.Name = "aDBInstallToolStripMenuItem";
			this.aDBInstallToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.aDBInstallToolStripMenuItem.Text = "ADB: install (установка apk пакетов на устройство)";
			this.aDBInstallToolStripMenuItem.Click += new System.EventHandler(this.ADBInstallToolStripMenuItemClick);
			// 
			// aDBMonkeyToolStripMenuItem
			// 
			this.aDBMonkeyToolStripMenuItem.Name = "aDBMonkeyToolStripMenuItem";
			this.aDBMonkeyToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.aDBMonkeyToolStripMenuItem.Text = "ADB: monkey (стресс-тестирование приложения на устройстве)";
			this.aDBMonkeyToolStripMenuItem.Click += new System.EventHandler(this.ADBMonkeyToolStripMenuItemClick);
			// 
			// aDBGeteventToolStripMenuItem
			// 
			this.aDBGeteventToolStripMenuItem.Name = "aDBGeteventToolStripMenuItem";
			this.aDBGeteventToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
			this.aDBGeteventToolStripMenuItem.Text = "ADB: getevent (записать и воспроизведение событий с устройства)";
			this.aDBGeteventToolStripMenuItem.Click += new System.EventHandler(this.ADBGeteventToolStripMenuItemClick);
			// 
			// утилитыToolStripMenuItem
			// 
			this.утилитыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aAPTDumpBadgingToolStripMenuItem,
			this.dDMSToolStripMenuItem,
			this.toolStripSeparator2,
			this.конвертерСобытийToolStripMenuItem});
			this.утилитыToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.утилитыToolStripMenuItem.Name = "утилитыToolStripMenuItem";
			this.утилитыToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.утилитыToolStripMenuItem.Text = "Утилиты";
			// 
			// aAPTDumpBadgingToolStripMenuItem
			// 
			this.aAPTDumpBadgingToolStripMenuItem.Name = "aAPTDumpBadgingToolStripMenuItem";
			this.aAPTDumpBadgingToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
			this.aAPTDumpBadgingToolStripMenuItem.Text = "AAPT: dump badging";
			this.aAPTDumpBadgingToolStripMenuItem.Click += new System.EventHandler(this.AAPTDumpBadgingToolStripMenuItemClick);
			// 
			// dDMSToolStripMenuItem
			// 
			this.dDMSToolStripMenuItem.Name = "dDMSToolStripMenuItem";
			this.dDMSToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
			this.dDMSToolStripMenuItem.Text = "DDMS (Dalvik Debug Monitor Server)";
			this.dDMSToolStripMenuItem.Click += new System.EventHandler(this.DDMSToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(266, 6);
			// 
			// конвертерСобытийToolStripMenuItem
			// 
			this.конвертерСобытийToolStripMenuItem.Name = "конвертерСобытийToolStripMenuItem";
			this.конвертерСобытийToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
			this.конвертерСобытийToolStripMenuItem.Text = "Конвертер событий (getevents)";
			this.конвертерСобытийToolStripMenuItem.Click += new System.EventHandler(this.КонвертерСобытийToolStripMenuItemClick);
			// 
			// сервисToolStripMenuItem
			// 
			this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.диспетчерУстройствToolStripMenuItem,
			this.системнаяКонсольToolStripMenuItem});
			this.сервисToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
			this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.сервисToolStripMenuItem.Text = "Сервис";
			// 
			// диспетчерУстройствToolStripMenuItem
			// 
			this.диспетчерУстройствToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.диспетчерУстройствToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.диспетчерУстройствToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("диспетчерУстройствToolStripMenuItem.Image")));
			this.диспетчерУстройствToolStripMenuItem.Name = "диспетчерУстройствToolStripMenuItem";
			this.диспетчерУстройствToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.диспетчерУстройствToolStripMenuItem.Text = "Диспетчер устройств";
			this.диспетчерУстройствToolStripMenuItem.Click += new System.EventHandler(this.ДиспетчерУстройствToolStripMenuItemClick);
			// 
			// системнаяКонсольToolStripMenuItem
			// 
			this.системнаяКонсольToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.системнаяКонсольToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.системнаяКонсольToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("системнаяКонсольToolStripMenuItem.Image")));
			this.системнаяКонсольToolStripMenuItem.Name = "системнаяКонсольToolStripMenuItem";
			this.системнаяКонсольToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
			this.системнаяКонсольToolStripMenuItem.Text = "Системная консоль";
			this.системнаяКонсольToolStripMenuItem.Click += new System.EventHandler(this.СистемнаяКонсольToolStripMenuItemClick);
			// 
			// настройкиToolStripMenuItem
			// 
			this.настройкиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
			this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.настройкиToolStripMenuItem.Text = "Настройки";
			this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.НастройкиToolStripMenuItemClick);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.помощьToolStripMenuItem,
			this.инструкцияToolStripMenuItem,
			this.оПрограммеToolStripMenuItem});
			this.справкаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// помощьToolStripMenuItem
			// 
			this.помощьToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.помощьToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
			this.помощьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.помощьToolStripMenuItem.Text = "Помощь";
			this.помощьToolStripMenuItem.Click += new System.EventHandler(this.ПомощьToolStripMenuItemClick);
			// 
			// инструкцияToolStripMenuItem
			// 
			this.инструкцияToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.инструкцияToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
			this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.инструкцияToolStripMenuItem.Text = "Руководство";
			this.инструкцияToolStripMenuItem.Visible = false;
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
			this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.оПрограммеToolStripMenuItem.Text = "О программе...";
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItemClick);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 707);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(129, 17);
			this.toolStripStatusLabel1.Text = "2018 © Somov Evgeniy";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(91, 17);
			this.toolStripStatusLabel2.Text = "Лицензия: GNU";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(0, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1008, 44);
			this.label1.TabIndex = 8;
			this.label1.Text = "Утилита для работы с Android Debug Bridge             ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 538);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1008, 169);
			this.panel2.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label5.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1004, 2);
			this.label5.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.consoleRichTextBox);
			this.panel4.Location = new System.Drawing.Point(3, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1004, 166);
			this.panel4.TabIndex = 2;
			// 
			// consoleRichTextBox
			// 
			this.consoleRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.consoleRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.consoleRichTextBox.ContextMenuStrip = this.contextMenuStrip1;
			this.consoleRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.consoleRichTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.consoleRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.consoleRichTextBox.Location = new System.Drawing.Point(0, 0);
			this.consoleRichTextBox.Name = "consoleRichTextBox";
			this.consoleRichTextBox.ReadOnly = true;
			this.consoleRichTextBox.Size = new System.Drawing.Size(1002, 164);
			this.consoleRichTextBox.TabIndex = 0;
			this.consoleRichTextBox.Text = "";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 68);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 470);
			this.panel1.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(194, 2);
			this.label3.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(3, 455);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 15);
			this.label4.TabIndex = 16;
			this.label4.Text = "Консоль:";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.linkLabel7);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.linkLabel6);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.linkLabel5);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.linkLabel4);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.linkLabel3);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.linkLabel2);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.linkLabel1);
			this.panel3.Controls.Add(this.label16);
			this.panel3.Controls.Add(this.linkLabel11);
			this.panel3.Controls.Add(this.label15);
			this.panel3.Controls.Add(this.linkLabel10);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Location = new System.Drawing.Point(3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(194, 450);
			this.panel3.TabIndex = 17;
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label12.Location = new System.Drawing.Point(3, 420);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(186, 31);
			this.label12.TabIndex = 38;
			this.label12.Text = "Копирование файла с устройства на компьютер";
			// 
			// linkLabel7
			// 
			this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel7.Location = new System.Drawing.Point(3, 405);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(186, 18);
			this.linkLabel7.TabIndex = 37;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "ADB: Pull";
			this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel7LinkClicked);
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label11.Location = new System.Drawing.Point(3, 370);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(186, 31);
			this.label11.TabIndex = 36;
			this.label11.Text = "Запись и воспроизведение событий устройства.";
			// 
			// linkLabel6
			// 
			this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel6.Location = new System.Drawing.Point(3, 355);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(186, 18);
			this.linkLabel6.TabIndex = 35;
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = "ADB: Get/Set events";
			this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel6LinkClicked);
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label10.Location = new System.Drawing.Point(3, 320);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(186, 31);
			this.label10.TabIndex = 34;
			this.label10.Text = "Стресс-тестирование приложения на устройстве.";
			// 
			// linkLabel5
			// 
			this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel5.Location = new System.Drawing.Point(3, 305);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(186, 18);
			this.linkLabel5.TabIndex = 33;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "ADB: Monkey ";
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel5LinkClicked);
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label9.Location = new System.Drawing.Point(3, 270);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(186, 31);
			this.label9.TabIndex = 32;
			this.label9.Text = "Установка apk пакетов на устройство.";
			// 
			// linkLabel4
			// 
			this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel4.Location = new System.Drawing.Point(3, 255);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(186, 18);
			this.linkLabel4.TabIndex = 31;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "ADB: Install";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4LinkClicked);
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label8.Location = new System.Drawing.Point(3, 220);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(186, 31);
			this.label8.TabIndex = 30;
			this.label8.Text = "Записать видео с экрана устройства.";
			// 
			// linkLabel3
			// 
			this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel3.Location = new System.Drawing.Point(3, 205);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(186, 18);
			this.linkLabel3.TabIndex = 29;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "ADB: Screenrecord";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3LinkClicked);
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label7.Location = new System.Drawing.Point(4, 170);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(186, 31);
			this.label7.TabIndex = 28;
			this.label7.Text = "Снять скриншот с экрана устройства.";
			// 
			// linkLabel2
			// 
			this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel2.Location = new System.Drawing.Point(4, 155);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(186, 18);
			this.linkLabel2.TabIndex = 27;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "ADB: Screencap";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label6.Location = new System.Drawing.Point(3, 120);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(186, 31);
			this.label6.TabIndex = 26;
			this.label6.Text = "Получить системный лога с устройства.";
			// 
			// linkLabel1
			// 
			this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel1.Location = new System.Drawing.Point(3, 105);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(186, 18);
			this.linkLabel1.TabIndex = 25;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "ADB: Logcat";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// label16
			// 
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label16.Location = new System.Drawing.Point(3, 65);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(186, 31);
			this.label16.TabIndex = 24;
			this.label16.Text = "Удалить запущенные процессы связанные с adb.";
			// 
			// linkLabel11
			// 
			this.linkLabel11.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel11.Location = new System.Drawing.Point(3, 50);
			this.linkLabel11.Name = "linkLabel11";
			this.linkLabel11.Size = new System.Drawing.Size(186, 18);
			this.linkLabel11.TabIndex = 23;
			this.linkLabel11.TabStop = true;
			this.linkLabel11.Text = "Removed all adb processes";
			this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel11LinkClicked);
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label15.Location = new System.Drawing.Point(3, 15);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(186, 31);
			this.label15.TabIndex = 22;
			this.label15.Text = "Проверить подключение устройств к компьютеру.";
			// 
			// linkLabel10
			// 
			this.linkLabel10.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(232)))), ((int)(((byte)(236)))));
			this.linkLabel10.Location = new System.Drawing.Point(3, 0);
			this.linkLabel10.Name = "linkLabel10";
			this.linkLabel10.Size = new System.Drawing.Size(186, 18);
			this.linkLabel10.TabIndex = 21;
			this.linkLabel10.TabStop = true;
			this.linkLabel10.Text = "ADB: Devices";
			this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel10LinkClicked);
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Location = new System.Drawing.Point(4, 100);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(185, 1);
			this.panel5.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(3, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 15);
			this.label2.TabIndex = 16;
			this.label2.Text = "Команды:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "*.bat|*.bat";
			// 
			// ClientForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "ClientForm";
			this.Text = "FastADB";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientFormFormClosed);
			this.Load += new System.EventHandler(this.ClientFormLoad);
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
