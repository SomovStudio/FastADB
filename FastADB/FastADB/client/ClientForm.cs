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
    }
}
