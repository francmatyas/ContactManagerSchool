using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ContactManager
{

    public partial class LoginWindow : Form
    {
        public static Account Account;
        public static string ContactsFile = "contactData.json";
        public static string SettingsFile = "localSettings.json";

        public static Color PrimaryContentColor = Color.Navy;
        public static Color SecondaryHContentColor = Color.DarkBlue;
        public static Color SecondaryCContentColor = Color.MidnightBlue;

        public static string PreferredSort = "none";

        public Color BackColorMode = Color.White;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void cancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadSettings()
        {

            if (File.Exists(SettingsFile))
            {
                try
                {
                    var jsonString = File.ReadAllText(SettingsFile);
                    byte[] bytes = Encoding.Default.GetBytes(jsonString);
                    jsonString = Encoding.UTF8.GetString(bytes);

                    LocalSettings localSettings = JsonConvert.DeserializeObject<LocalSettings>(jsonString);

                    try
                    {
                        PrimaryContentColor = localSettings.PrimaryContentColor;
                        SecondaryHContentColor = localSettings.SecondaryHContentColor;
                        SecondaryCContentColor = localSettings.SecondaryCContentColor;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    /*
                    if (localSettings.PrimaryContentColor != null)
                    {
                        PrimaryContentColor = localSettings.PrimaryContentColor;
                    }
                    if (localSettings.SecondaryHContentColor != null)
                    {
                        SecondaryHContentColor = localSettings.SecondaryHContentColor;
                    }
                    if (localSettings.SecondaryCContentColor != null)
                    {
                        SecondaryCContentColor = localSettings.SecondaryCContentColor;
                    }
                    */
                    if (localSettings.DataFile != null)
                    {
                        ContactsFile = localSettings.DataFile;
                    }
                    if (localSettings.PreferredSort != null)
                    {
                        PreferredSort = localSettings.PreferredSort;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                try
                {
                    using (FileStream fs = File.Create(SettingsFile))
                    {
                        LocalSettings Settings = new LocalSettings
                        {
                            PrimaryContentColor = PrimaryContentColor,
                            SecondaryHContentColor = SecondaryHContentColor,
                            SecondaryCContentColor = SecondaryCContentColor,
                            PreferredSort = PreferredSort,
                            DataFile = ContactsFile
                        };

                        string jsonSettingsString = JsonConvert.SerializeObject(Settings, Formatting.Indented);
                        byte[] bytes = Encoding.Default.GetBytes(jsonSettingsString);
                        fs.Write(bytes);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        private void SettingsPush()
        {
            LocalSettings Settings = new LocalSettings
            {
                PrimaryContentColor = PrimaryContentColor,
                SecondaryHContentColor = SecondaryHContentColor,
                SecondaryCContentColor = SecondaryCContentColor,
                PreferredSort = PreferredSort,
                DataFile = ContactsFile
            };

            string jsonSettingsString = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(SettingsFile, jsonSettingsString);
        }

        private void Login()
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (File.Exists(ContactsFile))
            {
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
                            //PrimaryContentColor = Account.ContentColor;
                            incorrectPassOrUser.Visible = false;
                            ContactWindow contactWindow = new ContactWindow();
                            contactWindow.Show();
                            this.Hide();
                        }
                        else
                        {
                            incorrectPassOrUser.Visible = true;
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
            else
            {
                try
                {
                    using (FileStream fs = File.Create(ContactsFile))
                    {
                        List<Account> accounts = new List<Account>();

                        string jsonString = JsonConvert.SerializeObject(accounts, Formatting.Indented);
                        byte[] bytes = Encoding.Default.GetBytes(jsonString);
                        fs.Write(bytes);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        private void loginLogin_Click(object sender, EventArgs e)
        { 
            Login();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            CreateAccountWindow createAccountWindow = new CreateAccountWindow();
            createAccountWindow.Show();
            this.Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                PrimaryContentColor = settings.ReturnPrimaryContentColor;
                SecondaryCContentColor = settings.ReturnSecondaryCContentColor;
                SecondaryHContentColor = settings.ReturnSecondaryHContentColor;
                LoginContentColor(PrimaryContentColor, SecondaryHContentColor, SecondaryCContentColor);

                SettingsPush();
            }
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            passwordTextBox.AutoSize = false;
            passwordTextBox.Height = 25;
            usernameTextBox.AutoSize = false;
            usernameTextBox.Height = 25;

            LoadSettings();
            LoginContentColor(PrimaryContentColor, SecondaryHContentColor, SecondaryCContentColor);
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
            incorrectPassOrUser.Visible = false;
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

        public void LoginContentColor(Color primaryContentColor, Color secondaryHContentColor, Color secondaryCContentColor)
        {
            label1.ForeColor = primaryContentColor;
            panel1.BackColor = primaryContentColor;
            panel2.BackColor = primaryContentColor;
            clearFieldsButton.ForeColor = primaryContentColor;

            loginLogin.BackColor = primaryContentColor;
            loginLogin.FlatAppearance.MouseDownBackColor = secondaryCContentColor;
            loginLogin.FlatAppearance.MouseOverBackColor = secondaryHContentColor;

            cancelLogin.ForeColor = primaryContentColor;
            settingsButton.ForeColor = primaryContentColor;
            createAccount.ForeColor = primaryContentColor;
            showPassToggleButton.OffBackColor = primaryContentColor;
            showPassToggleButton.OnBackColor = primaryContentColor;
            showPassToggleButton.OnToggleColor = primaryContentColor;
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void usernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
