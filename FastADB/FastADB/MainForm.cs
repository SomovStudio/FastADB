using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FastADB.data;
using FastADB.client;

namespace FastADB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            try
            {
                DataResources.createResourceFolder();
                DataResources.createDefaultScripts();
                DataResources.createConfigFile();
                DataResources.readConfigFile();
                showClient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Запустите программу от имени администратора.", "Сообщение");
                DataConfig.programClose = true;
                Application.Exit();
            }
        }

        private void showClient()
        {
            DataForms.FMain = this;
            DataForms.FMain.Visible = false;
            DataConfig.programClose = false;

            DataForms.FClient = new ClientForm();
            DataForms.FClient.Show();
        }
    }
}
