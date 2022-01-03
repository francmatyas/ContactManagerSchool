
namespace ContactManager
{
    partial class ContactWindow
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
            this.contactsGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createCancelContact = new System.Windows.Forms.Button();
            this.createSubmitContact = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birthdayBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.secondNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.contactsLabel = new System.Windows.Forms.Label();
            this.zaSort = new System.Windows.Forms.Button();
            this.azSort = new System.Windows.Forms.Button();
            this.deleteContact = new System.Windows.Forms.Button();
            this.createContact = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactsGrid
            // 
            this.contactsGrid.AllowUserToAddRows = false;
            this.contactsGrid.AllowUserToDeleteRows = false;
            this.contactsGrid.AllowUserToResizeRows = false;
            this.contactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGrid.ColumnHeadersVisible = false;
            this.contactsGrid.Location = new System.Drawing.Point(12, 36);
            this.contactsGrid.Name = "contactsGrid";
            this.contactsGrid.ReadOnly = true;
            this.contactsGrid.RowHeadersVisible = false;
            this.contactsGrid.RowTemplate.Height = 25;
            this.contactsGrid.Size = new System.Drawing.Size(150, 368);
            this.contactsGrid.TabIndex = 0;
            this.contactsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createCancelContact);
            this.groupBox1.Controls.Add(this.createSubmitContact);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(168, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // createCancelContact
            // 
            this.createCancelContact.Location = new System.Drawing.Point(362, 397);
            this.createCancelContact.Name = "createCancelContact";
            this.createCancelContact.Size = new System.Drawing.Size(75, 23);
            this.createCancelContact.TabIndex = 13;
            this.createCancelContact.Text = "Cancel";
            this.createCancelContact.UseVisualStyleBackColor = true;
            this.createCancelContact.Visible = false;
            this.createCancelContact.Click += new System.EventHandler(this.createCancelContact_Click);
            // 
            // createSubmitContact
            // 
            this.createSubmitContact.Location = new System.Drawing.Point(443, 397);
            this.createSubmitContact.Name = "createSubmitContact";
            this.createSubmitContact.Size = new System.Drawing.Size(75, 23);
            this.createSubmitContact.TabIndex = 12;
            this.createSubmitContact.Text = "Submit";
            this.createSubmitContact.UseVisualStyleBackColor = true;
            this.createSubmitContact.Visible = false;
            this.createSubmitContact.Click += new System.EventHandler(this.createSubmitContact_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorButton);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.phoneNumberBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.emailBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.birthdayBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.secondNameBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.firstNameBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 250);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name:";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(115, 134);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(250, 25);
            this.phoneNumberBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second name:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(115, 105);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(250, 25);
            this.emailBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone number:";
            // 
            // birthdayBox
            // 
            this.birthdayBox.Location = new System.Drawing.Point(115, 76);
            this.birthdayBox.Name = "birthdayBox";
            this.birthdayBox.Size = new System.Drawing.Size(250, 25);
            this.birthdayBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // secondNameBox
            // 
            this.secondNameBox.Location = new System.Drawing.Point(115, 47);
            this.secondNameBox.Name = "secondNameBox";
            this.secondNameBox.Size = new System.Drawing.Size(250, 25);
            this.secondNameBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Birthday:";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(115, 18);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(250, 25);
            this.firstNameBox.TabIndex = 6;
            // 
            // contactsLabel
            // 
            this.contactsLabel.AutoSize = true;
            this.contactsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactsLabel.Location = new System.Drawing.Point(12, 14);
            this.contactsLabel.Name = "contactsLabel";
            this.contactsLabel.Size = new System.Drawing.Size(61, 17);
            this.contactsLabel.TabIndex = 2;
            this.contactsLabel.Text = "Contacts";
            // 
            // zaSort
            // 
            this.zaSort.Location = new System.Drawing.Point(132, 12);
            this.zaSort.Name = "zaSort";
            this.zaSort.Size = new System.Drawing.Size(30, 23);
            this.zaSort.TabIndex = 3;
            this.zaSort.Text = "ZA";
            this.zaSort.UseVisualStyleBackColor = true;
            this.zaSort.Click += new System.EventHandler(this.zaSort_Click);
            // 
            // azSort
            // 
            this.azSort.Location = new System.Drawing.Point(102, 12);
            this.azSort.Name = "azSort";
            this.azSort.Size = new System.Drawing.Size(30, 23);
            this.azSort.TabIndex = 4;
            this.azSort.Text = "AZ";
            this.azSort.UseVisualStyleBackColor = true;
            this.azSort.Click += new System.EventHandler(this.azSort_Click);
            // 
            // deleteContact
            // 
            this.deleteContact.Location = new System.Drawing.Point(87, 406);
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(75, 23);
            this.deleteContact.TabIndex = 5;
            this.deleteContact.Text = "Delete";
            this.deleteContact.UseVisualStyleBackColor = true;
            this.deleteContact.Click += new System.EventHandler(this.deleteContact_Click);
            // 
            // createContact
            // 
            this.createContact.Location = new System.Drawing.Point(12, 406);
            this.createContact.Name = "createContact";
            this.createContact.Size = new System.Drawing.Size(75, 23);
            this.createContact.TabIndex = 6;
            this.createContact.Text = "Create";
            this.createContact.UseVisualStyleBackColor = true;
            this.createContact.Click += new System.EventHandler(this.createContact_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(6, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Favourite";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // colorButton
            // 
            this.colorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.colorButton.Location = new System.Drawing.Point(278, 198);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 14;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContactWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.createContact);
            this.Controls.Add(this.deleteContact);
            this.Controls.Add(this.azSort);
            this.Controls.Add(this.zaSort);
            this.Controls.Add(this.contactsLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.contactsGrid);
            this.Name = "ContactWindow";
            this.Text = "Contact Manager";
            this.Load += new System.EventHandler(this.ContactWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contactsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label contactsLabel;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox birthdayBox;
        private System.Windows.Forms.TextBox secondNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button zaSort;
        private System.Windows.Forms.Button azSort;
        private System.Windows.Forms.Button deleteContact;
        private System.Windows.Forms.Button createContact;
        private System.Windows.Forms.Button createSubmitContact;
        private System.Windows.Forms.Button createCancelContact;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}