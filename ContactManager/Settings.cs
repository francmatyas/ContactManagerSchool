using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class Settings : Form
    {
        public Color ContentColor = Color.Navy;

        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName.Replace(@"\", "/");
                fileLabel.Text = "File: " + selectedFile;
                LoginWindow.ContactsFile = selectedFile;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            fileLabel.Text = "File: " + LoginWindow.ContactsFile;
        }

        private void dataTypeToggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dataTypeToggleButton.Checked)
            {
                JSONPanel.Visible = false;
            }
            else
            {
                JSONPanel.Visible = true;
            }
        }

        private void blueToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (blueToggleButton1.Checked)
            {
                ContentColor = Color.Navy;
                greenToggleButton1.Checked = false;
                orangeToggleButton1.Checked = false;
                customColorToggleButton1.Checked = false;
            }
        }

        private void greenToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (greenToggleButton1.Checked)
            {
                ContentColor = Color.SeaGreen;
                blueToggleButton1.Checked = false;
                orangeToggleButton1.Checked = false;
                customColorToggleButton1.Checked = false;
            }
        }

        private void orangeToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (orangeToggleButton1.Checked)
            {
                ContentColor = Color.DarkOrange;
                blueToggleButton1.Checked = false;
                greenToggleButton1.Checked = false;
                customColorToggleButton1.Checked = false;
            }
        }

        private void customColorToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (customColorToggleButton1.Checked)
            {
                customColorToggleButton1.OnBackColor = customColorPanel.BackColor;
                ContentColor = customColorPanel.BackColor;
                blueToggleButton1.Checked = false;
                greenToggleButton1.Checked = false;
                orangeToggleButton1.Checked = false;
            }
        }

        private void customColorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                customColorPanel.BackColor = colorDialog1.Color;
            }
        }
    }
}
