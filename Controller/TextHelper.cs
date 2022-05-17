using ContactsMVC.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ContactsMVC.Controller
{
    public static class TextHelper
    {
        public static string FullPath(this string fileName)
        {
            return Path.Combine(Settings.FilePath, fileName);
        }

        public static List<string> LoadFromFile(this string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<string>();
            }

            return File.ReadAllLines(fileName).ToList();
        }

        public static List<ContactModel> ConvertToContacts(this List<string> lines)
        {
            List<ContactModel> contacts = new List<ContactModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ContactModel contact = new ContactModel();

                int i = 0;

                contact.ID = int.Parse(cols[i++]);

                contact.FirstName = cols[i++];
                contact.LastName = cols[i++];

                contact.Country = cols[i++];
                contact.City = cols[i++];
                contact.Street = cols[i++];
                contact.House = cols[i++];
                contact.Appartment = cols[i++];

                contact.ImageFile = cols[i++];

                for (int j = i; j < cols.Length; j++)
                {
                    contact.Cellphones.Add(cols[j]);
                }

                contacts.Add(contact);
            }
            return contacts;
        }

    }

}
