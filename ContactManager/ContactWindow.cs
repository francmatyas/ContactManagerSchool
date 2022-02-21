using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace ContactManager
{
    public partial class ContactWindow : Form
    {
        private Account loggedAccount = LoginWindow.Account;
        private Contact selectedContact;
        private List<Contact> contactsInGrid;

        private bool ContactEdit = false;
        private bool ContactCreate = false;
        private bool ContactNoteEdit = false;

        public ContactWindow()
        {
            InitializeComponent();
        }

        private void GridContactLoad(List<Contact> contacts)
        {
            contactsInGrid = contacts;
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
                contactsGrid.Columns["Created"].Visible = false;

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

            SelectedContactToTable(0);

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

            switch (LoginWindow.PreferredSort)
            {
                case "az":
                {
                    sortPicker.SelectedItem = "A-Z";
                    break;
                }
                case "za":
                {
                    sortPicker.SelectedItem = "Z-A";
                        break;
                }
                case "favorite":
                {
                    sortPicker.SelectedItem = "★";
                        break;
                }
                default:
                {
                    sortPicker.SelectedItem = "None";
                        break;
                }
            }

            BirthdayReminder();

        }

        private void SelectedContactToTable(int rowIndex)
        {
            try
            {
                if (!(ContactEdit || ContactCreate || ContactNoteEdit))
                {
                    Contact contact = contactsGrid.Rows[rowIndex].DataBoundItem as Contact;
                    selectedContact = contact;

                    firstNameBox.Text = contact.FirstName;
                    secondNameBox.Text = contact.SecondName;

                    // Podmínky pro vkládání do TextBoxu jako reakce na IntegrityCheck
                    if (contact.Birthday.Ticks != 0)
                    {
                        birthdayBox.Text = contact.Birthday.Date.ToString("dd.MM.yyyy");
                    }
                    else
                    {
                        birthdayBox.Text = "";
                    }
                    emailBox.Text = contact.Email;
                    if (contact.PhoneNumber != -1)
                    {
                        phoneNumberBox.Text = contact.PhoneNumber.ToString();

                    }
                    else
                    {
                        phoneNumberBox.Text = "";
                    }

                    noteBox.Text = contact.Note;
                    noteEditCancel.Hide();
                    noteEditSubmit.Hide();

                    if (contact.Favorite)
                    {
                        FavoriteEnablePicture();
                    }
                    else
                    {
                        FavoriteDisablePicture();
                    }

                    createdDateLabel.Text = selectedContact.Created.Date.ToString("dd.MM.yyyy");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
                dateSelectButton.Show();
                colorButton.Hide();
                colorPictureBox.Hide();
                searchButton.Hide();
                favoriteDisabledPicture.Hide();
                favoriteEnabledPicture.Hide();
                noteEditButton.Hide();
                editNotePicture.Hide();
                createContact.Hide();
                deleteContact.Hide();
                createdDateLabel.Hide();

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
                dateSelectButton.Hide();
                colorButton.Show();
                colorPictureBox.Show();
                searchButton.Show();
                favoriteDisabledPicture.Show();
                favoriteEnabledPicture.Show();
                noteEditButton.Show();
                editNotePicture.Show();
                createContact.Show();
                deleteContact.Show();
                createdDateLabel.Show();

                firstNameBox.ReadOnly = true;
                secondNameBox.ReadOnly = true;
                birthdayBox.ReadOnly = true;
                emailBox.ReadOnly = true;
                phoneNumberBox.ReadOnly = true;
                noteBox.ReadOnly = true;
            }
        }

        private void EditContactFormActions(bool action)
        {
            if (action)
            {
                editCancelContact.Show();
                editSubmitContact.Show();
                dateSelectButton.Show();
                colorButton.Hide();
                colorPictureBox.Hide();
                searchButton.Hide();
                favoriteDisabledPicture.Hide();
                favoriteEnabledPicture.Hide();
                noteEditButton.Hide();
                editNotePicture.Hide();
                createContact.Hide();
                deleteContact.Hide();
                createdDateLabel.Hide();

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

                editCancelContact.Hide();
                editSubmitContact.Hide();
                dateSelectButton.Hide();
                colorButton.Show();
                colorPictureBox.Show();
                searchButton.Show();
                favoriteDisabledPicture.Show();
                favoriteEnabledPicture.Show();
                noteEditButton.Show();
                editNotePicture.Show();
                createContact.Show();
                deleteContact.Show();
                createdDateLabel.Show();

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
            ContactCreate = true;
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to delete this contact - " + selectedContact.FullName + "?",
                    "Delete contact", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                selectedContact.Deleted = true;
                ContactSave();
                GridContactLoad(loggedAccount.Contacts);
                if (loggedAccount.Contacts != null)
                {
                    SelectedContactToTable(0);
                }
            }
        }

        private void createCancelContact_Click(object sender, EventArgs e)
        {
            CreateContactFormActions(false);
            SelectedContactToTable(0);
            ContactCreate = false;
        }

        private void createSubmitContact_Click(object sender, EventArgs e)
        {
            // Kontrola, jestli je je zadané jméno. 
            if (!string.IsNullOrEmpty(firstNameBox.Text))
            {
                
                Contact newContact = new()
                {
                    FirstName = firstNameBox.Text,
                    SecondName = secondNameBox.Text,
                    FullName = firstNameBox.Text + " " + secondNameBox.Text,
                    Birthday = BirthdayIntegrityCheck(birthdayBox.Text),
                    Email = EmailIntegrityCheck(emailBox.Text),
                    PhoneNumber = PhoneNumberIntegrityCheck(phoneNumberBox.Text),
                    Favorite = false,
                    Note = noteBox.Text,
                    Color = Color.White,
                    Deleted = false,
                    Created = DateTime.Today,
                    ID = GetNewID(loggedAccount)
                };

                loggedAccount.Contacts.Add(newContact);
                ContactSave();
                contactsGrid.Rows.Clear();
                GridContactLoad(loggedAccount.Contacts);
                CreateContactFormActions(false);
                ContactCreate = false;
            }
        }

        private void FavoriteEnablePicture()
        {
            favoriteDisabledPicture.Visible = false;
            favoriteEnabledPicture.Visible = true;

            if (selectedContact != null)
            {
                if (!(ContactEdit || ContactCreate || ContactNoteEdit))
                {
                    selectedContact.Favorite = true;
                    contactsGrid.CurrentRow.Cells["Favorite"].Value = selectedContact.Favorite;
                }
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
                if (!(ContactEdit || ContactCreate || ContactNoteEdit))
                {
                    selectedContact.Favorite = false;
                    contactsGrid.CurrentRow.Cells["Favorite"].Value = selectedContact.Favorite;
                }
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
            contactsLabel.ForeColor = primaryContentColor;
            noteEditButton.ForeColor = primaryContentColor;
            noteEditCancel.ForeColor = primaryContentColor;
            contactEditButton.ForeColor = primaryContentColor;
            settingsButton.ForeColor = primaryContentColor;
            editCancelContact.ForeColor = primaryContentColor;

            editSubmitContact.BackColor = primaryContentColor;
            editSubmitContact.FlatAppearance.MouseOverBackColor = secondaryHContentColor;
            editSubmitContact.FlatAppearance.MouseDownBackColor = secondaryCContentColor;

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
            if (string.IsNullOrEmpty(searchInput) || (searchInput == "Search" && searchBox.ForeColor == Color.DarkGray))
            {
                searchBox.Text = "Search";
                searchBox.ForeColor = Color.DarkGray;
            }
            else
            {
                contactsGrid.ClearSelection();

                for (int i = 0; i < contactsGrid.Rows.Count; i++)
                {
                    if (contactsGrid.Rows[i].Cells["FullName"].Value.ToString().ToLower().Contains(searchInput.ToLower()))
                    {
                        contactsGrid.Rows[i].Cells["FullName"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#e0e0e0");
                        contactsGrid.Rows[i].Cells["FullName"].Style.ForeColor = LoginWindow.PrimaryContentColor;
                    }
                }
                searchButton.Hide();
                searchClear.Show();
            }

        }
        private void searchClear_Click(object sender, EventArgs e)
        {
            searchBox.Text = "Search";
            searchBox.ForeColor = Color.DarkGray;

            for (int i = 0; i < contactsGrid.Rows.Count; i++)
            {
                contactsGrid.Rows[i].Cells["Fullname"].Style.BackColor = Color.White;
                contactsGrid.Rows[i].Cells["Fullname"].Style.ForeColor = Color.Black;
            }
            searchButton.Show();
            searchClear.Hide();
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
            ContactNoteEdit = false;
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
            ContactNoteEdit = false;
        }

        private void noteEditButton_Click(object sender, EventArgs e)
        {
            noteEditCancel.Show();
            noteEditSubmit.Show();
            noteBox.ReadOnly = false;
            ContactNoteEdit = true;
        }

        private void contactEditButton_Click(object sender, EventArgs e)
        {
            EditContactFormActions(true);
            ContactEdit = true;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void dateSelectButton_Click(object sender, EventArgs e)
        {
            if (monthCalendar.Visible)
            {
                monthCalendar.Visible = false;
            }
            else
            {
                monthCalendar.Visible = true;
            }
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            birthdayBox.Text = monthCalendar.SelectionStart.ToString("dd.MM.yyyy");
            monthCalendar.Visible = false;
        }

        private void editSubmitContact_Click(object sender, EventArgs e)
        {
            // Editace kontaktu využívá metody IntegrityCheck
            if (!string.IsNullOrEmpty(firstNameBox.Text))
            {
                selectedContact.FirstName = firstNameBox.Text;
                selectedContact.SecondName = secondNameBox.Text;
                selectedContact.FullName = firstNameBox.Text + " " + secondNameBox.Text;
                selectedContact.Birthday = BirthdayIntegrityCheck(birthdayBox.Text);
                selectedContact.Email = EmailIntegrityCheck(emailBox.Text);
                selectedContact.PhoneNumber = PhoneNumberIntegrityCheck(phoneNumberBox.Text);

                ContactSave();
            }
            
            EditContactFormActions(false);
            ContactEdit = false;
        }

        private void editCancelContact_Click(object sender, EventArgs e)
        {
            EditContactFormActions(false);
            SelectedContactToTable(0);
            ContactEdit = false;
        }

        // Tvorba nového ID, najde největší a nové je o 1 větší, pokud nenajde začne nulou.
        private int GetNewID(Account loggetAccount)
        {
            List<int> idList = new List<int>();
            if (loggedAccount.Contacts.Count > 0)
            {
                foreach (var contact in loggedAccount.Contacts)
                {
                    idList.Add(contact.ID);
                }

                return idList.Max() + 1;
            }
            else
            {
                return 0;
            }
        }

        // Kontrola validního data narození
        private DateTime BirthdayIntegrityCheck(string birthday)
        {
            if (string.IsNullOrEmpty(birthday))
            {
                return DateTime.MinValue;
            }
            else
            {
                DateTime parsedBirthday;
                //return DateTime.TryParse(birthday, out temp);
                if (DateTime.TryParse(birthday, out parsedBirthday))
                {
                    return parsedBirthday;
                }
                else
                {
                    return DateTime.MinValue;
                }
            }
        }

        // Kontrola validního emailu pomocí regexu https://www.c-sharpcorner.com/blogs/validate-email-address-in-c-sharp1
        private string EmailIntegrityCheck(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            //return match.Success;
            if (match.Success)
            {
                return email;
            }
            else
            {
                return "";
            }
        }

        // Kontrola validního lefoního čísla
        private long PhoneNumberIntegrityCheck(string phoneNumberString)
        {
            long phoneNumber;
            if (long.TryParse(phoneNumberString, out phoneNumber))
            {
                if (long.Parse(phoneNumberString) > 0)
                {
                    return phoneNumber;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        // Kontrola, jestli má někdo narozeniny
        private void BirthdayReminder()
        {
            List<Contact> contacts = new List<Contact>();
            string birthdayContacts = "";
            DateTime todayTime = DateTime.Today;

            foreach (var contact in loggedAccount.Contacts)
            {
                if (contact.Birthday.Day == todayTime.Day && contact.Birthday.Month == todayTime.Month)
                {
                    contacts.Add(contact);
                    birthdayContacts = birthdayContacts  + contact.FullName + ", ";
                }
            }
            birthdayContacts = birthdayContacts.Remove(birthdayContacts.Length - 2, 2);

            if (contacts.Count > 0)
            {
                birthdayGrid.Visible = true;
                var source = new BindingSource();
                source.DataSource = contacts;

                birthdayGrid.DataSource = source;
                birthdayGrid.Columns["FullName"].HeaderText = "Birthday";
                birthdayGrid.Columns["FullName"].Width = 150;
                birthdayGrid.Columns["Favorite"].Visible = false;
                birthdayGrid.Columns["FirstName"].Visible = false;
                birthdayGrid.Columns["SecondName"].Visible = false;
                birthdayGrid.Columns["ID"].Visible = false;
                birthdayGrid.Columns["Birthday"].Visible = false;
                birthdayGrid.Columns["Email"].Visible = false;
                birthdayGrid.Columns["PhoneNumber"].Visible = false;
                birthdayGrid.Columns["Note"].Visible = false;
                birthdayGrid.Columns["Color"].Width = 1;
                birthdayGrid.Columns["Deleted"].Visible = false;
                birthdayGrid.Columns["Created"].Visible = false;

                for (int i = 0; i < contacts.Count; i++)
                {
                    Contact contact = birthdayGrid.Rows[i].DataBoundItem as Contact;
                    birthdayGrid.Rows[i].Cells["Color"].Style.BackColor = contact.Color;
                    birthdayGrid.Rows[i].Cells["Color"].Style.ForeColor = contact.Color;
                    birthdayGrid.Rows[i].Cells["Color"].Style.SelectionForeColor = contact.Color;
                    birthdayGrid.Rows[i].Cells["Color"].Style.SelectionBackColor = contact.Color;
                }
            }
            else
            {
                birthdayGrid.Visible = false;
            }

            new ToastContentBuilder()
                .AddArgument("action", "viewConversation").AddArgument("conversationId", 9813)
                .AddText("Birthday Reminder!")
                .AddText("Wish happy birthday to " + birthdayContacts + "!")
                .AddAppLogoOverride(new Uri(Path.Combine(Directory.GetCurrentDirectory(), "birthday-cake.png")), ToastGenericAppLogoCrop.Circle)
                .Show();
        }

        private void birthdayGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Contact contact = birthdayGrid.Rows[birthdayGrid.SelectedCells[0].RowIndex].DataBoundItem as Contact;
            for (int i = 0; i < contactsInGrid.Count; i++)
            {
                if (contactsInGrid[i] == contact)
                {
                    contactsGrid.ClearSelection();
                    contactsGrid.Rows[i].Selected = true;

                    try
                    {
                        SelectedContactToTable(i);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                }
            }
        }
    }
}
