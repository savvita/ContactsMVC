using ContactsMVC.Model;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    public partial class ContactViewForm : Form
    {
        public ContactViewForm()
        {
            InitializeComponent();
        }

        public ContactViewForm(ContactModel contact) : this()
        {
            this.contactViewModeControl = new Controls.ContactViewModeControl(contact);
            this.Controls.Add(this.contactViewModeControl);
        }

        private void EditButton_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
