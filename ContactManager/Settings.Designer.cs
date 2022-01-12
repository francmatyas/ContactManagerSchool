﻿namespace ContactManager
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileLabel = new System.Windows.Forms.Label();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.dataTypeToggleButton = new ContactManager.Custom_Design.ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JSONPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.darkModeToggleButton = new ContactManager.Custom_Design.ToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.orangePanel = new System.Windows.Forms.Panel();
            this.customColorPanel = new System.Windows.Forms.Panel();
            this.orangeToggleButton1 = new ContactManager.Custom_Design.ToggleButton();
            this.customColorToggleButton1 = new ContactManager.Custom_Design.ToggleButton();
            this.bluePanel = new System.Windows.Forms.Panel();
            this.greenToggleButton1 = new ContactManager.Custom_Design.ToggleButton();
            this.blueToggleButton1 = new ContactManager.Custom_Design.ToggleButton();
            this.JSONPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileLabel
            // 
            this.fileLabel.Location = new System.Drawing.Point(3, 48);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(477, 51);
            this.fileLabel.TabIndex = 0;
            this.fileLabel.Text = "File:";
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackColor = System.Drawing.Color.Navy;
            this.loadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFileButton.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadFileButton.ForeColor = System.Drawing.Color.White;
            this.loadFileButton.Location = new System.Drawing.Point(70, 3);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(346, 42);
            this.loadFileButton.TabIndex = 1;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = false;
            this.loadFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTypeToggleButton
            // 
            this.dataTypeToggleButton.Location = new System.Drawing.Point(55, 0);
            this.dataTypeToggleButton.MinimumSize = new System.Drawing.Size(30, 15);
            this.dataTypeToggleButton.Name = "dataTypeToggleButton";
            this.dataTypeToggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.dataTypeToggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.dataTypeToggleButton.OnBackColor = System.Drawing.Color.Gray;
            this.dataTypeToggleButton.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.dataTypeToggleButton.Size = new System.Drawing.Size(40, 20);
            this.dataTypeToggleButton.TabIndex = 2;
            this.dataTypeToggleButton.UseVisualStyleBackColor = true;
            this.dataTypeToggleButton.CheckedChanged += new System.EventHandler(this.dataTypeToggleButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "JSON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(101, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MySQL";
            // 
            // JSONPanel
            // 
            this.JSONPanel.Controls.Add(this.fileLabel);
            this.JSONPanel.Controls.Add(this.loadFileButton);
            this.JSONPanel.Location = new System.Drawing.Point(12, 64);
            this.JSONPanel.Name = "JSONPanel";
            this.JSONPanel.Size = new System.Drawing.Size(483, 107);
            this.JSONPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(31, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data sotrage settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(31, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Design settings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataTypeToggleButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 22);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 2);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(12, 193);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(483, 2);
            this.panel4.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(0, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(483, 2);
            this.panel5.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactManager.Properties.Resources.database;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContactManager.Properties.Resources.design;
            this.pictureBox2.Location = new System.Drawing.Point(12, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // darkModeToggleButton
            // 
            this.darkModeToggleButton.AutoSize = true;
            this.darkModeToggleButton.Location = new System.Drawing.Point(15, 227);
            this.darkModeToggleButton.MinimumSize = new System.Drawing.Size(40, 20);
            this.darkModeToggleButton.Name = "darkModeToggleButton";
            this.darkModeToggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.darkModeToggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.darkModeToggleButton.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.darkModeToggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.darkModeToggleButton.Size = new System.Drawing.Size(40, 20);
            this.darkModeToggleButton.TabIndex = 14;
            this.darkModeToggleButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dark mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(348, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Content color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Blue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Green";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Orange";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Custom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.greenPanel);
            this.panel3.Controls.Add(this.orangePanel);
            this.panel3.Controls.Add(this.customColorPanel);
            this.panel3.Controls.Add(this.orangeToggleButton1);
            this.panel3.Controls.Add(this.customColorToggleButton1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.bluePanel);
            this.panel3.Controls.Add(this.greenToggleButton1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.blueToggleButton1);
            this.panel3.Location = new System.Drawing.Point(348, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 93);
            this.panel3.TabIndex = 21;
            // 
            // greenPanel
            // 
            this.greenPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.greenPanel.Location = new System.Drawing.Point(61, 28);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(15, 15);
            this.greenPanel.TabIndex = 23;
            // 
            // orangePanel
            // 
            this.orangePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.orangePanel.Location = new System.Drawing.Point(61, 49);
            this.orangePanel.Name = "orangePanel";
            this.orangePanel.Size = new System.Drawing.Size(15, 15);
            this.orangePanel.TabIndex = 24;
            // 
            // customColorPanel
            // 
            this.customColorPanel.BackColor = System.Drawing.Color.HotPink;
            this.customColorPanel.Location = new System.Drawing.Point(61, 71);
            this.customColorPanel.Name = "customColorPanel";
            this.customColorPanel.Size = new System.Drawing.Size(15, 15);
            this.customColorPanel.TabIndex = 25;
            this.customColorPanel.Click += new System.EventHandler(this.customColorPanel_Click);
            // 
            // orangeToggleButton1
            // 
            this.orangeToggleButton1.AutoSize = true;
            this.orangeToggleButton1.Location = new System.Drawing.Point(100, 49);
            this.orangeToggleButton1.MinimumSize = new System.Drawing.Size(30, 15);
            this.orangeToggleButton1.Name = "orangeToggleButton1";
            this.orangeToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.orangeToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.orangeToggleButton1.OnBackColor = System.Drawing.Color.DarkOrange;
            this.orangeToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.orangeToggleButton1.Size = new System.Drawing.Size(30, 15);
            this.orangeToggleButton1.TabIndex = 19;
            this.orangeToggleButton1.UseVisualStyleBackColor = true;
            this.orangeToggleButton1.CheckedChanged += new System.EventHandler(this.orangeToggleButton1_CheckedChanged);
            // 
            // customColorToggleButton1
            // 
            this.customColorToggleButton1.AutoSize = true;
            this.customColorToggleButton1.Location = new System.Drawing.Point(100, 71);
            this.customColorToggleButton1.MinimumSize = new System.Drawing.Size(30, 15);
            this.customColorToggleButton1.Name = "customColorToggleButton1";
            this.customColorToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.customColorToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.customColorToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.customColorToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.customColorToggleButton1.Size = new System.Drawing.Size(30, 15);
            this.customColorToggleButton1.TabIndex = 20;
            this.customColorToggleButton1.UseVisualStyleBackColor = true;
            this.customColorToggleButton1.CheckedChanged += new System.EventHandler(this.customColorToggleButton1_CheckedChanged);
            // 
            // bluePanel
            // 
            this.bluePanel.BackColor = System.Drawing.Color.Navy;
            this.bluePanel.Location = new System.Drawing.Point(61, 7);
            this.bluePanel.Name = "bluePanel";
            this.bluePanel.Size = new System.Drawing.Size(15, 15);
            this.bluePanel.TabIndex = 22;
            // 
            // greenToggleButton1
            // 
            this.greenToggleButton1.AutoSize = true;
            this.greenToggleButton1.Location = new System.Drawing.Point(100, 28);
            this.greenToggleButton1.MinimumSize = new System.Drawing.Size(30, 15);
            this.greenToggleButton1.Name = "greenToggleButton1";
            this.greenToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.greenToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.greenToggleButton1.OnBackColor = System.Drawing.Color.SeaGreen;
            this.greenToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.greenToggleButton1.Size = new System.Drawing.Size(30, 15);
            this.greenToggleButton1.TabIndex = 18;
            this.greenToggleButton1.UseVisualStyleBackColor = true;
            this.greenToggleButton1.CheckedChanged += new System.EventHandler(this.greenToggleButton1_CheckedChanged);
            // 
            // blueToggleButton1
            // 
            this.blueToggleButton1.AutoSize = true;
            this.blueToggleButton1.Location = new System.Drawing.Point(100, 7);
            this.blueToggleButton1.MinimumSize = new System.Drawing.Size(30, 15);
            this.blueToggleButton1.Name = "blueToggleButton1";
            this.blueToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.blueToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.blueToggleButton1.OnBackColor = System.Drawing.Color.Navy;
            this.blueToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.blueToggleButton1.Size = new System.Drawing.Size(30, 15);
            this.blueToggleButton1.TabIndex = 0;
            this.blueToggleButton1.UseVisualStyleBackColor = true;
            this.blueToggleButton1.CheckedChanged += new System.EventHandler(this.blueToggleButton1_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 394);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.darkModeToggleButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JSONPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.JSONPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button loadFileButton;
        private Custom_Design.ToggleButton dataTypeToggleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel JSONPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Custom_Design.ToggleButton darkModeToggleButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.Panel orangePanel;
        private System.Windows.Forms.Panel customColorPanel;
        private Custom_Design.ToggleButton orangeToggleButton1;
        private Custom_Design.ToggleButton customColorToggleButton1;
        private System.Windows.Forms.Panel bluePanel;
        private Custom_Design.ToggleButton greenToggleButton1;
        private Custom_Design.ToggleButton blueToggleButton1;
    }
}