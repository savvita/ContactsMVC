using ContactsMVC.Model;

namespace ContactsMVC.View.Controls
{
    public partial class ContactEditModeControl : ContactControl
    {
        public ContactEditModeControl(ContactModel contact) : base(contact, false)
        {
        }
        public void SetContact(ContactModel contact)
        {
            base.SetContact(contact, false);
        }
    }
}
