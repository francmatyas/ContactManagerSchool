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

        private List<Person> people = new List<Person>();
        private List<Contact> contacts = new List<Contact>();

        public ContactWindow()
        {
            InitializeComponent();
        }

        private void ContactWindow_Load(object sender, EventArgs e)
        {
            contactsGrid.MultiSelect = false;

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
                            contacts.Add(contact);
                            
                            Person person = new Person();
                            person.Id = i;
                            person.Name = contact.FirstName + " " + contact.SecondName;
                            person.Contact = contact;

                            people.Add(person);

                            i++;
                        }

                        var source = new BindingSource();
                        source.DataSource = people;

                        contactsGrid.DataSource = source;
                        contactsGrid.Columns["Id"].Visible = false;
                        contactsGrid.Columns["Contact"].Visible = false;

                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
        }

        private void contactsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Text = contactsGrid.SelectedCells[0].Value.ToString();

            int contactIndex = Int32.Parse(contactsGrid.Rows[contactsGrid.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            
            foreach (var person in people)
            {
                if (person.Id == contactIndex)
                {
                    firstNameBox.Text = person.Contact.FirstName;
                    secondNameBox.Text = person.Contact.SecondName;
                    birthdayBox.Text = person.Contact.Birthday;
                    emailBox.Text = person.Contact.Email;
                    phoneNumberBox.Text = person.Contact.PhoneNumber.ToString();
                }
            }
            
        }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contact Contact { get; set; }
    }
}
