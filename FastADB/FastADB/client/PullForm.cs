using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using FastADB.data;

namespace FastADB.client
{
    public partial class PullForm : Form
    {
        public PullForm()
        {
            InitializeComponent();
        }

        public delegate void AddConsoleItem(String message);
        public AddConsoleItem myDelegate;
        Process P;

        public void addConsoleItemMethod(String message)
        {
            DataResources.consoleMessage(message);
        }

        private void PullForm_Load(object sender, EventArgs e)
        {
            myDelegate = new AddConsoleItem(addConsoleItemMethod);

            DataResources.checkFolders();
            String filename = DataResources.commandsPath + "adb_pull.bat";
            if (!File.Exists(filename))
            {
                DataResources.saveFile(filename, DataResources.initPull("video.mp4", "/sdcard/", DataResources.filesPath));
            }
            scriptTextBox.Text = DataResources.readFile(filename);

            filenameTextBox.Text = "video.mp4";
            folderDeviceTextBox.Text = "/sdcard/";
            folderPcTextBox.Text = DataResources.filesPath;

            linkLabel5.Select();
            pathLabel.Text = filename;
        }

        private void PullForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (P != null)
            {
                P.Close();
                DataResources.consoleMessage("Процесс pull - остановлен");
            }
            DataForms.FPull = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = DataResources.commandsPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                scriptTextBox.Text = DataResources.readFile(openFileDialog1.FileName);
                pathLabel.Text = openFileDialog1.FileName;
                DataResources.consoleMessage("Файл " + pathLabel.Text + " открыт");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DataResources.saveFile(pathLabel.Text, scriptTextBox.Text) == true)
            {
                DataResources.consoleMessage("Файл " + pathLabel.Text + " сохранён");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            saveFileDialog1.InitialDirectory = DataResources.commandsPath;
            saveFileDialog1.FileName = "adb_pull.bat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathLabel.Text = saveFileDialog1.FileName;
                if (DataResources.saveFile(saveFileDialog1.FileName, scriptTextBox.Text) == true)
                {
                    DataResources.consoleMessage("Файл " + pathLabel.Text + " сохранён");
                }
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(folderPcTextBox.Text);
            }
            catch (Exception ex)
            {
                DataResources.consoleMessage("ОШИБКА: " + ex.Message);
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DataResources.saveFile(pathLabel.Text, scriptTextBox.Text);

                P = new Process();
                P.StartInfo.FileName = pathLabel.Text;
                P.StartInfo.Arguments = "/k";
                P.StartInfo.RedirectStandardError = true;
                P.StartInfo.RedirectStandardInput = true;
                P.StartInfo.RedirectStandardOutput = true;
                P.StartInfo.CreateNoWindow = true;
                P.StartInfo.UseShellExecute = false;
                P.ErrorDataReceived += P_ErrorDataReceived;
                P.OutputDataReceived += P_OutputDataReceived;
                P.Start();
                P.BeginErrorReadLine();
                P.BeginOutputReadLine();

            }
            catch (Exception ex)
            {
                DataResources.consoleMessage("ОШИБКА: " + ex.Message);
            }
        }

        void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(this.myDelegate, new object[] { "ОШИБКА: " + e.Data.ToString() });
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

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (P != null)
            {
                P.Close();
                P = null;
                DataResources.consoleMessage("Процесс screencap - остановлен");
            }
        }

        private void filenameTextBox_TextChanged(object sender, EventArgs e)
        {
            scriptTextBox.Text = DataResources.initPull(filenameTextBox.Text, folderDeviceTextBox.Text, folderPcTextBox.Text);
        }

        private void folderDeviceTextBox_TextChanged(object sender, EventArgs e)
        {
            scriptTextBox.Text = DataResources.initPull(filenameTextBox.Text, folderDeviceTextBox.Text, folderPcTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = DataResources.filesPath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPcTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
                scriptTextBox.Text = DataResources.initPull(filenameTextBox.Text, folderDeviceTextBox.Text, folderPcTextBox.Text);
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            scriptTextBox.Text = DataResources.initPullAndRm(filenameTextBox.Text, folderDeviceTextBox.Text, folderPcTextBox.Text);
        }
    }
}
