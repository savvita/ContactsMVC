using ContactsMVC.Controller;
using ContactsMVC.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ContactPreviewListControl : UserControl
    {
        private ContactController contactController;
        public ContactPreviewListControl()
        {
            InitializeComponent();
        }

        public ContactPreviewListControl(ContactController controller) : this()
        {
            this.contactController = controller;
            SetContacts(controller.GetContacts());

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(4, 4, 36, 36);
           
            this.deleteButton.Region = new Region(path);
            this.addButton.Region = new Region(path);
        }


        private void SearchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if(this.searchTextBox.Text.Equals(string.Empty))
            {
                SetContacts(contactController.GetContacts());
            }
            else
            {
                SetContacts(contactController.GetContacts().Where(x => x.FirstName.ToLower().Contains(this.searchTextBox.Text.ToLower()) ||
                x.LastName.ToLower().Contains(searchTextBox.Text.ToLower())));
            }
        }

        private void Contact_Selected(object sender, EventArgs e)
        {
            ContactPreviewControl selectedControl = sender as ContactPreviewControl;

            SetImage(selectedControl.Contact);
            this.nameLabel.Text = selectedControl.Contact.ToString();

            foreach(ContactPreviewControl control in this.contactsPanel.Controls)
            {
                if (control != selectedControl)
                    control.UnselectContact();
            }
        }

        private void Contact_Changed(object sender, EventArgs e)
        {
            ContactPreviewControl control = sender as ContactPreviewControl;

            if (control != null)
            {
                this.contactController.EditContact(control.Contact.ID, control.Contact);
                UpdateContacts();
            }
        }

        private void ContactPreviewListControl_Load(object sender, EventArgs e)
        {
            ContactModel contact = contactController.GetContacts().FirstOrDefault();
            SetImage(contact);

            this.nameLabel.Text = contact?.ToString();
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContactForm form = new AddContactForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                this.contactController.AddContact(form.Contact);
                UpdateContacts();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach(ContactPreviewControl control in this.contactsPanel.Controls)
            {
                if(control.IsSelected)
                {
                    DeleteContact(control.Contact);

                    break;
                }
            }
        }

        private void SetContacts(IEnumerable<ContactModel>contacts)
        {
            this.contactsPanel.Controls.Clear();

            int height = 0;

            foreach(ContactModel contact in contacts)
            {
                ContactPreviewControl control = new ContactPreviewControl(contact);
                control.Location = new Point(0, height);
                control.Selected += Contact_Selected;
                control.ContactChanged += Contact_Changed;
                control.ContactDeleted += DeleteButton_Click;
                this.contactsPanel.Controls.Add(control);

                height += control.Size.Height + 5;
            }
        }

        private void UpdateContacts()
        {
            SetContacts(this.contactController.GetContacts());
        }

        private void SetImage(ContactModel contact)
        {
            if (contact == null || !File.Exists(contact.ImageFile))
            {
                this.contactImage.Image = Properties.Resources.NoPhoto;
            }
            else
            {
                this.contactImage.Image = Image.FromFile(contact.ImageFile);
            }
        }

        private void DeleteContact(ContactModel contact)
        {
            if (MessageBox.Show($"Delete Contact {contact.ToString()}?",
                "Delete Contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.contactController.RemoveContact(contact);
                UpdateContacts();

                this.contactImage.Image = Properties.Resources.NoPhoto;
                this.nameLabel.Text = String.Empty;
            }
        }
    }
}
