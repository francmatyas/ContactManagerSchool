namespace ContactManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
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
            this.label12 = new System.Windows.Forms.Label();
            this.secondaryCCustomColorPanel = new System.Windows.Forms.Panel();
            this.secondaryHCustomColorPanel = new System.Windows.Forms.Panel();
            this.secondaryCOrangePanel = new System.Windows.Forms.Panel();
            this.secondaryHOrangePanel = new System.Windows.Forms.Panel();
            this.secondaryCGreenPanel = new System.Windows.Forms.Panel();
            this.secondaryHGreenPanel = new System.Windows.Forms.Panel();
            this.secondaryCBluePanel = new System.Windows.Forms.Panel();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.secondaryHBluePanel = new System.Windows.Forms.Panel();
            this.orangePanel = new System.Windows.Forms.Panel();
            this.customColorPanel = new System.Windows.Forms.Panel();
            this.orangeToggleButton1 = new ContactManager.Custom_Design.ToggleButton();
            this.customColorToggleButton1 = new ContactManager.Custom_Design.ToggleButton();
            this.bluePanel = new System.Windows.Forms.Panel();
            this.greenToggleButton1 = new ContactManager.Custom_Design.ToggleButton();
            this.blueToggleButton1 = new ContactManager.Custom_Design.ToggleButton();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.favSortToggleButton = new ContactManager.Custom_Design.ToggleButton();
            this.zaSortToggleButton = new ContactManager.Custom_Design.ToggleButton();
            this.azSortToggleButton = new ContactManager.Custom_Design.ToggleButton();
            this.noneSortToggleButton = new ContactManager.Custom_Design.ToggleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.JSONPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.toolTip.SetToolTip(this.loadFileButton, "Select path to contact data file");
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
            this.darkModeToggleButton.Location = new System.Drawing.Point(15, 219);
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
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dark mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 2);
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
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Blue";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Green";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Orange";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Custom";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.secondaryCCustomColorPanel);
            this.panel3.Controls.Add(this.secondaryHCustomColorPanel);
            this.panel3.Controls.Add(this.secondaryCOrangePanel);
            this.panel3.Controls.Add(this.secondaryHOrangePanel);
            this.panel3.Controls.Add(this.secondaryCGreenPanel);
            this.panel3.Controls.Add(this.secondaryHGreenPanel);
            this.panel3.Controls.Add(this.secondaryCBluePanel);
            this.panel3.Controls.Add(this.greenPanel);
            this.panel3.Controls.Add(this.secondaryHBluePanel);
            this.panel3.Controls.Add(this.label6);
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
            this.panel3.Location = new System.Drawing.Point(348, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(144, 121);
            this.panel3.TabIndex = 21;
            this.toolTip.SetToolTip(this.panel3, "Select content color");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Select custom color here.";
            this.toolTip.SetToolTip(this.label12, "Click on rectangle to change color");
            // 
            // secondaryCCustomColorPanel
            // 
            this.secondaryCCustomColorPanel.BackColor = System.Drawing.Color.Indigo;
            this.secondaryCCustomColorPanel.Location = new System.Drawing.Point(86, 87);
            this.secondaryCCustomColorPanel.Name = "secondaryCCustomColorPanel";
            this.secondaryCCustomColorPanel.Size = new System.Drawing.Size(6, 15);
            this.secondaryCCustomColorPanel.TabIndex = 26;
            this.toolTip.SetToolTip(this.secondaryCCustomColorPanel, "Secondary click color");
            this.secondaryCCustomColorPanel.Click += new System.EventHandler(this.secondaryCCustomColorPanel_Click);
            // 
            // secondaryHCustomColorPanel
            // 
            this.secondaryHCustomColorPanel.BackColor = System.Drawing.Color.MediumOrchid;
            this.secondaryHCustomColorPanel.Location = new System.Drawing.Point(78, 87);
            this.secondaryHCustomColorPanel.Name = "secondaryHCustomColorPanel";
            this.secondaryHCustomColorPanel.Size = new System.Drawing.Size(6, 15);
            this.secondaryHCustomColorPanel.TabIndex = 26;
            this.toolTip.SetToolTip(this.secondaryHCustomColorPanel, "Secondary hover color");
            this.secondaryHCustomColorPanel.Click += new System.EventHandler(this.secondaryHCustomColorPanel_Click);
            // 
            // secondaryCOrangePanel
            // 
            this.secondaryCOrangePanel.BackColor = System.Drawing.Color.Chocolate;
            this.secondaryCOrangePanel.Location = new System.Drawing.Point(86, 65);
            this.secondaryCOrangePanel.Name = "secondaryCOrangePanel";
            this.secondaryCOrangePanel.Size = new System.Drawing.Size(6, 15);
            this.secondaryCOrangePanel.TabIndex = 25;
            this.toolTip.SetToolTip(this.secondaryCOrangePanel, "Secondary click color");
            // 
            // secondaryHOrangePanel
            // 
            this.secondaryHOrangePanel.BackColor = System.Drawing.Color.Orange;
            this.secondaryHOrangePanel.Location = new System.Drawing.Point(78, 65);
            this.secondaryHOrangePanel.Name = "secondaryHOrangePanel";
            this.secondaryHOrangePanel.Size = new System.Drawing.Size(6, 15);
            this.secondaryHOrangePanel.TabIndex = 25;
            this.toolTip.SetToolTip(this.secondaryHOrangePanel, "Secondary hover color");
            // 
            // secondaryCGreenPanel
            // 
            this.secondaryCGreenPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.secondaryCGreenPanel.Location = new System.Drawing.Point(86, 44);
            this.secondaryCGreenPanel.Name = "secondaryCGreenPanel";
            this.secondaryCGreenPanel.Size = new System.Drawing.Size(6, 15);
            this.secondaryCGreenPanel.TabIndex = 25;
            this.toolTip.SetToolTip(this.secondaryCGreenPanel, "Secondary click color");
            // 
            // secondaryHGreenPanel
            // 
            this.secondaryHGreenPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.secondaryHGreenPanel.Location = new System.Drawing.Point(78, 44);
            this.secondaryHGreenPanel.Name = "secondaryHGreenPanel";
            this.secondaryHGreenPanel.Size = new System.Drawing.Size(6, 15);
            this.secondaryHGreenPanel.TabIndex = 24;
            this.toolTip.SetToolTip(this.secondaryHGreenPanel, "Secondary hover color");
            // 
            // secondaryCBluePanel
            // 
            this.secondaryCBluePanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.secondaryCBluePanel.Location = new System.Drawing.Point(86, 23);
            this.secondaryCBluePanel.Name = "secondaryCBluePanel";
            this.secondaryCBluePanel.Size = new System.Drawing.Size(6, 15);
            this.secondaryCBluePanel.TabIndex = 24;
            this.toolTip.SetToolTip(this.secondaryCBluePanel, "Secondary click color");
            // 
            // greenPanel
            // 
            this.greenPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.greenPanel.Location = new System.Drawing.Point(61, 44);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(15, 15);
            this.greenPanel.TabIndex = 23;
            this.toolTip.SetToolTip(this.greenPanel, "Primary content color");
            // 
            // secondaryHBluePanel
            // 
            this.secondaryHBluePanel.BackColor = System.Drawing.Color.DarkBlue;
            this.secondaryHBluePanel.Location = new System.Drawing.Point(78, 23);
            this.secondaryHBluePanel.Name = "secondaryHBluePanel";
            this.secondaryHBluePanel.Size = new System.Drawing.Size(6, 15);
            this.secondaryHBluePanel.TabIndex = 23;
            this.toolTip.SetToolTip(this.secondaryHBluePanel, "Secondary hover color");
            // 
            // orangePanel
            // 
            this.orangePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.orangePanel.Location = new System.Drawing.Point(61, 65);
            this.orangePanel.Name = "orangePanel";
            this.orangePanel.Size = new System.Drawing.Size(15, 15);
            this.orangePanel.TabIndex = 24;
            this.toolTip.SetToolTip(this.orangePanel, "Primary content color");
            // 
            // customColorPanel
            // 
            this.customColorPanel.BackColor = System.Drawing.Color.Purple;
            this.customColorPanel.Location = new System.Drawing.Point(61, 87);
            this.customColorPanel.Name = "customColorPanel";
            this.customColorPanel.Size = new System.Drawing.Size(15, 15);
            this.customColorPanel.TabIndex = 25;
            this.toolTip.SetToolTip(this.customColorPanel, "Primary content color");
            this.customColorPanel.Click += new System.EventHandler(this.customColorPanel_Click);
            // 
            // orangeToggleButton1
            // 
            this.orangeToggleButton1.AutoSize = true;
            this.orangeToggleButton1.Location = new System.Drawing.Point(100, 65);
            this.orangeToggleButton1.MinimumSize = new System.Drawing.Size(30, 15);
            this.orangeToggleButton1.Name = "orangeToggleButton1";
            this.orangeToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.orangeToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.orangeToggleButton1.OnBackColor = System.Drawing.Color.DarkOrange;
            this.orangeToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.orangeToggleButton1.Size = new System.Drawing.Size(30, 15);
            this.orangeToggleButton1.TabIndex = 19;
            this.toolTip.SetToolTip(this.orangeToggleButton1, "Orange content color");
            this.orangeToggleButton1.UseVisualStyleBackColor = true;
            this.orangeToggleButton1.CheckedChanged += new System.EventHandler(this.orangeToggleButton1_CheckedChanged);
            // 
            // customColorToggleButton1
            // 
            this.customColorToggleButton1.AutoSize = true;
            this.customColorToggleButton1.Location = new System.Drawing.Point(100, 87);
            this.customColorToggleButton1.MinimumSize = new System.Drawing.Size(30, 15);
            this.customColorToggleButton1.Name = "customColorToggleButton1";
            this.customColorToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.customColorToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.customColorToggleButton1.OnBackColor = System.Drawing.Color.Purple;
            this.customColorToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.customColorToggleButton1.Size = new System.Drawing.Size(30, 15);
            this.customColorToggleButton1.TabIndex = 20;
            this.toolTip.SetToolTip(this.customColorToggleButton1, "Custom content color");
            this.customColorToggleButton1.UseVisualStyleBackColor = true;
            this.customColorToggleButton1.CheckedChanged += new System.EventHandler(this.customColorToggleButton1_CheckedChanged);
            // 
            // bluePanel
            // 
            this.bluePanel.BackColor = System.Drawing.Color.Navy;
            this.bluePanel.Location = new System.Drawing.Point(61, 23);
            this.bluePanel.Name = "bluePanel";
            this.bluePanel.Size = new System.Drawing.Size(15, 15);
            this.bluePanel.TabIndex = 22;
            this.toolTip.SetToolTip(this.bluePanel, "Primary content color");
            // 
            // greenToggleButton1
            // 
            this.greenToggleButton1.AutoSize = true;
            this.greenToggleButton1.Location = new System.Drawing.Point(100, 44);
            this.greenToggleButton1.MinimumSize = new System.Drawing.Size(30, 15);
            this.greenToggleButton1.Name = "greenToggleButton1";
            this.greenToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.greenToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.greenToggleButton1.OnBackColor = System.Drawing.Color.SeaGreen;
            this.greenToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.greenToggleButton1.Size = new System.Drawing.Size(30, 15);
            this.greenToggleButton1.TabIndex = 18;
            this.toolTip.SetToolTip(this.greenToggleButton1, "Green content color");
            this.greenToggleButton1.UseVisualStyleBackColor = true;
            this.greenToggleButton1.CheckedChanged += new System.EventHandler(this.greenToggleButton1_CheckedChanged);
            // 
            // blueToggleButton1
            // 
            this.blueToggleButton1.AutoSize = true;
            this.blueToggleButton1.Location = new System.Drawing.Point(100, 23);
            this.blueToggleButton1.MinimumSize = new System.Drawing.Size(30, 15);
            this.blueToggleButton1.Name = "blueToggleButton1";
            this.blueToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.blueToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.blueToggleButton1.OnBackColor = System.Drawing.Color.Navy;
            this.blueToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.blueToggleButton1.Size = new System.Drawing.Size(30, 15);
            this.blueToggleButton1.TabIndex = 0;
            this.toolTip.SetToolTip(this.blueToggleButton1, "Blue content color");
            this.blueToggleButton1.UseVisualStyleBackColor = true;
            this.blueToggleButton1.CheckedChanged += new System.EventHandler(this.blueToggleButton1_CheckedChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Navy;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(14, 274);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(103, 37);
            this.confirmButton.TabIndex = 22;
            this.confirmButton.Text = "Confirm";
            this.toolTip.SetToolTip(this.confirmButton, "Confirm and save settings");
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Preferred sort";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.favSortToggleButton);
            this.panel6.Controls.Add(this.zaSortToggleButton);
            this.panel6.Controls.Add(this.azSortToggleButton);
            this.panel6.Controls.Add(this.noneSortToggleButton);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(247, 202);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(96, 121);
            this.panel6.TabIndex = 24;
            this.toolTip.SetToolTip(this.panel6, "Select preferred sorting");
            // 
            // favSortToggleButton
            // 
            this.favSortToggleButton.AutoSize = true;
            this.favSortToggleButton.Location = new System.Drawing.Point(51, 88);
            this.favSortToggleButton.MinimumSize = new System.Drawing.Size(30, 15);
            this.favSortToggleButton.Name = "favSortToggleButton";
            this.favSortToggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.favSortToggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.favSortToggleButton.OnBackColor = System.Drawing.Color.LawnGreen;
            this.favSortToggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.favSortToggleButton.Size = new System.Drawing.Size(30, 15);
            this.favSortToggleButton.TabIndex = 31;
            this.toolTip.SetToolTip(this.favSortToggleButton, "Sort contacts favorite first");
            this.favSortToggleButton.UseVisualStyleBackColor = true;
            this.favSortToggleButton.CheckedChanged += new System.EventHandler(this.favSortToggleButton_CheckedChanged);
            // 
            // zaSortToggleButton
            // 
            this.zaSortToggleButton.AutoSize = true;
            this.zaSortToggleButton.Location = new System.Drawing.Point(51, 66);
            this.zaSortToggleButton.MinimumSize = new System.Drawing.Size(30, 15);
            this.zaSortToggleButton.Name = "zaSortToggleButton";
            this.zaSortToggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.zaSortToggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.zaSortToggleButton.OnBackColor = System.Drawing.Color.LawnGreen;
            this.zaSortToggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.zaSortToggleButton.Size = new System.Drawing.Size(30, 15);
            this.zaSortToggleButton.TabIndex = 30;
            this.toolTip.SetToolTip(this.zaSortToggleButton, "Sort contacts from Z to A");
            this.zaSortToggleButton.UseVisualStyleBackColor = true;
            this.zaSortToggleButton.CheckedChanged += new System.EventHandler(this.zaSortToggleButton_CheckedChanged);
            // 
            // azSortToggleButton
            // 
            this.azSortToggleButton.AutoSize = true;
            this.azSortToggleButton.Location = new System.Drawing.Point(51, 43);
            this.azSortToggleButton.MinimumSize = new System.Drawing.Size(30, 15);
            this.azSortToggleButton.Name = "azSortToggleButton";
            this.azSortToggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.azSortToggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.azSortToggleButton.OnBackColor = System.Drawing.Color.LawnGreen;
            this.azSortToggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.azSortToggleButton.Size = new System.Drawing.Size(30, 15);
            this.azSortToggleButton.TabIndex = 29;
            this.toolTip.SetToolTip(this.azSortToggleButton, "Sort contacts from A to Z");
            this.azSortToggleButton.UseVisualStyleBackColor = true;
            this.azSortToggleButton.CheckedChanged += new System.EventHandler(this.azSortToggleButton_CheckedChanged);
            // 
            // noneSortToggleButton
            // 
            this.noneSortToggleButton.AutoSize = true;
            this.noneSortToggleButton.Location = new System.Drawing.Point(51, 22);
            this.noneSortToggleButton.MinimumSize = new System.Drawing.Size(30, 15);
            this.noneSortToggleButton.Name = "noneSortToggleButton";
            this.noneSortToggleButton.OffBackColor = System.Drawing.Color.Gray;
            this.noneSortToggleButton.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.noneSortToggleButton.OnBackColor = System.Drawing.Color.LawnGreen;
            this.noneSortToggleButton.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.noneSortToggleButton.Size = new System.Drawing.Size(30, 15);
            this.noneSortToggleButton.TabIndex = 28;
            this.toolTip.SetToolTip(this.noneSortToggleButton, "Default sorting");
            this.noneSortToggleButton.UseVisualStyleBackColor = true;
            this.noneSortToggleButton.CheckedChanged += new System.EventHandler(this.noneSortToggleButton_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 15);
            this.label17.TabIndex = 27;
            this.label17.Text = "★";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "Z-A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "A-Z";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "None";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGray;
            this.panel7.Location = new System.Drawing.Point(344, 212);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 100);
            this.panel7.TabIndex = 25;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 324);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.panel3);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.JSONPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Panel secondaryHBluePanel;
        private System.Windows.Forms.Panel secondaryCGreenPanel;
        private System.Windows.Forms.Panel secondaryHGreenPanel;
        private System.Windows.Forms.Panel secondaryCBluePanel;
        private System.Windows.Forms.Panel secondaryCCustomColorPanel;
        private System.Windows.Forms.Panel secondaryHCustomColorPanel;
        private System.Windows.Forms.Panel secondaryCOrangePanel;
        private System.Windows.Forms.Panel secondaryHOrangePanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private Custom_Design.ToggleButton favSortToggleButton;
        private Custom_Design.ToggleButton zaSortToggleButton;
        private Custom_Design.ToggleButton azSortToggleButton;
        private Custom_Design.ToggleButton noneSortToggleButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolTip toolTip;
    }
}