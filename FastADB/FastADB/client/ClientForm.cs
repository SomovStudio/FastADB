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

        public void consoleMessage(String message)
        {
            consoleRichTextBox.Text = consoleRichTextBox.Text + message + Environment.NewLine;
            consoleRichTextBox.Select(consoleRichTextBox.Text.Length, consoleRichTextBox.Text.Length);
            consoleRichTextBox.ScrollToCaret();
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {

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
