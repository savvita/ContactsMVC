using ContactsMVC.Model;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ContactEditModeControl : UserControl
    {
        public ContactEditModeControl()
        {
            InitializeComponent();
            this.cellphonesTextBox = new List<TextBox>();

            for (int i = 0; i < Settings.MaxCellphonesCount; i++)
            {
                TextBox cellphoneTextBox = new TextBox();
                cellphoneTextBox.Size = new Size(120, 20);
                cellphoneTextBox.Location = new Point(6, 19 + i * 26);
                this.cellphonesTextBox.Add(cellphoneTextBox);
            }

            this.cellphonesGroupBox.Controls.AddRange(this.cellphonesTextBox.ToArray());
        }

        public ContactEditModeControl(ContactModel contact, bool isReadOnly = true) : this()
        {
            if(contact != null)
            {
                SetContactValues(contact, isReadOnly);
            }
        }

        public void SetContactValues(ContactModel contact, bool isReadOnly)
        {
            this.firstNameTextBox.Text = contact.FirstName;
            this.lastNameTetxBox.Text = contact.LastName;
            this.countryTextBox.Text = contact.Country;
            this.cityTetxBox.Text = contact.City;
            this.streetTextBox.Text = contact.Street;
            this.houseTextBox.Text = contact.House;
            this.appartmentTextBox.Text = contact.Appartment;

            for (int i = 0; i < contact.Cellphones.Count; i++)
            {
                this.cellphonesTextBox[i].Text = contact.Cellphones[i];
            }

            if (isReadOnly)
            {
                foreach (Control outer in this.Controls)
                {
                    if(outer is TextBox)
                        (outer as TextBox).ReadOnly = true;

                    foreach (Control inner in outer.Controls)
                    {
                        if (inner is TextBox)
                            (inner as TextBox).ReadOnly = true;
                    }
                }

                this.addImageButton.Enabled = false;
            }
        }
    }
}
