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
using Microsoft.VisualBasic.CompilerServices;
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
            
            
            if (contacts != null)
            {
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
                contactsGrid.Columns["FullName"].Width = 150;
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
            }

            /*
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
            contactsGrid.Columns["FullName"].Width = 150;
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
            */
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

            this.firstNameBox.AutoSize = false;
            this.firstNameBox.Height = 20;
            this.secondNameBox.AutoSize = false;
            this.secondNameBox.Height = 20;
            this.birthdayBox.AutoSize = false;
            this.birthdayBox.Height = 20;
            this.emailBox.AutoSize = false;
            this.emailBox.Height = 20;
            this.phoneNumberBox.AutoSize = false;
            this.phoneNumberBox.Height = 20;

            ContactWinContentColor(LoginWindow.PrimaryContentColor, LoginWindow.SecondaryHContentColor, LoginWindow.SecondaryCContentColor);

        }


        private void SelectedContactToTable(int rowIndex)
        {
            Contact contact = contactsGrid.Rows[rowIndex].DataBoundItem as Contact;
            selectedContact = contact;

            firstNameBox.Text = contact.FirstName;
            secondNameBox.Text = contact.SecondName;
            birthdayBox.Text = contact.Birthday;
            emailBox.Text = contact.Email;
            phoneNumberBox.Text = contact.PhoneNumber.ToString();
            noteBox.Text = contact.Note;
            noteEditCancel.Hide();
            noteEditSubmit.Hide();

            if (selectedContact.Favorite)
            {
                FavoriteEnablePicture();
            }
            else
            {
                FavoriteDisablePicture();
            }
        }


        private void contactsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SelectedContactToTable(contactsGrid.SelectedCells[0].RowIndex);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }


        private void CreateContactFormActions(bool action)
        {
            if (action)
            {
                ClearBoxes();

                createCancelContact.Show();
                createSubmitContact.Show();
                colorButton.Hide();
                colorPictureBox.Hide();
                searchButton.Hide();
                favoriteDisabledPicture.Hide();
                favoriteEnabledPicture.Hide();
                noteEditButton.Hide();
                createContact.Hide();
                deleteContact.Hide();

                firstNameBox.ReadOnly = false;
                secondNameBox.ReadOnly = false;
                birthdayBox.ReadOnly = false;
                emailBox.ReadOnly = false;
                phoneNumberBox.ReadOnly = false;
                noteBox.ReadOnly = false;
            }
            else
            {
                ClearBoxes();

                contactsGrid.Rows[0].Selected = true;
                SelectedContactToTable(0);

                createCancelContact.Hide();
                createSubmitContact.Hide();
                colorButton.Show();
                colorPictureBox.Show();
                searchButton.Show();
                favoriteDisabledPicture.Show();
                favoriteEnabledPicture.Show();
                noteEditButton.Show();
                createContact.Show();
                deleteContact.Show();

                firstNameBox.ReadOnly = true;
                secondNameBox.ReadOnly = true;
                birthdayBox.ReadOnly = true;
                emailBox.ReadOnly = true;
                phoneNumberBox.ReadOnly = true;
                noteBox.ReadOnly = true;
            }
        }


        private void createContact_Click(object sender, EventArgs e)
        {
            CreateContactFormActions(true);
        }


        private void deleteContact_Click(object sender, EventArgs e)
        {
            selectedContact.Deleted = true;
            ContactSave();
            GridContactLoad(loggedAccount.Contacts);

        }


        private void createCancelContact_Click(object sender, EventArgs e)
        {
            CreateContactFormActions(false);
        }


        private void createSubmitContact_Click(object sender, EventArgs e)
        {
            //TODO integrity check

            if (firstNameBox.Text.Length > 0)
            {
                List<int> idList = new List<int>();
                if (loggedAccount.Contacts.Count > 0)
                {
                    foreach (var contact in loggedAccount.Contacts)
                    {
                        idList.Add(contact.ID);
                    }
                }
                else
                {
                    idList.Add((int)0);
                }

                Contact newContact = new()
                {
                    FirstName = firstNameBox.Text,
                    SecondName = secondNameBox.Text,
                    FullName = firstNameBox.Text + " " + secondNameBox.Text,
                    Birthday = birthdayBox.Text,
                    Email = emailBox.Text,
                    PhoneNumber = long.Parse(phoneNumberBox.Text),
                    Favorite = false,
                    Note = noteBox.Text,
                    Color = Color.White,
                    Deleted = false,
                    ID = idList.Max() + 1
                };

                loggedAccount.Contacts.Add(newContact);
                ContactSave();
                contactsGrid.Rows.Clear();
                GridContactLoad(loggedAccount.Contacts);
                CreateContactFormActions(false);
            }
        }


        private void FavoriteEnablePicture()
        {
            favoriteDisabledPicture.Visible = false;
            favoriteEnabledPicture.Visible = true;

            if (selectedContact != null)
            {
                selectedContact.Favorite = true;
                contactsGrid.CurrentRow.Cells["Favorite"].Value = selectedContact.Favorite;
            }
        }

        private void favoriteDisabledPicture_Click(object sender, EventArgs e)
        {
            FavoriteEnablePicture();
        }

        private void FavoriteDisablePicture()
        {
            favoriteEnabledPicture.Visible = false;
            favoriteDisabledPicture.Visible = true;

            if (selectedContact != null)
            {
                selectedContact.Favorite = false;
                contactsGrid.CurrentRow.Cells["Favorite"].Value = selectedContact.Favorite;
            }
        }

        private void favoriteEnabledPicture_Click(object sender, EventArgs e)
        {
            FavoriteDisablePicture();
        }

        private void ClearBoxes()
        {
            firstNameBox.Text = "";
            secondNameBox.Text = "";
            birthdayBox.Text = "";
            emailBox.Text = "";
            phoneNumberBox.Text = "";
            noteBox.Text = "";
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


        private void ContactWinContentColor(Color primaryContentColor, Color secondaryHContentColor, Color secondaryCContentColor)
        {
            createContact.BackColor = primaryContentColor;
            createContact.FlatAppearance.MouseOverBackColor = secondaryHContentColor;
            createContact.FlatAppearance.MouseDownBackColor = secondaryCContentColor;

            createSubmitContact.BackColor = primaryContentColor;
            createSubmitContact.FlatAppearance.MouseOverBackColor = secondaryHContentColor;
            createSubmitContact.FlatAppearance.MouseDownBackColor = secondaryCContentColor;

            deleteContact.ForeColor = primaryContentColor;
            createCancelContact.ForeColor = primaryContentColor;
            colorButton.ForeColor = primaryContentColor;
            colorButton.FlatAppearance.BorderColor = primaryContentColor;
            contactsLabel.ForeColor = primaryContentColor;
            noteEditButton.ForeColor = primaryContentColor;
            noteEditCancel.ForeColor = primaryContentColor;

            noteEditSubmit.BackColor = primaryContentColor;
            noteEditSubmit.FlatAppearance.MouseDownBackColor = secondaryCContentColor;
            noteEditSubmit.FlatAppearance.MouseOverBackColor = secondaryHContentColor;

            contactsGrid.AlternatingRowsDefaultCellStyle.SelectionForeColor = primaryContentColor;
            contactsGrid.RowsDefaultCellStyle.SelectionForeColor = primaryContentColor;

            panel2.BackColor = primaryContentColor;
            panel3.BackColor = primaryContentColor;
            panel5.BackColor = primaryContentColor;
            panel6.BackColor = primaryContentColor;
            panel7.BackColor = primaryContentColor;
            panel8.BackColor = primaryContentColor;
            panel9.BackColor = primaryContentColor;
            panel11.BackColor = primaryContentColor;
            panel12.BackColor = primaryContentColor;
            panel13.BackColor = primaryContentColor;
            panel14.BackColor = primaryContentColor;
            panel15.BackColor = primaryContentColor;
            panel16.BackColor = primaryContentColor;
            panel17.BackColor = primaryContentColor;
            panel18.BackColor = primaryContentColor;
            panel21.BackColor = primaryContentColor;
            panel22.BackColor = primaryContentColor;
        }


        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.SelectAll();
            searchBox.ForeColor = Color.Black;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchInput = searchBox.Text;
            contactsGrid.ClearSelection();

            for (int i = 0; i < contactsGrid.Rows.Count; i++)
            {
                if (contactsGrid.Rows[i].Cells["FullName"].Value.ToString().ToLower().Contains(searchInput.ToLower()))
                {
                    contactsGrid.Rows[i].Selected = true;
                    SelectedContactToTable(i);
                }
            }
            
        }


        private void noteEditCancel_Click(object sender, EventArgs e)
        {
            if (selectedContact != null && selectedContact.Note != null)
            {
                noteBox.Text = selectedContact.Note;
            }

            noteEditCancel.Hide();
            noteEditSubmit.Hide();
            noteBox.ReadOnly = true;
        }


        private void noteEditSubmit_Click(object sender, EventArgs e)
        {
            if (selectedContact != null)
            {
                selectedContact.Note = noteBox.Text;
            }

            noteEditCancel.Hide();
            noteEditSubmit.Hide();
            noteBox.ReadOnly = true;
        }


        private void noteEditButton_Click(object sender, EventArgs e)
        {
            noteEditCancel.Show();
            noteEditSubmit.Show();
            noteBox.ReadOnly = false;
        }
    }
}
