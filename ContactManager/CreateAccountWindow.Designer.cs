
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showPasswordCreateAcc = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agPasswordCreate = new System.Windows.Forms.TextBox();
            this.passwordCreate = new System.Windows.Forms.TextBox();
            this.usernameCreate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitCreate
            // 
            this.submitCreate.Location = new System.Drawing.Point(151, 134);
            this.submitCreate.Name = "submitCreate";
            this.submitCreate.Size = new System.Drawing.Size(140, 23);
            this.submitCreate.TabIndex = 0;
            this.submitCreate.Text = "Submit";
            this.submitCreate.UseVisualStyleBackColor = true;
            this.submitCreate.Click += new System.EventHandler(this.submitCreate_Click);
            // 
            // cancelCreate
            // 
            this.cancelCreate.Location = new System.Drawing.Point(6, 134);
            this.cancelCreate.Name = "cancelCreate";
            this.cancelCreate.Size = new System.Drawing.Size(140, 23);
            this.cancelCreate.TabIndex = 1;
            this.cancelCreate.Text = "Cancel";
            this.cancelCreate.UseVisualStyleBackColor = true;
            this.cancelCreate.Click += new System.EventHandler(this.cancelCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showPasswordCreateAcc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.agPasswordCreate);
            this.groupBox1.Controls.Add(this.passwordCreate);
            this.groupBox1.Controls.Add(this.usernameCreate);
            this.groupBox1.Controls.Add(this.submitCreate);
            this.groupBox1.Controls.Add(this.cancelCreate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create account";
            // 
            // showPasswordCreateAcc
            // 
            this.showPasswordCreateAcc.AutoSize = true;
            this.showPasswordCreateAcc.Location = new System.Drawing.Point(151, 109);
            this.showPasswordCreateAcc.Name = "showPasswordCreateAcc";
            this.showPasswordCreateAcc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showPasswordCreateAcc.Size = new System.Drawing.Size(111, 19);
            this.showPasswordCreateAcc.TabIndex = 8;
            this.showPasswordCreateAcc.Text = " Show password";
            this.showPasswordCreateAcc.UseVisualStyleBackColor = true;
            this.showPasswordCreateAcc.CheckedChanged += new System.EventHandler(this.showPasswordCreateAcc_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Again password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // agPasswordCreate
            // 
            this.agPasswordCreate.Location = new System.Drawing.Point(121, 80);
            this.agPasswordCreate.Name = "agPasswordCreate";
            this.agPasswordCreate.PasswordChar = '*';
            this.agPasswordCreate.Size = new System.Drawing.Size(170, 23);
            this.agPasswordCreate.TabIndex = 4;
            // 
            // passwordCreate
            // 
            this.passwordCreate.Location = new System.Drawing.Point(121, 51);
            this.passwordCreate.Name = "passwordCreate";
            this.passwordCreate.PasswordChar = '*';
            this.passwordCreate.Size = new System.Drawing.Size(170, 23);
            this.passwordCreate.TabIndex = 3;
            // 
            // usernameCreate
            // 
            this.usernameCreate.Location = new System.Drawing.Point(121, 22);
            this.usernameCreate.Name = "usernameCreate";
            this.usernameCreate.Size = new System.Drawing.Size(170, 23);
            this.usernameCreate.TabIndex = 2;
            // 
            // CreateAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 187);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateAccountWindow";
            this.Text = "Contact Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button submitCreate;
        private System.Windows.Forms.Button cancelCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox showPasswordCreateAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox agPasswordCreate;
        private System.Windows.Forms.TextBox passwordCreate;
        private System.Windows.Forms.TextBox usernameCreate;
    }
}