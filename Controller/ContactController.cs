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
            contacts.Add(new ContactModel { FirstName = "John", LastName = "Smith" });
            contacts.Add(new ContactModel { FirstName = "Stepan", LastName = "Bandera" });
        }
        public List<ContactModel> GetContacts()
        {
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

        public void EditContact (ContactModel oldContact, ContactModel newContact)
        {
            oldContact.FirstName = newContact.FirstName;
            oldContact.LastName = newContact.LastName;
            oldContact.Country = newContact.Country;
            oldContact.City = newContact.City;
            oldContact.Street = newContact.Street;
            oldContact.House = newContact.House;
            oldContact.Appartment = newContact.Appartment;

            oldContact.Cellphones.Clear();
            foreach (string cellphone in newContact.Cellphones)
            {
                oldContact.Cellphones.Add(cellphone);
            }

        }
    }
}
