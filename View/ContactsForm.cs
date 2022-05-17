using ContactsMVC.Controller;
using ContactsMVC.Model;
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

namespace ContactsMVC.View
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();

            this.contactController = new ContactController();
            this.contacts = this.contactController.GetContacts();

            this.bindingSource = new BindingSource();
            this.bindingSource.DataSource = this.contacts;

            this.contactsListBox.DataSource = this.bindingSource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContactForm form = new AddContactForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                contactController.AddContact(form.Contact);
                bindingSource.ResetBindings(false);
            }
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.contactsListBox.SelectedValue != null)
            {
                this.nameLabel.Text = this.contacts[this.contactsListBox.SelectedIndex].ToString();

                if (File.Exists(this.contacts[this.contactsListBox.SelectedIndex].ImageFile))
                {
                    this.pictureBox.Image = Image.FromFile(this.contacts[this.contactsListBox.SelectedIndex].ImageFile);
                }
                else
                {
                    this.pictureBox.Image = Properties.Resources.NoPhoto;
                }
            }
        }

        private void ContactsListBox_DoubleClicked(object sender, EventArgs e)
        {
            if(this.contactsListBox.SelectedValue != null)
            {
                ViewContactForm form = new ViewContactForm(this.contacts[this.contactsListBox.SelectedIndex]);
                form.ShowDialog();

                contactController.EditContact(this.contacts[this.contactsListBox.SelectedIndex], form.Contact);

                this.bindingSource.ResetBindings(false);
            }
        }

        private void ContactsListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ContactsListBox_DoubleClicked(this, EventArgs.Empty);
            }
        }
    }
}
