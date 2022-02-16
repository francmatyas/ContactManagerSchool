using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ContactManager
{
    public partial class CreateAccountWindow : Form
    {
        private List<Account> accounts;

        public CreateAccountWindow()
        {
            InitializeComponent();
        }


        private void cancelCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginWindow().Show();
        }

        private void submitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var jsonString = File.ReadAllText(LoginWindow.ContactsFile);
                
                accounts = JsonConvert.DeserializeObject<List<Account>>(jsonString);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }

            if (passwordCreate.Text == agPasswordCreate.Text)
            {
                accounts.Add(new Account
                {
                    Username = usernameCreate.Text,
                    Password = passwordCreate.Text,
                    Contacts = new List<Contact>()
                });

                string jsonNewString = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                File.WriteAllText(LoginWindow.ContactsFile, jsonNewString);
                this.Hide();
                new LoginWindow().Show();
            }

            else
            {
                passwordError.Hide();
                usernameError.Hide();
                passwordError.Show();
            }
            
        }

        private void showPasswordToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordToggle.CheckState == CheckState.Checked)
            {
                passwordCreate.PasswordChar = '\0';
                agPasswordCreate.PasswordChar = '\0';
            }
            else
            {
                passwordCreate.PasswordChar = '*';
                agPasswordCreate.PasswordChar = '*';
            }
        }

        private void usernameCreate_Click(object sender, EventArgs e)
        {
            usernameCreate.SelectAll();
            usernameCreate.ForeColor = Color.Black;
        }

        private void passwordCreate_Click(object sender, EventArgs e)
        {
            passwordCreate.SelectAll();
            passwordCreate.ForeColor = Color.Black;
        }

        private void agPasswordCreate_Click(object sender, EventArgs e)
        {
            agPasswordCreate.SelectAll();
            agPasswordCreate.ForeColor = Color.Black;
        }
    }
}
