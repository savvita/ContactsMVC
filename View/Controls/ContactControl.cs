﻿using ContactsMVC.Model;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
            this.cellphonesTextBox = new List<TextBox>();

        }
        public ContactControl(ContactModel contact, bool isReadOnly) : this()
        {
            if (contact != null)
            {
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
            else
            {
                AddCellphonesTextBox(Settings.MaxCellphonesCount);
                this.pictureBox.Image = Properties.Resources.NoPhoto;
            }

            this.firstNameTextBox.Select();
        }

        public void SetContactValues(ContactModel contact, bool isReadOnly)
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
                cellphoneTextBox.Size = new Size(120, 20);
                cellphoneTextBox.Location = new Point(6, 19 + i * 26);
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

            foreach(TextBox cellphone in cellphonesTextBox)
            {
                if (!cellphone.Text.Equals(string.Empty))
                    contact.Cellphones.Add(cellphone.Text);
            }

            return contact;
        }
    }
}