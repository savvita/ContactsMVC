using ContactsMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    public partial class AddContactForm : Form
    {
        public ContactModel Contact { get; set; }
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Contact = new ContactModel { FirstName = this.firstNameTextBox.Text, LastName = this.lastNameTextBox.Text};
            this.Close();
        }
    }
}
