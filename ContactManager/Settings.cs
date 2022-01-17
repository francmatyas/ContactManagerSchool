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
        public Color ReturnPrimaryContentColor { get; set; }
        public Color ReturnSecondaryHContentColor { get; set; }
        public Color ReturnSecondaryCContentColor { get; set; }
        public Color ReturnBackColor { get; set; }

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

            switch (LoginWindow.PrimaryContentColor.Name)
            {
                case "Navy":
                {
                    blueToggleButton1.Checked = true;
                    break;
                }
                case "SeaGreen":
                {
                    greenToggleButton1.Checked = true;
                    break;
                }
                case "DarkOrange":
                {
                    orangeToggleButton1.Checked = true;
                    break;
                }
                default:
                {
                    customColorToggleButton1.Checked = true;
                    customColorToggleButton1.OnBackColor = LoginWindow.PrimaryContentColor;
                    customColorPanel.BackColor = LoginWindow.PrimaryContentColor;
                    break;
                }
            }
            SettingsContentColor(LoginWindow.PrimaryContentColor, LoginWindow.SecondaryHContentColor, LoginWindow.SecondaryCContentColor);
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
                //ContentColor = Color.Navy;

                ReturnPrimaryContentColor = Color.Navy;
                ReturnSecondaryHContentColor = Color.DarkBlue;
                ReturnSecondaryCContentColor = Color.MidnightBlue;

                SettingsContentColor(ReturnPrimaryContentColor, ReturnSecondaryHContentColor, ReturnSecondaryCContentColor);

                greenToggleButton1.Checked = false;
                orangeToggleButton1.Checked = false;
                customColorToggleButton1.Checked = false;
            }
        }

        private void greenToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (greenToggleButton1.Checked)
            {
                //ContentColor = Color.SeaGreen;

                ReturnPrimaryContentColor = Color.SeaGreen;
                ReturnSecondaryHContentColor = Color.MediumSeaGreen;
                ReturnSecondaryCContentColor = Color.DarkGreen;

                SettingsContentColor(ReturnPrimaryContentColor, ReturnSecondaryHContentColor, ReturnSecondaryCContentColor);

                blueToggleButton1.Checked = false;
                orangeToggleButton1.Checked = false;
                customColorToggleButton1.Checked = false;
            }
        }

        private void orangeToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (orangeToggleButton1.Checked)
            {
                //ContentColor = Color.DarkOrange;

                ReturnPrimaryContentColor = Color.DarkOrange;
                ReturnSecondaryHContentColor = Color.Orange;
                ReturnSecondaryCContentColor = Color.Chocolate;

                SettingsContentColor(ReturnPrimaryContentColor, ReturnSecondaryHContentColor, ReturnSecondaryCContentColor);

                blueToggleButton1.Checked = false;
                greenToggleButton1.Checked = false;
                customColorToggleButton1.Checked = false;
            }
        }

        private void customColorToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (customColorToggleButton1.Checked)
            {
                //ContentColor = customColorPanel.BackColor;

                ReturnPrimaryContentColor = this.customColorPanel.BackColor;
                ReturnSecondaryCContentColor = this.secondaryCCustomColorPanel.BackColor;
                ReturnSecondaryHContentColor = this.secondaryHCustomColorPanel.BackColor;

                SettingsContentColor(ReturnPrimaryContentColor, ReturnSecondaryHContentColor, ReturnSecondaryCContentColor);

                blueToggleButton1.Checked = false;
                greenToggleButton1.Checked = false;
                orangeToggleButton1.Checked = false;
            }
        }

        public void SettingsContentColor(Color primaryContentColor, Color secondaryHContentColor, Color secondaryCContentColor)
        {
            this.label1.ForeColor = primaryContentColor;
            this.label2.ForeColor = primaryContentColor;
            this.label3.ForeColor = primaryContentColor;
            this.label4.ForeColor = primaryContentColor;
            this.loadFileButton.BackColor = primaryContentColor;
            this.loadFileButton.FlatAppearance.MouseDownBackColor = secondaryCContentColor;
            this.loadFileButton.FlatAppearance.MouseOverBackColor = secondaryHContentColor;
            this.confirmButton.BackColor = primaryContentColor;
            this.confirmButton.FlatAppearance.MouseDownBackColor = secondaryCContentColor;
            this.confirmButton.FlatAppearance.MouseOverBackColor = secondaryHContentColor;
        }

        private void customColorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                customColorPanel.BackColor = colorDialog1.Color;
                customColorToggleButton1.OnBackColor = colorDialog1.Color;
            }

            customColorToggleButton1.Checked = false;
        }
        private void secondaryHCustomColorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                secondaryHCustomColorPanel.BackColor = colorDialog1.Color;
                customColorToggleButton1.OnBackColor = colorDialog1.Color;
            }

            customColorToggleButton1.Checked = false;
        }

        private void secondaryCCustomColorPanel_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                secondaryCCustomColorPanel.BackColor = colorDialog1.Color;
                customColorToggleButton1.OnBackColor = colorDialog1.Color;
            }

            customColorToggleButton1.Checked = false;
        }


        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
