using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastADB.data;

namespace FastADB.client
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            DataResources.checkFolders();

            pathAdbTextBox.Text = DataResources.adbSysPath;
            pathAaptTextBox.Text = DataResources.aaptSysPath;
            pathMonitorTextBox.Text = DataResources.ddmsSysPath;
            pathBuildsTextBox.Text = DataResources.buildsPath;
            pathCommandsTextBox.Text = DataResources.commandsPath;
            pathFilesTextBox.Text = DataResources.filesPath;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataForms.FSettings = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "adb.exe";
            openFileDialog1.Filter = "adb.exe|adb.exe|*.*|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathAdbTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "aapt.exe";
            openFileDialog1.Filter = "aapt.exe|aapt.exe|*.*|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathAaptTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "monitor.exe";
            openFileDialog1.Filter = "monitor.exe|monitor.exe|*.*|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathMonitorTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = DataResources.buildsPath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathBuildsTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = DataResources.commandsPath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathCommandsTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = DataResources.filesPath;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathFilesTextBox.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataResources.adbSysPath = pathAdbTextBox.Text;
            DataResources.aaptSysPath = pathAaptTextBox.Text;
            DataResources.ddmsSysPath = pathMonitorTextBox.Text;
            DataResources.buildsPath = pathBuildsTextBox.Text;
            DataResources.commandsPath = pathCommandsTextBox.Text;
            DataResources.filesPath = pathFilesTextBox.Text;

            DataResources.saveConfigFile();
            DataResources.updateDefaultScripts();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
