using System;
using System.Collections.Generic;
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
        }

        private void submitCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var jsonString = File.ReadAllText("C:/Users/franc/source/repos/ContactManager/ContactManager/jsonFile.json");
                
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
                    Password = passwordCreate.Text
                });

                string jsonNewString = JsonConvert.SerializeObject(accounts);
                File.WriteAllText(@"C:/Users/franc/source/repos/ContactManager/ContactManager/jsonFile.json", jsonNewString);
                this.Hide();
            }

            else
            {
                //TODO errror - heslo není stejné
                MessageBox.Show("error");
            }
            
        }

        private void showPasswordCreateAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCreateAcc.CheckState == CheckState.Checked)
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
    }
}
