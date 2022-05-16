namespace ContactsMVC.View
{
    partial class ContactViewForm
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
            this.contactEditModeControl = new ContactsMVC.View.Controls.ContactEditModeControl();
            this.SuspendLayout();
            // 
            // contactEditModeControl
            // 
            this.contactEditModeControl.Location = new System.Drawing.Point(13, 13);
            this.contactEditModeControl.Name = "contactEditModeControl";
            this.contactEditModeControl.Size = new System.Drawing.Size(418, 309);
            this.contactEditModeControl.TabIndex = 0;
            // 
            // ContactViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 334);
            this.Controls.Add(this.contactEditModeControl);
            this.Name = "ContactViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ContactEditModeControl contactEditModeControl;
    }
}