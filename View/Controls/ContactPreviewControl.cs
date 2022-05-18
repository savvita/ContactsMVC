using ContactsMVC.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ContactsMVC.View.Controls
{
    public partial class ContactPreviewControl : UserControl
    {
        public ContactModel Contact { get; private set; }
        public event EventHandler Selected;
        public event EventHandler ContactChanged;
        public event EventHandler ContactDeleted;
        public bool IsSelected;
        public ContactPreviewControl()
        {
            InitializeComponent();
        }

        public ContactPreviewControl(ContactModel contact) : this()
        {
            this.Contact = contact;
            this.nameLabel.Text = contact.ToString();
            this.cellphoneLabel.Text = contact.Cellphones.FirstOrDefault();
        }

        private void ContactPreviewControl_DoubleClick(object sender, EventArgs e)
        {
            ViewContact();
        }

        private void ContactPreviewControl_Click(object sender, EventArgs e)
        {

            if (this.IsSelected)
            {
                UnselectContact();
            }
            else
            {
                SelectContact();
            }
        }

        //
        // Context menu
        //
        private void ViewMenuItem_Click(object sender, EventArgs e)
        {
            ViewContact();
        }
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            EditContactForm form = new EditContactForm(this.Contact);
            form.ShowDialog();

            if(form.DialogResult == DialogResult.OK)
            {
                this.Contact = form.Contact;

                if (ContactChanged != null)
                    ContactChanged(this, EventArgs.Empty);
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (ContactDeleted != null)
                ContactDeleted(this, EventArgs.Empty);
        }



        public void UnselectContact()
        {
            this.IsSelected = false;
            this.BackColor = Color.FromKnownColor(KnownColor.ButtonShadow);
        }

        public void SelectContact()
        {
            this.IsSelected = true;

            this.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);

            if (this.Selected != null)
                Selected(this, EventArgs.Empty);
        }

        private void ViewContact()
        {
            ViewContactForm form = new ViewContactForm(Contact);
            form.ShowDialog();
            this.Contact = form.Contact;

            if (this.ContactChanged != null)
                this.ContactChanged(this, EventArgs.Empty);
        }

        private void ContactPreviewControl_Click(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                SelectContact();
            }
        }
    }
}
