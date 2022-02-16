
namespace ContactManager
{
    partial class CreateAccountWindow
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
            this.submitCreate = new System.Windows.Forms.Button();
            this.cancelCreate = new System.Windows.Forms.Button();
            this.agPasswordCreate = new System.Windows.Forms.TextBox();
            this.passwordCreate = new System.Windows.Forms.TextBox();
            this.usernameCreate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.showPasswordToggle = new ContactManager.Custom_Design.ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.passwordError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // submitCreate
            // 
            this.submitCreate.BackColor = System.Drawing.Color.Navy;
            this.submitCreate.FlatAppearance.BorderSize = 0;
            this.submitCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitCreate.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitCreate.ForeColor = System.Drawing.Color.White;
            this.submitCreate.Location = new System.Drawing.Point(27, 253);
            this.submitCreate.Name = "submitCreate";
            this.submitCreate.Size = new System.Drawing.Size(206, 32);
            this.submitCreate.TabIndex = 0;
            this.submitCreate.Text = "Submit";
            this.submitCreate.UseVisualStyleBackColor = false;
            this.submitCreate.Click += new System.EventHandler(this.submitCreate_Click);
            // 
            // cancelCreate
            // 
            this.cancelCreate.BackColor = System.Drawing.Color.White;
            this.cancelCreate.FlatAppearance.BorderSize = 0;
            this.cancelCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCreate.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelCreate.ForeColor = System.Drawing.Color.Navy;
            this.cancelCreate.Location = new System.Drawing.Point(27, 291);
            this.cancelCreate.Name = "cancelCreate";
            this.cancelCreate.Size = new System.Drawing.Size(206, 32);
            this.cancelCreate.TabIndex = 1;
            this.cancelCreate.Text = "Cancel";
            this.cancelCreate.UseVisualStyleBackColor = false;
            this.cancelCreate.Click += new System.EventHandler(this.cancelCreate_Click);
            // 
            // agPasswordCreate
            // 
            this.agPasswordCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.agPasswordCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.agPasswordCreate.ForeColor = System.Drawing.Color.DarkGray;
            this.agPasswordCreate.Location = new System.Drawing.Point(53, 159);
            this.agPasswordCreate.Name = "agPasswordCreate";
            this.agPasswordCreate.PasswordChar = '*';
            this.agPasswordCreate.Size = new System.Drawing.Size(180, 18);
            this.agPasswordCreate.TabIndex = 4;
            this.agPasswordCreate.Text = "Password";
            this.agPasswordCreate.Click += new System.EventHandler(this.agPasswordCreate_Click);
            // 
            // passwordCreate
            // 
            this.passwordCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordCreate.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordCreate.Location = new System.Drawing.Point(53, 119);
            this.passwordCreate.Name = "passwordCreate";
            this.passwordCreate.PasswordChar = '*';
            this.passwordCreate.Size = new System.Drawing.Size(180, 18);
            this.passwordCreate.TabIndex = 3;
            this.passwordCreate.Text = "Password";
            this.passwordCreate.Click += new System.EventHandler(this.passwordCreate_Click);
            // 
            // usernameCreate
            // 
            this.usernameCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameCreate.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameCreate.Location = new System.Drawing.Point(53, 79);
            this.usernameCreate.Name = "usernameCreate";
            this.usernameCreate.Size = new System.Drawing.Size(180, 18);
            this.usernameCreate.TabIndex = 2;
            this.usernameCreate.Text = "Username";
            this.usernameCreate.Click += new System.EventHandler(this.usernameCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContactManager.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(27, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContactManager.Properties.Resources.padlock;
            this.pictureBox2.Location = new System.Drawing.Point(27, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(27, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 2);
            this.panel1.TabIndex = 12;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Navy;
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Location = new System.Drawing.Point(0, -11);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(206, 2);
            this.panel11.TabIndex = 15;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Navy;
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(0, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(206, 2);
            this.panel12.TabIndex = 14;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Navy;
            this.panel13.Location = new System.Drawing.Point(0, 28);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(206, 2);
            this.panel13.TabIndex = 13;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Navy;
            this.panel14.Location = new System.Drawing.Point(0, 28);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(206, 2);
            this.panel14.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Location = new System.Drawing.Point(0, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 2);
            this.panel4.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 2);
            this.panel2.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(27, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 2);
            this.panel5.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Navy;
            this.panel9.Location = new System.Drawing.Point(0, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(206, 2);
            this.panel9.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Navy;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(0, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 2);
            this.panel7.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Navy;
            this.panel8.Location = new System.Drawing.Point(0, 14);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(206, 2);
            this.panel8.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Location = new System.Drawing.Point(0, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 2);
            this.panel6.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Navy;
            this.panel10.Location = new System.Drawing.Point(27, 182);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(206, 2);
            this.panel10.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ContactManager.Properties.Resources.reload_dark;
            this.pictureBox3.Location = new System.Drawing.Point(27, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // showPasswordToggle
            // 
            this.showPasswordToggle.AutoSize = true;
            this.showPasswordToggle.Location = new System.Drawing.Point(164, 188);
            this.showPasswordToggle.MinimumSize = new System.Drawing.Size(25, 15);
            this.showPasswordToggle.Name = "showPasswordToggle";
            this.showPasswordToggle.OffBackColor = System.Drawing.Color.Navy;
            this.showPasswordToggle.OffToggleColor = System.Drawing.Color.DarkGray;
            this.showPasswordToggle.OnBackColor = System.Drawing.Color.Navy;
            this.showPasswordToggle.OnToggleColor = System.Drawing.Color.DarkBlue;
            this.showPasswordToggle.Size = new System.Drawing.Size(25, 15);
            this.showPasswordToggle.SolidStyle = false;
            this.showPasswordToggle.TabIndex = 16;
            this.showPasswordToggle.UseVisualStyleBackColor = true;
            this.showPasswordToggle.CheckedChanged += new System.EventHandler(this.showPasswordToggle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(65, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Show password";
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.BackColor = System.Drawing.Color.Transparent;
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(53, 215);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(147, 15);
            this.usernameError.TabIndex = 18;
            this.usernameError.Text = "Username is already taken.";
            this.usernameError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(19, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "New account";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Navy;
            this.panel15.Location = new System.Drawing.Point(35, 53);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(190, 2);
            this.panel15.TabIndex = 20;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.BackColor = System.Drawing.Color.Transparent;
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(53, 215);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(146, 15);
            this.passwordError.TabIndex = 21;
            this.passwordError.Text = "Password does not match.";
            this.passwordError.Visible = false;
            // 
            // CreateAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 336);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPasswordToggle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelCreate);
            this.Controls.Add(this.submitCreate);
            this.Controls.Add(this.usernameCreate);
            this.Controls.Add(this.agPasswordCreate);
            this.Controls.Add(this.passwordCreate);
            this.MaximizeBox = false;
            this.Name = "CreateAccountWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitCreate;
        private System.Windows.Forms.Button cancelCreate;
        private System.Windows.Forms.TextBox agPasswordCreate;
        private System.Windows.Forms.TextBox passwordCreate;
        private System.Windows.Forms.TextBox usernameCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Custom_Design.ToggleButton showPasswordToggle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label passwordError;
    }
}