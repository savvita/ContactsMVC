using ContactsMVC.Controller;
using System.Windows.Forms;

namespace ContactsMVC.View
{
    partial class ContactsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactsLabel = new System.Windows.Forms.Label();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contactsLabel
            // 
            this.contactsLabel.AutoSize = true;
            this.contactsLabel.Location = new System.Drawing.Point(13, 13);
            this.contactsLabel.Name = "contactsLabel";
            this.contactsLabel.Size = new System.Drawing.Size(73, 13);
            this.contactsLabel.TabIndex = 0;
            this.contactsLabel.Text = "Your contacts";
            // 
            // contactsListBox
            // 
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.Location = new System.Drawing.Point(16, 39);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(263, 264);
            this.contactsListBox.TabIndex = 1;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 338);
            this.Controls.Add(this.contactsListBox);
            this.Controls.Add(this.contactsLabel);
            this.Name = "ContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label contactsLabel;
        private System.Windows.Forms.ListBox contactsListBox;

        private ContactController contactController;
        private BindingSource bindingSource;
    }
}