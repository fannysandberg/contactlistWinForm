namespace Ovn16
{
    partial class Form1
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.socialSecurityNumberBox = new System.Windows.Forms.TextBox();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.socialSecurityLabel = new System.Windows.Forms.Label();
            this.submissionBtn = new System.Windows.Forms.Button();
            this.clearAllFieldsButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addPhoneNumber = new System.Windows.Forms.Button();
            this.phoneNumberListBox = new System.Windows.Forms.ListBox();
            this.addressListBox = new System.Windows.Forms.ListBox();
            this.addressListBoxLabel = new System.Windows.Forms.Label();
            this.phoneListBox = new System.Windows.Forms.ListBox();
            this.phoneListBoxLabel = new System.Windows.Forms.Label();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.updateContactButton = new System.Windows.Forms.Button();
            this.manageAddressButton = new System.Windows.Forms.Button();
            this.deleteNbrFromPhoneListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(13, 12);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(295, 22);
            this.firstNameBox.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(13, 69);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(295, 22);
            this.lastNameBox.TabIndex = 2;
            // 
            // socialSecurityNumberBox
            // 
            this.socialSecurityNumberBox.Location = new System.Drawing.Point(13, 126);
            this.socialSecurityNumberBox.Name = "socialSecurityNumberBox";
            this.socialSecurityNumberBox.Size = new System.Drawing.Size(295, 22);
            this.socialSecurityNumberBox.TabIndex = 3;
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Location = new System.Drawing.Point(13, 37);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(74, 17);
            this.firstNameLable.TabIndex = 4;
            this.firstNameLable.Text = "First name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 94);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(74, 17);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last name";
            // 
            // socialSecurityLabel
            // 
            this.socialSecurityLabel.AutoSize = true;
            this.socialSecurityLabel.Location = new System.Drawing.Point(13, 151);
            this.socialSecurityLabel.Name = "socialSecurityLabel";
            this.socialSecurityLabel.Size = new System.Drawing.Size(250, 17);
            this.socialSecurityLabel.TabIndex = 6;
            this.socialSecurityLabel.Text = "Social Security Number (yymmdd-xxxx)";
            // 
            // submissionBtn
            // 
            this.submissionBtn.Location = new System.Drawing.Point(197, 559);
            this.submissionBtn.Name = "submissionBtn";
            this.submissionBtn.Size = new System.Drawing.Size(116, 24);
            this.submissionBtn.TabIndex = 11;
            this.submissionBtn.Text = "Submit";
            this.submissionBtn.UseVisualStyleBackColor = true;
            this.submissionBtn.Click += new System.EventHandler(this.submissionBtn_Click);
            // 
            // clearAllFieldsButton
            // 
            this.clearAllFieldsButton.Location = new System.Drawing.Point(197, 589);
            this.clearAllFieldsButton.Name = "clearAllFieldsButton";
            this.clearAllFieldsButton.Size = new System.Drawing.Size(116, 29);
            this.clearAllFieldsButton.TabIndex = 12;
            this.clearAllFieldsButton.Text = "Clear All Fields";
            this.clearAllFieldsButton.UseVisualStyleBackColor = true;
            this.clearAllFieldsButton.Click += new System.EventHandler(this.clearAllFieldsButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(197, 659);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(116, 29);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete Contact";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 16;
            this.displayListBox.Location = new System.Drawing.Point(332, 12);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(294, 676);
            this.displayListBox.TabIndex = 14;
            this.displayListBox.SelectedIndexChanged += new System.EventHandler(this.displayListBox_SelectedIndexChanged);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(12, 417);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(109, 22);
            this.phoneBox.TabIndex = 15;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(13, 442);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(49, 17);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Phone";
            // 
            // addPhoneNumber
            // 
            this.addPhoneNumber.Location = new System.Drawing.Point(126, 417);
            this.addPhoneNumber.Name = "addPhoneNumber";
            this.addPhoneNumber.Size = new System.Drawing.Size(51, 23);
            this.addPhoneNumber.TabIndex = 21;
            this.addPhoneNumber.Text = "Add";
            this.addPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addPhoneNumber.UseVisualStyleBackColor = true;
            this.addPhoneNumber.Click += new System.EventHandler(this.addPhoneNumber_Click);
            // 
            // phoneNumberListBox
            // 
            this.phoneNumberListBox.FormattingEnabled = true;
            this.phoneNumberListBox.ItemHeight = 16;
            this.phoneNumberListBox.Location = new System.Drawing.Point(197, 355);
            this.phoneNumberListBox.Name = "phoneNumberListBox";
            this.phoneNumberListBox.Size = new System.Drawing.Size(120, 84);
            this.phoneNumberListBox.TabIndex = 22;
            // 
            // addressListBox
            // 
            this.addressListBox.FormattingEnabled = true;
            this.addressListBox.HorizontalScrollbar = true;
            this.addressListBox.ItemHeight = 16;
            this.addressListBox.Location = new System.Drawing.Point(646, 42);
            this.addressListBox.Name = "addressListBox";
            this.addressListBox.Size = new System.Drawing.Size(196, 196);
            this.addressListBox.TabIndex = 23;
            // 
            // addressListBoxLabel
            // 
            this.addressListBoxLabel.AutoSize = true;
            this.addressListBoxLabel.Location = new System.Drawing.Point(646, 19);
            this.addressListBoxLabel.Name = "addressListBoxLabel";
            this.addressListBoxLabel.Size = new System.Drawing.Size(60, 17);
            this.addressListBoxLabel.TabIndex = 24;
            this.addressListBoxLabel.Text = "Address";
            // 
            // phoneListBox
            // 
            this.phoneListBox.FormattingEnabled = true;
            this.phoneListBox.ItemHeight = 16;
            this.phoneListBox.Location = new System.Drawing.Point(646, 295);
            this.phoneListBox.Name = "phoneListBox";
            this.phoneListBox.Size = new System.Drawing.Size(196, 212);
            this.phoneListBox.TabIndex = 25;
            // 
            // phoneListBoxLabel
            // 
            this.phoneListBoxLabel.AutoSize = true;
            this.phoneListBoxLabel.Location = new System.Drawing.Point(646, 272);
            this.phoneListBoxLabel.Name = "phoneListBoxLabel";
            this.phoneListBoxLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneListBoxLabel.TabIndex = 26;
            this.phoneListBoxLabel.Text = "Phone Number";
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.Location = new System.Drawing.Point(646, 559);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(121, 29);
            this.deleteContactButton.TabIndex = 27;
            this.deleteContactButton.Text = "Delete";
            this.deleteContactButton.UseVisualStyleBackColor = true;
            this.deleteContactButton.Click += new System.EventHandler(this.deleteContactButton_Click);
            // 
            // updateContactButton
            // 
            this.updateContactButton.Location = new System.Drawing.Point(646, 594);
            this.updateContactButton.Name = "updateContactButton";
            this.updateContactButton.Size = new System.Drawing.Size(121, 29);
            this.updateContactButton.TabIndex = 28;
            this.updateContactButton.Text = "Update Contact";
            this.updateContactButton.UseVisualStyleBackColor = true;
            this.updateContactButton.Click += new System.EventHandler(this.updateContactButton_Click);
            // 
            // manageAddressButton
            // 
            this.manageAddressButton.Location = new System.Drawing.Point(197, 184);
            this.manageAddressButton.Name = "manageAddressButton";
            this.manageAddressButton.Size = new System.Drawing.Size(111, 54);
            this.manageAddressButton.TabIndex = 29;
            this.manageAddressButton.Text = "Manage Addresses";
            this.manageAddressButton.UseVisualStyleBackColor = true;
            // 
            // deleteNbrFromPhoneListBox
            // 
            this.deleteNbrFromPhoneListBox.Location = new System.Drawing.Point(197, 442);
            this.deleteNbrFromPhoneListBox.Name = "deleteNbrFromPhoneListBox";
            this.deleteNbrFromPhoneListBox.Size = new System.Drawing.Size(121, 23);
            this.deleteNbrFromPhoneListBox.TabIndex = 30;
            this.deleteNbrFromPhoneListBox.Text = "Delete Number";
            this.deleteNbrFromPhoneListBox.UseVisualStyleBackColor = true;
            this.deleteNbrFromPhoneListBox.Click += new System.EventHandler(this.deleteNbrFromPhoneListBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 693);
            this.Controls.Add(this.deleteNbrFromPhoneListBox);
            this.Controls.Add(this.manageAddressButton);
            this.Controls.Add(this.updateContactButton);
            this.Controls.Add(this.deleteContactButton);
            this.Controls.Add(this.phoneListBoxLabel);
            this.Controls.Add(this.phoneListBox);
            this.Controls.Add(this.addressListBoxLabel);
            this.Controls.Add(this.addressListBox);
            this.Controls.Add(this.phoneNumberListBox);
            this.Controls.Add(this.addPhoneNumber);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearAllFieldsButton);
            this.Controls.Add(this.submissionBtn);
            this.Controls.Add(this.socialSecurityLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLable);
            this.Controls.Add(this.socialSecurityNumberBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox socialSecurityNumberBox;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label socialSecurityLabel;
        private System.Windows.Forms.Button submissionBtn;
        private System.Windows.Forms.Button clearAllFieldsButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button addPhoneNumber;
        private System.Windows.Forms.ListBox phoneNumberListBox;
        private System.Windows.Forms.ListBox addressListBox;
        private System.Windows.Forms.Label addressListBoxLabel;
        private System.Windows.Forms.ListBox phoneListBox;
        private System.Windows.Forms.Label phoneListBoxLabel;
        private System.Windows.Forms.Button deleteContactButton;
        private System.Windows.Forms.Button updateContactButton;
        private System.Windows.Forms.Button manageAddressButton;
        private System.Windows.Forms.Button deleteNbrFromPhoneListBox;
    }
}

