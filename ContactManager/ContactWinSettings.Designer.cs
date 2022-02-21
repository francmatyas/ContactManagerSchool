namespace ContactManager
{
    partial class ContactWinSettings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactWinSettings));
            this.deletedContactGrid = new System.Windows.Forms.DataGridView();
            this.selectedContactLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.secondNameBox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.deletedContactGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // deletedContactGrid
            // 
            this.deletedContactGrid.AllowUserToAddRows = false;
            this.deletedContactGrid.AllowUserToDeleteRows = false;
            this.deletedContactGrid.AllowUserToResizeColumns = false;
            this.deletedContactGrid.AllowUserToResizeRows = false;
            this.deletedContactGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deletedContactGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deletedContactGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deletedContactGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.deletedContactGrid.GridColor = System.Drawing.Color.LightGray;
            this.deletedContactGrid.Location = new System.Drawing.Point(12, 22);
            this.deletedContactGrid.MultiSelect = false;
            this.deletedContactGrid.Name = "deletedContactGrid";
            this.deletedContactGrid.ReadOnly = true;
            this.deletedContactGrid.RowHeadersVisible = false;
            this.deletedContactGrid.RowTemplate.Height = 25;
            this.deletedContactGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deletedContactGrid.Size = new System.Drawing.Size(178, 180);
            this.deletedContactGrid.TabIndex = 0;
            this.deletedContactGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deletedContactGrid_CellClick);
            // 
            // selectedContactLabel
            // 
            this.selectedContactLabel.AutoSize = true;
            this.selectedContactLabel.BackColor = System.Drawing.Color.White;
            this.selectedContactLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedContactLabel.ForeColor = System.Drawing.Color.Navy;
            this.selectedContactLabel.Location = new System.Drawing.Point(7, 1);
            this.selectedContactLabel.Name = "selectedContactLabel";
            this.selectedContactLabel.Size = new System.Drawing.Size(108, 17);
            this.selectedContactLabel.TabIndex = 1;
            this.selectedContactLabel.Text = "Selected contact";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Navy;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(467, 103);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 28);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove";
            this.toolTip1.SetToolTip(this.removeButton, "Permanently remove");
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.BackColor = System.Drawing.Color.Navy;
            this.restoreButton.FlatAppearance.BorderSize = 0;
            this.restoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restoreButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.restoreButton.ForeColor = System.Drawing.Color.White;
            this.restoreButton.Location = new System.Drawing.Point(386, 103);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 28);
            this.restoreButton.TabIndex = 3;
            this.restoreButton.Text = "Restore";
            this.toolTip1.SetToolTip(this.restoreButton, "Restore contact");
            this.restoreButton.UseVisualStyleBackColor = false;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Navy;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(439, 168);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(103, 37);
            this.confirmButton.TabIndex = 23;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.BackColor = System.Drawing.Color.White;
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.firstNameBox.Location = new System.Drawing.Point(141, 21);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.ReadOnly = true;
            this.firstNameBox.Size = new System.Drawing.Size(200, 18);
            this.firstNameBox.TabIndex = 29;
            // 
            // secondNameBox
            // 
            this.secondNameBox.BackColor = System.Drawing.Color.White;
            this.secondNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondNameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondNameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.secondNameBox.Location = new System.Drawing.Point(141, 47);
            this.secondNameBox.Name = "secondNameBox";
            this.secondNameBox.ReadOnly = true;
            this.secondNameBox.Size = new System.Drawing.Size(200, 18);
            this.secondNameBox.TabIndex = 30;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ContactManager.Properties.Resources.name;
            this.pictureBox4.Location = new System.Drawing.Point(8, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Second name:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(53, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 2);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(53, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 2);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(133, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 40);
            this.panel3.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.secondNameBox);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.selectedContactLabel);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.firstNameBox);
            this.panel4.Location = new System.Drawing.Point(196, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 75);
            this.panel4.TabIndex = 35;
            // 
            // ContactWinSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 214);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.deletedContactGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContactWinSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.ContactWinSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletedContactGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deletedContactGrid;
        private System.Windows.Forms.Label selectedContactLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox secondNameBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}