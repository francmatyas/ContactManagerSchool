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
        public static Color ContentColor = Color.Navy;
        public Color BackColorMode = Color.White;

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
                        ContentColor = Account.ContentColor;
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

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                ContentColor = settings.ReturnContentColor;
                LoginContentColor(ContentColor);
            }
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            passwordTextBox.AutoSize = false;
            passwordTextBox.Height = 25;
            usernameTextBox.AutoSize = false;
            usernameTextBox.Height = 25;
        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            usernameTextBox.SelectAll();
            usernameTextBox.ForeColor = Color.Black;
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.SelectAll();
            passwordTextBox.ForeColor = Color.Black;
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "Username";
            usernameTextBox.ForeColor = Color.DarkGray;
            passwordTextBox.Text = "Password";
            passwordTextBox.ForeColor = Color.DarkGray;
        }

        private void showPassToggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassToggleButton.CheckState == CheckState.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        public void LoginContentColor(Color contentColor)
        {
            label1.ForeColor = contentColor;
            panel1.BackColor = contentColor;
            panel2.BackColor = contentColor;
            clearFieldsButton.ForeColor = contentColor;
            loginLogin.BackColor = contentColor;
            cancelLogin.ForeColor = contentColor;
            settingsButton.ForeColor = contentColor;
            createAccount.ForeColor = contentColor;
            showPassToggleButton.OffBackColor = contentColor;
            showPassToggleButton.OnBackColor = contentColor;
            loginLogin.FlatAppearance.MouseDownBackColor = contentColor;
            loginLogin.FlatAppearance.MouseOverBackColor = contentColor;
        }
    }
}
