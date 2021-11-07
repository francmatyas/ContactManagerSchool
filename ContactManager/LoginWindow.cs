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

    public partial class LoginWindow : Form
    {
        public static string Username;
        public static string Password;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void cancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginLogin_Click(object sender, EventArgs e)
        { 
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                var jsonString = File.ReadAllText("jsonFile.json");

                List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(jsonString);

                foreach (var account in accounts)
                {
                    if (account.Username == username && account.Password == password)
                    {
                        Username = username;
                        Password = password;

                        ContactWindow contactWindow = new ContactWindow();
                        contactWindow.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            CreateAccountWindow createAccountWindow = new CreateAccountWindow();
            createAccountWindow.Show();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.CheckState == CheckState.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
