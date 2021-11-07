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
                var jsonString = File.ReadAllText("jsonFile.json");
                MessageBox.Show(jsonString);

                List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(jsonString);

                MessageBox.Show(accounts[0].Username);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }



            /*
            if (passwordCreate.Text == passwordCreate.Text)
            {
                
                Accounts account = new Accounts();
                {
                    account.Username = usernameCreate.Text;
                    account.Password = passwordCreate.Text;
                }

                string jsonString = JsonSerializer.Serialize(account);
                MessageBox.Show(jsonString);
                File.WriteAllText(fileName, jsonString);

                this.Hide();
            
            }
            else
            {
                //TODO errror - heslo není stejné
                MessageBox.Show("error");
            }
            */
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
