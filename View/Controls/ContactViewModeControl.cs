using ContactsMVC.Model;


namespace ContactsMVC.View.Controls
{
    public partial class ContactViewModeControl : ContactControl
    {
        public ContactViewModeControl(ContactModel contact) : base(contact, true)
        {
        }

        public void SetContact(ContactModel contact)
        {
            base.SetContact(contact, true);
        }
    }
}
