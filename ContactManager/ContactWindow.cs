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
    public partial class ContactWindow : Form
    {
        private string username = LoginWindow.Username;
        private string password = LoginWindow.Password;


        public ContactWindow()
        {
            InitializeComponent();
        }

        private void ContactWindow_Load(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>();

            try
            {
                var jsonString = File.ReadAllText("jsonFile.json");

                List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(jsonString);

                foreach (var account in accounts)
                {
                    if (account.Username == username && account.Password == password)
                    {
                        int i = 0;
                        foreach (var contact in account.Contacts)
                        {
                            people.Add(new Person()
                            {
                                Id = i, 
                                FirstName = contact.FirstName,
                                SecondName = contact.SecondName
                            });
                            i++;
                        }

                        contactsGrid.DataSource = people;

                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
        }
    }


    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
