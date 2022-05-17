using ContactsMVC.Model;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    public partial class ViewContactForm : Form
    {
        public ContactModel Contact { get; set; }
        public ViewContactForm()
        {
            InitializeComponent();
        }

        public ViewContactForm(ContactModel contact) : this()
        {
            this.Contact = contact;
            this.contactViewModeControl = new Controls.ContactViewModeControl(contact);
            this.Controls.Add(this.contactViewModeControl);

            this.Text = contact.ToString();
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            EditContactForm form = new EditContactForm(this.Contact);
            form.ShowDialog();

            if(form.DialogResult == DialogResult.OK)
            {
                this.Contact = form.Contact;
                this.contactViewModeControl.SetContact(this.Contact);
                this.Text = this.Contact.ToString();
            }
        }

        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
