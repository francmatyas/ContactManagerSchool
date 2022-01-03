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
        private Account loggedAccount = LoginWindow.Account;

        private List<Person> People = new List<Person>();
        private List<Account> Accounts = new List<Account>();

        public ContactWindow()
        {
            InitializeComponent();
        }


        private void ContactLoad()
        {
            try
            {
                People.Clear();

                int i = 0;
                foreach (var contact in loggedAccount.Contacts)
                {
                    Person person = new Person();
                    person.Id = i;
                    person.Name = contact.FirstName + " " + contact.SecondName;
                    person.Contact = contact;

                    People.Add(person);

                    i++;
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
            }
        }
        
        
        private void GridContactLoad()
        {
            ContactLoad();
            var source = new BindingSource();
            source.DataSource = People;

            contactsGrid.DataSource = source;
            contactsGrid.Columns["Id"].Visible = false;
            contactsGrid.Columns["Contact"].Visible = false;
        }

        private void ContactSave()
        {
            var jsonString = File.ReadAllText(LoginWindow.ContactsFile);
            Accounts.Clear();
            Accounts = JsonConvert.DeserializeObject<List<Account>>(jsonString);


            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Password == loggedAccount.Password && Accounts[i].Username == loggedAccount.Username)
                {
                    Accounts[i] = loggedAccount;
                }
            }


            string jsonNewString = JsonConvert.SerializeObject(Accounts, Formatting.Indented);
            File.WriteAllText(LoginWindow.ContactsFile, jsonNewString);
        }

        private void ContactWindow_Load(object sender, EventArgs e)
        {
            contactsGrid.MultiSelect = false;
            ContactLoad();
            contactsGrid.Rows.Clear();
            GridContactLoad();
        }

        private void contactsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Text = contactsGrid.SelectedCells[0].Value.ToString();

            int contactIndex = Int32.Parse(contactsGrid.Rows[contactsGrid.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            
            foreach (var person in People)
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

        private void azSort_Click(object sender, EventArgs e)
        {
            string[][] contactList = new string[contactsGrid.RowCount][];
            for (int i = 0; i < contactsGrid.RowCount; i++)
            {
                contactList[i][0] = contactsGrid.Rows[i].Cells[0].Value.ToString();
                contactList[i][1] = contactsGrid.Rows[i].Cells[1].Value.ToString();
                //TODO
            }

            MessageBox.Show(contactList[2][1]);

        }

        private void zaSort_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void createContact_Click(object sender, EventArgs e)
        {
            firstNameBox.Text = "";
            secondNameBox.Text = "";
            birthdayBox.Text = "";
            emailBox.Text = "";
            phoneNumberBox.Text = "";

            createCancelContact.Show();
            createSubmitContact.Show();
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].Id == Int32.Parse(contactsGrid.Rows[contactsGrid.SelectedCells[0].RowIndex].Cells[0].Value
                    .ToString()))
                {
                    loggedAccount.Contacts.Remove(People[i].Contact);
                    People.Remove(People[i]);
                    ContactSave();
                    contactsGrid.Rows.Clear();
                    GridContactLoad();

                }
            }
        }

        private void createCancelContact_Click(object sender, EventArgs e)
        {
            firstNameBox.Text = "";
            secondNameBox.Text = "";
            birthdayBox.Text = "";
            emailBox.Text = "";
            phoneNumberBox.Text = "";

            createCancelContact.Hide();
            createSubmitContact.Hide();
        }

        private void createSubmitContact_Click(object sender, EventArgs e)
        {
            //TODO integrity check

            if (firstNameBox.Text.Length > 0)
            {
                Contact contact = new()
                {
                    FirstName = firstNameBox.Text,
                    SecondName = secondNameBox.Text,
                    Birthday = birthdayBox.Text,
                    Email = emailBox.Text,
                    PhoneNumber = Int32.Parse(phoneNumberBox.Text)
                };

                loggedAccount.Contacts.Add(contact);
                ContactSave();
                contactsGrid.Rows.Clear();
                GridContactLoad();
            }

            firstNameBox.Text = "";
            secondNameBox.Text = "";
            birthdayBox.Text = "";
            emailBox.Text = "";
            phoneNumberBox.Text = "";

            createCancelContact.Hide();
            createSubmitContact.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorButton.BackColor = colorDialog1.Color;
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
