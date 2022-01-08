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
        private Contact selectedContact;

        private List<Person> People = new List<Person>();

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
            //ContactLoad();
            var source = new BindingSource();
            List<Contact> gridContacts = new List<Contact>();

            foreach (var contact in loggedAccount.Contacts)
            {
                if (!contact.Deleted)
                {
                    gridContacts.Add(contact);
                }
            }
            source.DataSource = gridContacts;

            contactsGrid.DataSource = source;
            contactsGrid.Columns["FullName"].HeaderText = "Name";
            contactsGrid.Columns["Favorite"].HeaderText = "⭐";
            contactsGrid.Columns["FullName"].Width = 125;
            contactsGrid.Columns["Favorite"].Width = 25;
            contactsGrid.Columns["FirstName"].Visible = false;
            contactsGrid.Columns["SecondName"].Visible = false;
            contactsGrid.Columns["ID"].Visible = false;
            contactsGrid.Columns["Birthday"].Visible = false;
            contactsGrid.Columns["Email"].Visible = false;
            contactsGrid.Columns["PhoneNumber"].Visible = false;
            contactsGrid.Columns["Note"].Visible = false;
            contactsGrid.Columns["Color"].Visible = false;
            contactsGrid.Columns["Deleted"].Visible = false;

            
            for (int i = 0; i < gridContacts.Count; i++)
            {
                Contact contact = contactsGrid.Rows[i].DataBoundItem as Contact;
                contactsGrid.Rows[i].DefaultCellStyle.BackColor = contact.Color;
            }

            //Contact testContact = contactsGrid.Rows[0].DataBoundItem as Contact;
            
        }

        private void ContactSave()
        {
            List<Account> Accounts = new List<Account>();

            var jsonString = File.ReadAllText(LoginWindow.ContactsFile);
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

            Contact contact = contactsGrid.Rows[contactsGrid.SelectedCells[0].RowIndex].DataBoundItem as Contact;
            selectedContact = contact;
            //selectedRowId = Int32.Parse(contactsGrid.Rows[contactsGrid.SelectedCells[0].RowIndex].Cells[0].Value.ToString());

            groupBox1.Text = contact.FirstName + " " + contact.SecondName;

            firstNameBox.Text = contact.FirstName;
            secondNameBox.Text = contact.SecondName;
            birthdayBox.Text = contact.Birthday;
            emailBox.Text = contact.Email;
            phoneNumberBox.Text = contact.PhoneNumber.ToString();
            favoriteCheckBox.Checked = contact.Favorite;

            /*
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
            */

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
            clearBoxes();

            createCancelContact.Show();
            createSubmitContact.Show();
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            selectedContact.Deleted = true;
            MessageBox.Show(text: selectedContact.FullName + selectedContact.Deleted);
            contactsGrid.Rows.Clear();
            ContactSave();
            GridContactLoad();

            /*
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
            */
        }

        private void createCancelContact_Click(object sender, EventArgs e)
        {
            clearBoxes();

            createCancelContact.Hide();
            createSubmitContact.Hide();
        }

        private void createSubmitContact_Click(object sender, EventArgs e)
        {
            //TODO integrity check

            if (firstNameBox.Text.Length > 0)
            {
                List<int> idList = new List<int>();
                foreach (var contact  in loggedAccount.Contacts)
                {
                    idList.Add(contact.ID);
                }
                Contact newContact = new()
                {
                    FirstName = firstNameBox.Text,
                    SecondName = secondNameBox.Text,
                    Birthday = birthdayBox.Text,
                    Email = emailBox.Text,
                    PhoneNumber = Int32.Parse(phoneNumberBox.Text),
                    Favorite = false,
                    Color = Color.White,
                    Deleted = false,
                    ID = idList.Max() + 1
                };

                loggedAccount.Contacts.Add(newContact);
                ContactSave();
                contactsGrid.Rows.Clear();
                GridContactLoad();
            }

            clearBoxes();

            createCancelContact.Hide();
            createSubmitContact.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedContact.Color = colorDialog1.Color;
                contactsGrid.CurrentRow.DefaultCellStyle.BackColor = selectedContact.Color;
            }
        }

        private void favoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selectedContact.Favorite = favoriteCheckBox.Checked;
            contactsGrid.CurrentRow.Cells["Favorite"].Value = selectedContact.Favorite;
            
        }

        private void clearBoxes()
        {
            firstNameBox.Text = "";
            secondNameBox.Text = "";
            birthdayBox.Text = "";
            emailBox.Text = "";
            phoneNumberBox.Text = "";
            favoriteCheckBox.Checked = false;
        }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contact Contact { get; set; }


    }
}
