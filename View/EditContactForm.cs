using ContactsMVC.Model;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    public partial class EditContactForm : Form
    {
        public ContactModel Contact { get; set; }
        public EditContactForm()
        {
            InitializeComponent();
        }

        public EditContactForm(ContactModel contact) : this()
        {
            this.Contact = contact;
            this.contactEditModeControl = new Controls.ContactEditModeControl(contact);
            this.Controls.Add(this.contactEditModeControl);
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            this.Contact = this.contactEditModeControl.GetContact();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
