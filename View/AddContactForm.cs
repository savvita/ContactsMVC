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
            this.contactEditModeControl = new Controls.ContactEditModeControl(null);
            this.Controls.Add(this.contactEditModeControl);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Contact = this.contactEditModeControl.GetContact();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
