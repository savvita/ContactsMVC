using System.Collections.Generic;
using System.Linq;
using ContactsMVC.Model;

namespace ContactsMVC.Controller
{
    public class ContactController
    {
        private List<ContactModel> contacts;

        public ContactController()
        {
            contacts = new List<ContactModel>();
        }
        public List<ContactModel> GetContacts()
        {
            contacts.Add(new ContactModel { FirstName = "John", LastName = "Smith" });
            contacts.Add(new ContactModel { FirstName = "Stepan", LastName = "Bandera" });
            return contacts;
        }

        public void AddContact(ContactModel contact)
        {
            int currentID = 1;

            if(contacts.Count > 0)
                currentID = contacts.OrderByDescending(x => x.ID).First().ID + 1;

            contact.ID = currentID;

            contacts.Add(contact);
        }

        public void RemoveContact(ContactModel contact)
        {
            contacts.Remove(contacts.Find(x => x.ID == contact.ID));
        }
    }
}
