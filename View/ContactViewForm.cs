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
            this.contactEditModeControl.SetContactValues(contact, true);
        }
    }
}
