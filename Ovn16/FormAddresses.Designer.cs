namespace Ovn16
{
    partial class FormAddresses
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
            this.streetNameTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.addressTypeTextBox = new System.Windows.Forms.TextBox();
            this.typeAddressBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // streetNameTextBox
            // 
            this.streetNameTextBox.Location = new System.Drawing.Point(13, 36);
            this.streetNameTextBox.Name = "streetNameTextBox";
            this.streetNameTextBox.Size = new System.Drawing.Size(191, 22);
            this.streetNameTextBox.TabIndex = 0;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(13, 13);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(46, 17);
            this.streetLabel.TabIndex = 1;
            this.streetLabel.Text = "Street";
            // 
            // addressTypeTextBox
            // 
            this.addressTypeTextBox.Location = new System.Drawing.Point(13, 101);
            this.addressTypeTextBox.Name = "addressTypeTextBox";
            this.addressTypeTextBox.Size = new System.Drawing.Size(191, 22);
            this.addressTypeTextBox.TabIndex = 2;
            // 
            // typeAddressBox
            // 
            this.typeAddressBox.AutoSize = true;
            this.typeAddressBox.Location = new System.Drawing.Point(14, 78);
            this.typeAddressBox.Name = "typeAddressBox";
            this.typeAddressBox.Size = new System.Drawing.Size(40, 17);
            this.typeAddressBox.TabIndex = 3;
            this.typeAddressBox.Text = "Type";
            // 
            // FormAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 283);
            this.Controls.Add(this.typeAddressBox);
            this.Controls.Add(this.addressTypeTextBox);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.streetNameTextBox);
            this.Name = "FormAddresses";
            this.Text = "FormAddresses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox streetNameTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox addressTypeTextBox;
        private System.Windows.Forms.Label typeAddressBox;
    }
}