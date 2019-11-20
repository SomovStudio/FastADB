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
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        private void ConverterForm_Load(object sender, EventArgs e)
        {

        }

        private void ConverterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataForms.FConverter = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = DataResources.filesPath;
            openFileDialog1.Filter = "*.txt|*.txt|*.*|*.*";
            openFileDialog1.FileName = "getevents.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                pathLabel1.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            saveFileDialog1.InitialDirectory = DataResources.filesPath;
            saveFileDialog1.Filter = "*.bat|*.bat";
            saveFileDialog1.FileName = "events_play.bat";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (DataResources.saveFile(saveFileDialog1.FileName, richTextBox2.Text) == true)
                {
                    pathLabel2.Text = saveFileDialog1.FileName;
                    DataResources.consoleMessage("Файл " + pathLabel2.Text + " сохранён");
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pathLabel1.Text == "...")
            {
                DataResources.consoleMessage("Конвертация невозможна! Вы не открыли файл событий getevents.txt");
                return;
            }

            String text = "";
            String command = "";
            if (DataResources.adbSysPath == "")
            {
                command = "adb shell sendevent ";
            }
            else
            {
                command = DataResources.adbSysPath + " shell sendevent ";
            }
            String dev = "";
            String num1 = "";
            String num2 = "";
            String num3 = "";

            String[] words = richTextBox1.Text.Split(new Char[] { ' ' });
            int count = words.Length - 1;
            int length = 0;
            for (int i = 0; i < count; i++)
            {
                length = words[i].Length;
                if (length == 0) continue;
                if (words[i][0].ToString() == "/" && words[i][length - 1].ToString() == ":")
                {

                    dev = words[i].Substring(0, length - 1);
                    num1 = " " + Convert.ToInt32(words[i + 1], 16);
                    num2 = " " + Convert.ToInt32(words[i + 2], 16);
                    num3 = " " + Convert.ToInt32(words[i + 3], 16);

                    text += command + dev + num1 + num2 + num3 + Environment.NewLine;
                }
            }
            richTextBox2.Text = text;
        }
    }
}
