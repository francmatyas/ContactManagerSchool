
namespace ContactManager
{
    partial class LoginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.loginLogin = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.cancelLogin = new System.Windows.Forms.Button();
            this.createAccount = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.showPassToggleButton = new ContactManager.Custom_Design.ToggleButton();
            this.incorrectPassOrUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLogin
            // 
            this.loginLogin.BackColor = System.Drawing.Color.Navy;
            this.loginLogin.FlatAppearance.BorderSize = 0;
            this.loginLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.loginLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.loginLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginLogin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLogin.ForeColor = System.Drawing.Color.White;
            this.loginLogin.Location = new System.Drawing.Point(30, 323);
            this.loginLogin.Name = "loginLogin";
            this.loginLogin.Size = new System.Drawing.Size(206, 32);
            this.loginLogin.TabIndex = 0;
            this.loginLogin.Text = "LOG IN";
            this.loginLogin.UseVisualStyleBackColor = false;
            this.loginLogin.Click += new System.EventHandler(this.loginLogin_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameTextBox.Location = new System.Drawing.Point(55, 188);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(181, 18);
            this.usernameTextBox.TabIndex = 1;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.Click += new System.EventHandler(this.usernameTextBox_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.Location = new System.Drawing.Point(55, 235);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(158, 18);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // cancelLogin
            // 
            this.cancelLogin.BackColor = System.Drawing.Color.Transparent;
            this.cancelLogin.FlatAppearance.BorderSize = 0;
            this.cancelLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.cancelLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelLogin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelLogin.ForeColor = System.Drawing.Color.Navy;
            this.cancelLogin.Location = new System.Drawing.Point(30, 361);
            this.cancelLogin.Name = "cancelLogin";
            this.cancelLogin.Size = new System.Drawing.Size(206, 32);
            this.cancelLogin.TabIndex = 3;
            this.cancelLogin.Text = "Exit";
            this.cancelLogin.UseVisualStyleBackColor = false;
            this.cancelLogin.Click += new System.EventHandler(this.cancelLogin_Click);
            // 
            // createAccount
            // 
            this.createAccount.FlatAppearance.BorderSize = 0;
            this.createAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.createAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createAccount.ForeColor = System.Drawing.Color.Navy;
            this.createAccount.Location = new System.Drawing.Point(12, 418);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(109, 23);
            this.createAccount.TabIndex = 4;
            this.createAccount.Text = "New account";
            this.createAccount.UseVisualStyleBackColor = true;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.settingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.ForeColor = System.Drawing.Color.Navy;
            this.settingsButton.Location = new System.Drawing.Point(165, 418);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(99, 23);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // iconBox
            // 
            this.iconBox.Image = global::ContactManager.Properties.Resources.contacts;
            this.iconBox.Location = new System.Drawing.Point(94, 38);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(71, 70);
            this.iconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBox.TabIndex = 7;
            this.iconBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(68, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactManager.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(30, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContactManager.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(30, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(30, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 2);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(30, 256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 2);
            this.panel2.TabIndex = 12;
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.BackColor = System.Drawing.Color.Transparent;
            this.clearFieldsButton.FlatAppearance.BorderSize = 0;
            this.clearFieldsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clearFieldsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clearFieldsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFieldsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearFieldsButton.ForeColor = System.Drawing.Color.Navy;
            this.clearFieldsButton.Location = new System.Drawing.Point(14, 264);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(77, 23);
            this.clearFieldsButton.TabIndex = 13;
            this.clearFieldsButton.Text = "Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = false;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ContactManager.Properties.Resources.add_contact;
            this.pictureBox3.Location = new System.Drawing.Point(4, 420);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ContactManager.Properties.Resources.setting;
            this.pictureBox4.Location = new System.Drawing.Point(242, 420);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // showPassToggleButton
            // 
            this.showPassToggleButton.Location = new System.Drawing.Point(211, 238);
            this.showPassToggleButton.MinimumSize = new System.Drawing.Size(25, 15);
            this.showPassToggleButton.Name = "showPassToggleButton";
            this.showPassToggleButton.OffBackColor = System.Drawing.Color.Navy;
            this.showPassToggleButton.OffToggleColor = System.Drawing.Color.DarkGray;
            this.showPassToggleButton.OnBackColor = System.Drawing.Color.Navy;
            this.showPassToggleButton.OnToggleColor = System.Drawing.Color.DarkBlue;
            this.showPassToggleButton.Size = new System.Drawing.Size(25, 15);
            this.showPassToggleButton.SolidStyle = false;
            this.showPassToggleButton.TabIndex = 18;
            this.showPassToggleButton.UseVisualStyleBackColor = true;
            this.showPassToggleButton.CheckedChanged += new System.EventHandler(this.showPassToggleButton_CheckedChanged);
            // 
            // incorrectPassOrUser
            // 
            this.incorrectPassOrUser.AutoSize = true;
            this.incorrectPassOrUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.incorrectPassOrUser.ForeColor = System.Drawing.Color.Red;
            this.incorrectPassOrUser.Location = new System.Drawing.Point(30, 295);
            this.incorrectPassOrUser.Name = "incorrectPassOrUser";
            this.incorrectPassOrUser.Size = new System.Drawing.Size(208, 13);
            this.incorrectPassOrUser.TabIndex = 19;
            this.incorrectPassOrUser.Text = "The username or password is incorrect.";
            this.incorrectPassOrUser.Visible = false;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 444);
            this.Controls.Add(this.incorrectPassOrUser);
            this.Controls.Add(this.showPassToggleButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLogin);
            this.Controls.Add(this.cancelLogin);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.createAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginWindow_FormClosed);
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginLogin;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button cancelLogin;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Custom_Design.ToggleButton showPassToggleButton;
        private System.Windows.Forms.Label incorrectPassOrUser;
    }
}

