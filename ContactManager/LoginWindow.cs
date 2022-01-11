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
        public static Account Account;
        public static string ContactsFile = "C:/Users/franc/Source/Repos/GhastyCZ/ContactManagerSchool/ContactManager/jsonFile.json";

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
                var jsonString = File.ReadAllText(ContactsFile);
                byte[] bytes = Encoding.Default.GetBytes(jsonString);
                jsonString = Encoding.UTF8.GetString(bytes);

                List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(jsonString);

                foreach (var account in accounts)
                {
                    if (account.Username == username && account.Password == password)
                    {
                        Account = account;
                        ContactWindow contactWindow = new ContactWindow();
                        contactWindow.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);

                if (MessageBox.Show(text: "Error: Database file not found. \n Select file in Settings.") ==
                    DialogResult.OK)
                {
                    Settings settings = new Settings();
                    settings.ShowDialog();
                }
                
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

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
