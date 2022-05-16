using System.Collections.Generic;
using ContactsMVC.Model;

namespace ContactsMVC.Controller
{
    public class ContactController
    {
        private List<ContactModel> contacts;
        public List<ContactModel> GetContacts()
        {
            return contacts;
        }

        public void AddContact(ContactModel contact)
        {
            contacts.Add(contact);
        }

        public void RemoveContact(ContactModel contact)
        {
            contacts.Remove(contacts.Find(x => x.ID == contact.ID));
        }
    }
}
