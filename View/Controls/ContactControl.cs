using ContactsMVC.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ContactControl : UserControl
    {
        private ContactModel _contact;
        public ContactControl()
        {
            InitializeComponent();
            this.cellphonesTextBox = new List<TextBox>();

        }
        public ContactControl(ContactModel contact, bool isReadOnly) : this()
        {
            if (contact != null)
            {
                this._contact = contact;
                SetContact(contact, isReadOnly);
            }
            else
            {
                AddCellphonesTextBox(Settings.MaxCellphonesCount);
                this.pictureBox.Image = Properties.Resources.NoPhoto;
            }
        }

        protected void SetContact(ContactModel contact, bool isReadOnly)
        {
            this.cellphonesTextBox.Clear();

            this.cellphonesGroupBox.Controls.Clear();

            if (isReadOnly)
            {
                AddCellphonesTextBox(contact.Cellphones.Count);
                DisableChanges();
            }
            else
            {
                AddCellphonesTextBox(Settings.MaxCellphonesCount);
            }

            SetContactValues(contact, isReadOnly);
        }

        protected void SetContactValues(ContactModel contact, bool isReadOnly)
        {
            this.firstNameTextBox.Text = contact.FirstName;
            this.lastNameTetxBox.Text = contact.LastName;
            this.countryTextBox.Text = contact.Country;
            this.cityTextBox.Text = contact.City;
            this.streetTextBox.Text = contact.Street;
            this.houseTextBox.Text = contact.House;
            this.appartmentTextBox.Text = contact.Appartment;

            if(File.Exists(contact.ImageFile))
            {
                this.pictureBox.Image = Image.FromFile(contact.ImageFile);
            }
            else
            {
                this.pictureBox.Image = Properties.Resources.NoPhoto;
            }

            for (int i = 0; i < contact.Cellphones.Count; i++)
            {
                this.cellphonesTextBox[i].Text = contact.Cellphones[i];
            }
        }

        private void AddCellphonesTextBox(int count)
        {
            for (int i = 0; i < count; i++)
            {
                TextBox cellphoneTextBox = new TextBox();
                cellphoneTextBox.Size = new Size(150, 20);
                cellphoneTextBox.Location = new Point(6, 19 + i * 26);
                cellphoneTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
                this.cellphonesTextBox.Add(cellphoneTextBox);
            }

            this.cellphonesGroupBox.Controls.AddRange(this.cellphonesTextBox.ToArray());
        }

        private void DisableChanges()
        {
            foreach (Control outer in this.Controls)
            {
                if (outer is TextBox)
                    (outer as TextBox).ReadOnly = true;

                foreach (Control inner in outer.Controls)
                {
                    if (inner is TextBox)
                        (inner as TextBox).ReadOnly = true;
                }
            }

            this.addImageButton.Visible = false;
        }

        public ContactModel GetContact()
        {
            ContactModel contact = new ContactModel
            {
                FirstName = this.firstNameTextBox.Text,
                LastName = this.lastNameTetxBox.Text,
                Country = this.countryTextBox.Text,
                City = this.cityTextBox.Text,
                Street = this.streetTextBox.Text,
                House = this.houseTextBox.Text,
                Appartment = this.appartmentTextBox.Text,
                ImageFile = this.imageFile,               
            };

            if (this._contact != null)
                contact.ID = this._contact.ID;

            foreach(TextBox cellphone in cellphonesTextBox)
            {
                if (!cellphone.Text.Equals(string.Empty))
                    contact.Cellphones.Add(cellphone.Text);
            }

            return contact;
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.Combine(Settings.FilePath, "images");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                try
                {
                    string contactImageFile = Path.Combine(path, $"{DateTime.Now.ToString().Replace(':', '_')}.jpg");

                    File.Copy(dialog.FileName, contactImageFile);
                    this.imageFile = contactImageFile;

                    this.pictureBox.Image = Image.FromFile(contactImageFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
