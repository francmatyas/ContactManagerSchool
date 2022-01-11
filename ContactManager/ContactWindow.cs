using System;
using System.CodeDom.Compiler;
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

        public ContactWindow()
        {
            InitializeComponent();
        }

        private void GridContactLoad(List<Contact> contacts)
        {
            contactsGrid.Rows.Clear();
            var source = new BindingSource();
            List<Contact> gridContacts = new List<Contact>();

            foreach (var contact in contacts)
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
            contactsGrid.Columns["Color"].Width = 1;
            contactsGrid.Columns["Deleted"].Visible = false;

            for (int i = 0; i < gridContacts.Count; i++)
            {
                Contact contact = contactsGrid.Rows[i].DataBoundItem as Contact;
                contactsGrid.Rows[i].Cells["Color"].Style.BackColor = contact.Color;
                contactsGrid.Rows[i].Cells["Color"].Style.ForeColor = contact.Color;
                contactsGrid.Rows[i].Cells["Color"].Style.SelectionForeColor = contact.Color;
                contactsGrid.Rows[i].Cells["Color"].Style.SelectionBackColor = contact.Color;
            }
            contactsGrid.ClearSelection();

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
            GridContactLoad(loggedAccount.Contacts);
            sortPicker.SelectedItem = sortPicker.Items[0];
        }

        private void contactsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Contact contact = contactsGrid.Rows[contactsGrid.SelectedCells[0].RowIndex].DataBoundItem as Contact;
            selectedContact = contact;

            groupBox1.Text = contact.FirstName + " " + contact.SecondName;

            firstNameBox.Text = contact.FirstName;
            secondNameBox.Text = contact.SecondName;
            birthdayBox.Text = contact.Birthday;
            emailBox.Text = contact.Email;
            phoneNumberBox.Text = contact.PhoneNumber.ToString();
            favoriteCheckBox.Checked = contact.Favorite;

        }

        private void createContact_Click(object sender, EventArgs e)
        {
            ClearBoxes();

            createCancelContact.Show();
            createSubmitContact.Show();
            colorButton.Hide();
            favoriteCheckBox.Hide();
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            selectedContact.Deleted = true;
            ContactSave();
            GridContactLoad(loggedAccount.Contacts);

        }

        private void createCancelContact_Click(object sender, EventArgs e)
        {
            ClearBoxes();

            createCancelContact.Hide();
            createSubmitContact.Hide();
            colorButton.Show();
            favoriteCheckBox.Show();
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
                    FullName = firstNameBox.Text + " " + secondNameBox.Text,
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
                GridContactLoad(loggedAccount.Contacts);
            }

            ClearBoxes();

            createCancelContact.Hide();
            createSubmitContact.Hide();
            colorButton.Show();
            favoriteCheckBox.Show();
        }

        private void favoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            selectedContact.Favorite = favoriteCheckBox.Checked;
            contactsGrid.CurrentRow.Cells["Favorite"].Value = selectedContact.Favorite;
            
        }

        private void ClearBoxes()
        {
            firstNameBox.Text = "";
            secondNameBox.Text = "";
            birthdayBox.Text = "";
            emailBox.Text = "";
            phoneNumberBox.Text = "";
            favoriteCheckBox.Checked = false;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {

                if (selectedContact != null)
                {
                    selectedContact.Color = colorDialog1.Color;
                    contactsGrid.CurrentRow.Cells["Color"].Style.BackColor = selectedContact.Color;
                    contactsGrid.CurrentRow.Cells["Color"].Style.ForeColor = selectedContact.Color;
                    contactsGrid.CurrentRow.Cells["Color"].Style.SelectionForeColor = selectedContact.Color;
                    contactsGrid.CurrentRow.Cells["Color"].Style.SelectionBackColor = selectedContact.Color;
                }
            }
        }

        private void ContactWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ContactSave();
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }

        private void sortPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sortPicker.SelectedIndex)
            {
                case 0:
                    GridContactLoad(loggedAccount.Contacts);
                    break;

                case 1:
                    GridContactLoad(SortAZ());
                    break;

                case 2:
                    Dictionary<Contact, string> contactDictionaryZA = new Dictionary<Contact, string>();

                    foreach (var contact in loggedAccount.Contacts)
                    {
                        contactDictionaryZA.Add(contact, contact.FullName);
                    }

                    var itemsZA = from pair in contactDictionaryZA orderby pair.Value descending select pair;
                    List<Contact> contactsZA = new List<Contact>();

                    foreach (var item in itemsZA)
                    {
                        contactsZA.Add(item.Key);
                    }
                    GridContactLoad(contactsZA);
                    break;

                case 3:
                    List<Contact> contacts = SortAZ();
                    List<Contact> contactsFav = new List<Contact>();

                    foreach (var contact in contacts)
                    {
                        if (contact.Favorite)
                        {
                            contactsFav.Add(contact);
                        }
                    }
                    foreach (var contact in contacts)
                    {
                        if (!contact.Favorite)
                        {
                            contactsFav.Add(contact);
                        }
                    }
                    GridContactLoad(contactsFav);
                    break;
            }
        }
        private List<Contact> SortAZ ()
        {
            Dictionary<Contact, string> contactDictionaryAZ = new Dictionary<Contact, string>();

            foreach (var contact in loggedAccount.Contacts)
            {
                contactDictionaryAZ.Add(contact, contact.FullName);
            }

            var itemsAZ = from pair in contactDictionaryAZ orderby pair.Value ascending select pair;
            List<Contact> contactsAZ = new List<Contact>();

            foreach (var item in itemsAZ)
            {
                contactsAZ.Add(item.Key);
            }

            return contactsAZ;
        }
    }
}
