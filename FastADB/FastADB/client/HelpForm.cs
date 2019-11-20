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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = DataResources.helpShow;
            richTextBox1.Rtf = textBox1.Text;
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataResources.helpShow = checkBox1.Checked;
            DataResources.saveConfigFile();
            DataResources.updateDefaultScripts();
            DataForms.FHelp = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch (Exception ex)
            {
                DataResources.consoleMessage("ОШИБКА " + ex.Message);
            }
        }
    }
}
