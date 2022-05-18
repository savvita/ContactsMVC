namespace ContactsMVC.View.Controls
{
    partial class ContactPreviewListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.contactsPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.contactImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchTextBox.Location = new System.Drawing.Point(14, 257);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(270, 20);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // contactsPanel
            // 
            this.contactsPanel.AutoScroll = true;
            this.contactsPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contactsPanel.Location = new System.Drawing.Point(13, 283);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(297, 204);
            this.contactsPanel.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(47, 220);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(204, 23);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BackgroundImage = global::ContactsMVC.Properties.Resources.Trash;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Location = new System.Drawing.Point(3, 493);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(45, 45);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BackgroundImage = global::ContactsMVC.Properties.Resources.Add;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Location = new System.Drawing.Point(54, 493);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(45, 45);
            this.addButton.TabIndex = 4;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // contactImage
            // 
            this.contactImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactImage.Location = new System.Drawing.Point(47, 13);
            this.contactImage.Name = "contactImage";
            this.contactImage.Size = new System.Drawing.Size(204, 204);
            this.contactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contactImage.TabIndex = 2;
            this.contactImage.TabStop = false;
            // 
            // ContactPreviewListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.contactImage);
            this.Controls.Add(this.contactsPanel);
            this.Controls.Add(this.searchTextBox);
            this.Name = "ContactPreviewListControl";
            this.Size = new System.Drawing.Size(326, 549);
            this.Load += new System.EventHandler(this.ContactPreviewListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel contactsPanel;
        private System.Windows.Forms.PictureBox contactImage;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
