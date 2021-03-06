using System.Collections.Generic;

namespace ContactsMVC.View.Controls
{
    partial class ContactControl
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTetxBox = new System.Windows.Forms.TextBox();
            this.addressGroupBox = new System.Windows.Forms.GroupBox();
            this.appartmentTextBox = new System.Windows.Forms.TextBox();
            this.appartmentLabel = new System.Windows.Forms.Label();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.houseLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.cellphonesGroupBox = new System.Windows.Forms.GroupBox();
            this.addressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(13, 17);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.firstNameTextBox.Location = new System.Drawing.Point(78, 9);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(136, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 48);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last name:";
            // 
            // lastNameTetxBox
            // 
            this.lastNameTetxBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lastNameTetxBox.Location = new System.Drawing.Point(78, 45);
            this.lastNameTetxBox.Name = "lastNameTetxBox";
            this.lastNameTetxBox.Size = new System.Drawing.Size(136, 20);
            this.lastNameTetxBox.TabIndex = 3;
            // 
            // addressGroupBox
            // 
            this.addressGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addressGroupBox.Controls.Add(this.appartmentTextBox);
            this.addressGroupBox.Controls.Add(this.appartmentLabel);
            this.addressGroupBox.Controls.Add(this.houseTextBox);
            this.addressGroupBox.Controls.Add(this.houseLabel);
            this.addressGroupBox.Controls.Add(this.streetTextBox);
            this.addressGroupBox.Controls.Add(this.streetLabel);
            this.addressGroupBox.Controls.Add(this.cityTextBox);
            this.addressGroupBox.Controls.Add(this.cityLabel);
            this.addressGroupBox.Controls.Add(this.countryTextBox);
            this.addressGroupBox.Controls.Add(this.countryLabel);
            this.addressGroupBox.Location = new System.Drawing.Point(6, 135);
            this.addressGroupBox.Name = "addressGroupBox";
            this.addressGroupBox.Size = new System.Drawing.Size(208, 166);
            this.addressGroupBox.TabIndex = 4;
            this.addressGroupBox.TabStop = false;
            this.addressGroupBox.Text = "Address";
            // 
            // appartmentTextBox
            // 
            this.appartmentTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appartmentTextBox.Location = new System.Drawing.Point(74, 133);
            this.appartmentTextBox.Name = "appartmentTextBox";
            this.appartmentTextBox.Size = new System.Drawing.Size(117, 20);
            this.appartmentTextBox.TabIndex = 9;
            // 
            // appartmentLabel
            // 
            this.appartmentLabel.AutoSize = true;
            this.appartmentLabel.Location = new System.Drawing.Point(7, 136);
            this.appartmentLabel.Name = "appartmentLabel";
            this.appartmentLabel.Size = new System.Drawing.Size(64, 13);
            this.appartmentLabel.TabIndex = 8;
            this.appartmentLabel.Text = "Appartment:";
            // 
            // houseTextBox
            // 
            this.houseTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.houseTextBox.Location = new System.Drawing.Point(74, 105);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(117, 20);
            this.houseTextBox.TabIndex = 7;
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Location = new System.Drawing.Point(7, 108);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(41, 13);
            this.houseLabel.TabIndex = 6;
            this.houseLabel.Text = "House:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.streetTextBox.Location = new System.Drawing.Point(74, 77);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(117, 20);
            this.streetTextBox.TabIndex = 5;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(7, 80);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 4;
            this.streetLabel.Text = "Street:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cityTextBox.Location = new System.Drawing.Point(74, 49);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(117, 20);
            this.cityTextBox.TabIndex = 3;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(7, 52);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.countryTextBox.Location = new System.Drawing.Point(74, 21);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(117, 20);
            this.countryTextBox.TabIndex = 1;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(7, 24);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(46, 13);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.Text = "Country:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox.Location = new System.Drawing.Point(264, 9);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(119, 102);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // addImageButton
            // 
            this.addImageButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addImageButton.Location = new System.Drawing.Point(286, 117);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(75, 23);
            this.addImageButton.TabIndex = 6;
            this.addImageButton.Text = "Add image";
            this.addImageButton.UseVisualStyleBackColor = false;
            this.addImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // cellphonesGroupBox
            // 
            this.cellphonesGroupBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cellphonesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cellphonesGroupBox.Location = new System.Drawing.Point(242, 150);
            this.cellphonesGroupBox.Name = "cellphonesGroupBox";
            this.cellphonesGroupBox.Size = new System.Drawing.Size(163, 151);
            this.cellphonesGroupBox.TabIndex = 7;
            this.cellphonesGroupBox.TabStop = false;
            this.cellphonesGroupBox.Text = "Cellphones";
            // 
            // ContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.cellphonesGroupBox);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.addressGroupBox);
            this.Controls.Add(this.lastNameTetxBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "ContactControl";
            this.Size = new System.Drawing.Size(416, 309);
            this.addressGroupBox.ResumeLayout(false);
            this.addressGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTetxBox;
        private System.Windows.Forms.GroupBox addressGroupBox;
        private System.Windows.Forms.TextBox appartmentTextBox;
        private System.Windows.Forms.Label appartmentLabel;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.GroupBox cellphonesGroupBox;
        private List<System.Windows.Forms.TextBox> cellphonesTextBox;

        private string imageFile;
    }
}
