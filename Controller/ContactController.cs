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

        public void EditContact (ContactModel oldContact, ContactModel newContact)
        {
            oldContact.FirstName = newContact.FirstName;
            oldContact.LastName = newContact.LastName;
            oldContact.Country = newContact.Country;
            oldContact.City = newContact.City;
            oldContact.Street = newContact.Street;
            oldContact.House = newContact.House;
            oldContact.Appartment = newContact.Appartment;
            oldContact.ImageFile = newContact.ImageFile;

            oldContact.Cellphones.Clear();
            foreach (string cellphone in newContact.Cellphones)
            {
                oldContact.Cellphones.Add(cellphone);
            }

        }

        public void SaveContacts()
        {
            fileController.SaveToFile(contacts);
        }
    }
}
