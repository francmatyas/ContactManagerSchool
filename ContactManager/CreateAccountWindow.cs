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
            finally
            {
                List<string> usernames = DumpAllUsernames();

                if (usernames.Contains(usernameCreate.Text))
                {
                    passwordError.Hide();
                    usernameError.Hide();
                    invalidUsernameError.Hide();
                    passwordShortError.Hide();
                    usernameError.Show();
                }
                else if (!(usernameCreate.Text.Length > 0) || usernameCreate.Text == "Username")
                {
                    passwordError.Hide();
                    usernameError.Hide();
                    invalidUsernameError.Hide();
                    passwordShortError.Hide();
                    invalidUsernameError.Show();
                }
                else
                {
                    if (!(passwordCreate.Text.Length > 0))
                    {
                        passwordError.Hide();
                        usernameError.Hide();
                        invalidUsernameError.Hide();
                        passwordShortError.Hide();
                        passwordShortError.Show();
                    }
                    else
                    {
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
                            invalidUsernameError.Hide();
                            passwordShortError.Hide();
                            passwordError.Show();
                        }
                    }
                }
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

        private void CreateWinContentColor(Color primaryContentColor, Color secondaryHContentColor, Color secondaryCContentColor)
        {
            submitCreate.BackColor = primaryContentColor;
            submitCreate.FlatAppearance.MouseOverBackColor = secondaryHContentColor;
            submitCreate.FlatAppearance.MouseDownBackColor = secondaryCContentColor;

            cancelCreate.ForeColor = primaryContentColor;
            label3.ForeColor = primaryContentColor;
            label1.ForeColor = primaryContentColor;
            showPasswordToggle.OffBackColor = primaryContentColor;
            showPasswordToggle.OnBackColor = primaryContentColor;
            showPasswordToggle.OnToggleColor = secondaryCContentColor;

            panel1.BackColor = primaryContentColor;
            panel5.BackColor = primaryContentColor;
            panel10.BackColor = primaryContentColor;
            panel15.BackColor = primaryContentColor;
        }

        private void CreateAccountWindow_Load(object sender, EventArgs e)
        {
            CreateWinContentColor(LoginWindow.PrimaryContentColor, LoginWindow.SecondaryHContentColor, LoginWindow.SecondaryCContentColor);
        }

        private List<string> DumpAllUsernames()
        {
            List<string> usernames = new List<string>();
            foreach (var account in accounts)
            {
                usernames.Add(account.Username);
            }
            return usernames;
        }
    }
}
