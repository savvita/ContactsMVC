using ContactsMVC.Controller;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    public partial class ContactBookForm : Form
    {
        private ContactController contactController;

        public ContactBookForm()
        {
            InitializeComponent();

            contactController = new ContactController();
            // 
            // contactPreviewListControl
            // 
            this.contactPreviewListControl = new Controls.ContactPreviewListControl(contactController);
            this.contactPreviewListControl.Location = new System.Drawing.Point(0, 0);
            this.contactPreviewListControl.Name = "contactPreviewListControl";
            this.contactPreviewListControl.Size = new System.Drawing.Size(340, 600);
            this.contactPreviewListControl.TabIndex = 0;
            this.Controls.Add(this.contactPreviewListControl);
        }

        private void ContactBookForm_Closing(object sender, FormClosingEventArgs e)
        {
            this.contactController.SaveContacts();
        }
    }
}
