using ContactsMVC.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsMVC.Controller
{
    public class FileController
    {
        private string contactsFileName = "contacts.csv".FullPath();

        public void SaveToFile(List<ContactModel> contacts)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ContactModel contact in contacts)
            {
                sb.Append($"{contact.ID},{contact.FirstName},{contact.LastName},");
                sb.Append($"{contact.Country},{contact.City},{contact.Street},{contact.House},{contact.Appartment},");
                sb.Append($"{contact.ImageFile},");

                foreach (string cellphone in contact.Cellphones)
                {
                    sb.Append($"{cellphone},");
                }

                sb.Remove(sb.Length - 1, 1);
                sb.AppendLine();
            }
            File.WriteAllText(contactsFileName, sb.ToString());
        }

        public List<ContactModel> LoadFromFile()
        {
            try
            {
                return contactsFileName.LoadFromFile().ConvertToContacts();
            }
            catch
            {

            }

            return new List<ContactModel>();
        }
    }
}
