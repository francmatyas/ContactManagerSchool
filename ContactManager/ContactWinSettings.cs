using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class ContactWinSettings : Form
    {
        private Account loggedAccount = LoginWindow.Account;
        private Contact selectedContact;

        public ContactWinSettings()
        {
            InitializeComponent();
        }

        private void GridLoad(List<Contact> contacts)
        {
            deletedContactGrid.Rows.Clear();
            var source = new BindingSource();
            List<Contact> deletedContacts = new List<Contact>();

            if (contacts != null)
            {
                foreach (var contact in contacts)
                {
                    if (contact.Deleted)
                    {
                        deletedContacts.Add(contact);
                    }
                }
                source.DataSource = deletedContacts;

                deletedContactGrid.DataSource = source;
                deletedContactGrid.Columns["FullName"].HeaderText = "Name";
                deletedContactGrid.Columns["Deleted"].HeaderText = "🗑";
                deletedContactGrid.Columns["FullName"].Width = 150;
                deletedContactGrid.Columns["Deleted"].Width = 25;
                deletedContactGrid.Columns["Favorite"].Visible = false;
                deletedContactGrid.Columns["FirstName"].Visible = false;
                deletedContactGrid.Columns["SecondName"].Visible = false;
                deletedContactGrid.Columns["ID"].Visible = false;
                deletedContactGrid.Columns["Birthday"].Visible = false;
                deletedContactGrid.Columns["Email"].Visible = false;
                deletedContactGrid.Columns["PhoneNumber"].Visible = false;
                deletedContactGrid.Columns["Note"].Visible = false;
                deletedContactGrid.Columns["Color"].Visible = false;
                deletedContactGrid.Columns["Created"].Visible = false;
            }
        }

        private void ContactWinSettings_Load(object sender, EventArgs e)
        {
            GridLoad(loggedAccount.Contacts);
            ContactWinContentColor(LoginWindow.PrimaryContentColor, LoginWindow.SecondaryHContentColor, LoginWindow.SecondaryCContentColor);
        }

        private void deletedContactGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedContactToTable(deletedContactGrid.SelectedCells[0].RowIndex);
        }

        private void SelectedContactToTable(int rowIndex)
        {
            try
            {
                Contact contact = deletedContactGrid.Rows[rowIndex].DataBoundItem as Contact;
                selectedContact = contact;

                firstNameBox.Text = contact.FirstName;
                secondNameBox.Text = contact.SecondName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void ContactWinContentColor(Color primaryContentColor, Color secondaryHContentColor, Color secondaryCContentColor)
        {
            selectedContactLabel.ForeColor = primaryContentColor;

            panel1.BackColor = primaryContentColor;
            panel2.BackColor = primaryContentColor;
            panel3.BackColor = primaryContentColor;

            confirmButton.BackColor = primaryContentColor;
            confirmButton.FlatAppearance.MouseDownBackColor = secondaryCContentColor;
            confirmButton.FlatAppearance.MouseOverBackColor = secondaryHContentColor;

            removeButton.BackColor = primaryContentColor;
            removeButton.FlatAppearance.MouseDownBackColor = secondaryCContentColor;
            removeButton.FlatAppearance.MouseOverBackColor = secondaryHContentColor;

            restoreButton.BackColor = primaryContentColor;
            restoreButton.FlatAppearance.MouseDownBackColor = secondaryCContentColor;
            restoreButton.FlatAppearance.MouseOverBackColor = secondaryHContentColor;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            selectedContact.Deleted = false;
            GridLoad(loggedAccount.Contacts);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
