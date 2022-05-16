using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsMVC.Model
{
    public class ContactModel
    {
        public int ID { get; set; }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Country {get; set;}
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public List<string> Cellphones { get; set; }

        public ContactModel ()
        {
            Cellphones = new List<string> ();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
