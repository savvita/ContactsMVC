using System.Collections.Generic;
using System.Linq;
using ContactsMVC.Model;

namespace ContactsMVC.Controller
{
    public class ContactController
    {
        private List<ContactModel> contacts;
        FileController fileController;

        public ContactController()
        {
            contacts = new List<ContactModel>();
            fileController = new FileController();
            contacts = fileController.LoadFromFile();
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

        public void EditContact(int id, ContactModel newContact)
        {
            ContactModel contact = this.contacts.Find(x => x.ID == id);

            if (contact != null)
            {
                contact.FirstName = newContact.FirstName;
                contact.LastName = newContact.LastName;
                contact.Country = newContact.Country;
                contact.City = newContact.City;
                contact.Street = newContact.Street;
                contact.House = newContact.House;
                contact.Appartment = newContact.Appartment;
                contact.ImageFile = newContact.ImageFile;

                contact.Cellphones.Clear();
                foreach (string cellphone in newContact.Cellphones)
                {
                    contact.Cellphones.Add(cellphone);
                }
            }

        }

        public void SaveContacts()
        {
            fileController.SaveToFile(contacts);
        }
    }
}
