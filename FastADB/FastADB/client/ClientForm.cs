using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using FastADB.data;

namespace FastADB.client
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        /* ===============================================================================
		 * ПРОВЕРКА ПОДКЛЮЧЕНИЯ УСТРОЙСТВА
		 */
        delegate void AddConsoleItem(String message);
        AddConsoleItem myDelegate;
        Process process;

        public void addConsoleItemMethod(String message)
        {
            DataResources.consoleMessage(message);
        }

        public void checkDeviceConnect()
        {
            try
            {

                process = new Process();
                process.StartInfo.FileName = @DataResources.commandsPath + "adb_devices.bat";
                process.StartInfo.Arguments = "/k";
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.ErrorDataReceived += P_ErrorDataReceived;
                process.OutputDataReceived += P_OutputDataReceived;
                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();

            }
            catch (Exception ex)
            {
                //DataResources.consoleMessage("ОШИБКА: Прогремме не удалось запустить процесс adb devices");
                DataResources.consoleMessage("ОШИБКА: " + ex.Message);
            }
        }

        void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(this.myDelegate, new object[] { e.Data.ToString() });
            }
            catch (Exception ex)
            {

            }
        }

        void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(this.myDelegate, new object[] { e.Data.ToString() });
            }
            catch (Exception ex)
            {

            }
        }
        /* =============================================================================== */

        public void consoleMessage(String message)
        {
            consoleRichTextBox.Text = consoleRichTextBox.Text + message + Environment.NewLine;
            consoleRichTextBox.Select(consoleRichTextBox.Text.Length, consoleRichTextBox.Text.Length);
            consoleRichTextBox.ScrollToCaret();
        }

        private void removedAllAdbProcesses()
        {
            foreach (var p in Process.GetProcessesByName("adb"))
            {
                p.Kill();
            }
            DataResources.consoleMessage("Все процессы ADB удалены");
        }

        /*
         * == СОБЫТИЯ ====================================================================
         */
        private void ClientForm_Load(object sender, EventArgs e)
        {
            myDelegate = new AddConsoleItem(addConsoleItemMethod);

            if (DataResources.helpShow)
            {
                DataForms.FHelp = new HelpForm();
                DataForms.FHelp.MdiParent = DataForms.FClient;
                DataForms.FHelp.Show();
            }

            DataResources.consoleMessage("FastADB версия 1.1 (последнее обновление: 20.11.2019)");
            DataResources.consoleMessage("Проверка подключения устройства...");
            checkDeviceConnect();
        }

        private void ClientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var p in Process.GetProcessesByName("adb"))
            {
                p.Kill();
            }
            DataResources.consoleMessage("Все процессы ADB удалены");
            DataForms.FMain.Close();
        }

        private void открытьПапкуРесурсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(DataResources.folderResource);
            }
            catch (Exception ex)
            {
                DataResources.consoleMessage("ОШИБКА: " + ex.Message);
            }
        }

        private void закрытьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проверитьПодключениеУстройствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkDeviceConnect();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            checkDeviceConnect();
        }

        private void удалитьВсеПроцессыAdbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removedAllAdbProcesses();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            removedAllAdbProcesses();
        }

        private void aDBLogcatполучитьЛогСУстройстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FLog == null)
            {
                DataForms.FLog = new LogForm();
                DataForms.FLog.MdiParent = DataForms.FClient;
                DataForms.FLog.Show();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataForms.FLog == null)
            {
                DataForms.FLog = new LogForm();
                DataForms.FLog.MdiParent = DataForms.FClient;
                DataForms.FLog.Show();
            }
        }

        private void aDBScreencapснятьСкринСЭкранаУстройстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FScreenhot == null)
            {
                DataForms.FScreenhot = new ScreenshotForm();
                DataForms.FScreenhot.MdiParent = DataForms.FClient;
                DataForms.FScreenhot.Show();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataForms.FScreenhot == null)
            {
                DataForms.FScreenhot = new ScreenshotForm();
                DataForms.FScreenhot.MdiParent = DataForms.FClient;
                DataForms.FScreenhot.Show();
            }
        }

        private void aDBScreenrecordзаписатьВидеоСЭкранаУстройстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FScreenrecord == null)
            {
                DataForms.FScreenrecord = new ScreenrecordForm();
                DataForms.FScreenrecord.MdiParent = DataForms.FClient;
                DataForms.FScreenrecord.Show();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataForms.FScreenrecord == null)
            {
                DataForms.FScreenrecord = new ScreenrecordForm();
                DataForms.FScreenrecord.MdiParent = DataForms.FClient;
                DataForms.FScreenrecord.Show();
            }
        }

        private void aDBPullкопированиеФайлаСУстройстваНаКомпьютерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FPull == null)
            {
                DataForms.FPull = new PullForm();
                DataForms.FPull.MdiParent = DataForms.FClient;
                DataForms.FPull.Show();
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataForms.FPull == null)
            {
                DataForms.FPull = new PullForm();
                DataForms.FPull.MdiParent = DataForms.FClient;
                DataForms.FPull.Show();
            }
        }

        private void aDBInstallустановкаApkПакетовНаУстройствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FInstall == null)
            {
                DataForms.FInstall = new InstallForm();
                DataForms.FInstall.MdiParent = DataForms.FClient;
                DataForms.FInstall.Show();
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataForms.FInstall == null)
            {
                DataForms.FInstall = new InstallForm();
                DataForms.FInstall.MdiParent = DataForms.FClient;
                DataForms.FInstall.Show();
            }
        }

        private void aDBMonkeyстресстестированиеПриложенияНаУстройствеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FMonkey == null)
            {
                DataForms.FMonkey = new MonkeyForm();
                DataForms.FMonkey.MdiParent = DataForms.FClient;
                DataForms.FMonkey.Show();
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataForms.FMonkey == null)
            {
                DataForms.FMonkey = new MonkeyForm();
                DataForms.FMonkey.MdiParent = DataForms.FClient;
                DataForms.FMonkey.Show();
            }
        }

        private void aDBGeteventзаписатьИВоспроизведениеСобытийСУстройстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FGetevent == null)
            {
                DataForms.FGetevent = new GeteventForm();
                DataForms.FGetevent.MdiParent = DataForms.FClient;
                DataForms.FGetevent.Show();
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataForms.FGetevent == null)
            {
                DataForms.FGetevent = new GeteventForm();
                DataForms.FGetevent.MdiParent = DataForms.FClient;
                DataForms.FGetevent.Show();
            }
        }

        private void aAPTDumpBadgingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = DataResources.buildsPath;
            openFileDialog1.Filter = "*.apk|*.apk";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filename = DataResources.commandsPath + "aapt_dump_badging.bat";
                DataResources.saveFile(filename, DataResources.initAAPT(openFileDialog1.FileName));

                try
                {
                    process = new Process();
                    process.StartInfo.FileName = filename;
                    process.StartInfo.Arguments = "/k";
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.RedirectStandardInput = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.UseShellExecute = false;
                    process.ErrorDataReceived += P_ErrorDataReceived;
                    process.OutputDataReceived += P_OutputDataReceived;
                    process.Start();
                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();

                }
                catch (Exception ex)
                {
                    DataResources.consoleMessage("ОШИБКА: " + ex.Message);
                }
            }
        }

        private void dDMSDalvikDebugMonitorServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                process = new Process();
                process.StartInfo.FileName = DataResources.commandsPath + "ddms.bat";
                process.StartInfo.Arguments = "/k";
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.ErrorDataReceived += P_ErrorDataReceived;
                process.OutputDataReceived += P_OutputDataReceived;
                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();

            }
            catch (Exception ex)
            {
                DataResources.consoleMessage("ОШИБКА: " + ex.Message);
            }
        }

        private void конвертерСобытийgeteventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FConverter == null)
            {
                DataForms.FConverter = new ConverterForm();
                DataForms.FConverter.MdiParent = DataForms.FClient;
                DataForms.FConverter.Show();
            }
        }

        private void диспетчерУстройствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("devmgmt.msc");
            }
            catch (Exception ex)
            {
                DataResources.consoleMessage("ОШИБКА: " + ex.Message);
            }
        }

        private void системнаяКонсольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("cmd.exe");
            }
            catch (Exception ex)
            {
                DataResources.consoleMessage("ОШИБКА: " + ex.Message);
            }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FSettings == null)
            {
                DataForms.FSettings = new SettingsForm();
                DataForms.FSettings.MdiParent = DataForms.FClient;
                DataForms.FSettings.Show();
            }
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataForms.FHelp == null)
            {
                DataForms.FHelp = new HelpForm();
                DataForms.FHelp.MdiParent = DataForms.FClient;
                DataForms.FHelp.Show();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа: FastADB" + Environment.NewLine +
                            "Разработчик: Сомов Евгений Павлович" + Environment.NewLine +
                            "Лицензия: GNU" + Environment.NewLine +
                            "Версия 1.1" + Environment.NewLine +
                            "Дата последнего обновления: 08.11.2018" + Environment.NewLine +
                            "Сайт разработчика: https://somov-qa.github.io/",
                            "О программе", MessageBoxButtons.OK);
        }
    }
}
