using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ContactManager
{
    public partial class Settings : Form
    {
        public Color ReturnContentColor { get; set; }
        public Color ReturnBackColor { get; set; }

        
        Color _contentColor = Color.Navy;
        public Color ContentColor
        {
            get
            {
                return _contentColor;
            }
            set
            {
                if (value != _contentColor)
                {
                    _contentColor = value;
                    ContentColorChange(_contentColor);
                }
            }
        }

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
            ContentColorChange(ContentColor);
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
        public void ContentColorChange(Color contentColor)
        {
            SettingsContentColor(contentColor);
            //LoginWindow.ContactColor = contentColor;
        }

        public void SettingsContentColor(Color contentColor)
        {
            this.label1.ForeColor = contentColor;
            this.label2.ForeColor = contentColor;
            this.label3.ForeColor = contentColor;
            this.label4.ForeColor = contentColor;
            this.loadFileButton.BackColor = contentColor;
            this.confirmButton.BackColor = contentColor;
        }

        private void customColorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                customColorPanel.BackColor = colorDialog1.Color;
            }

            customColorToggleButton1.Checked = false;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.ReturnContentColor = ContentColor;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /*
        private void ContactSave()
        {
            List<Account> Accounts = new List<Account>();

            var jsonString = File.ReadAllText(LoginWindow.ContactsFile);
            Accounts = JsonConvert.DeserializeObject<List<Account>>(jsonString);

            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Password == LoginWindow.Account.Password && Accounts[i].Username == LoginWindow.Account.Username)
                {
                    Accounts[i] = LoginWindow.Account;
                }
            }

            string jsonNewString = JsonConvert.SerializeObject(Accounts, Formatting.Indented);
            File.WriteAllText(LoginWindow.ContactsFile, jsonNewString);
        }
        */
    }
}
