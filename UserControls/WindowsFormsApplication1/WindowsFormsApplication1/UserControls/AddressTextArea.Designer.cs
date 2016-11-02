namespace WindowsFormsApplication1.UserControls
{
    partial class AddressTextArea
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
            this.txtFirstName = new Telerik.WinControls.UI.RadTextBox();
            this.txtLastName = new Telerik.WinControls.UI.RadTextBox();
            this.txtDivision = new Telerik.WinControls.UI.RadTextBox();
            this.txtAddress1 = new Telerik.WinControls.UI.RadTextBox();
            this.txtAddress2 = new Telerik.WinControls.UI.RadTextBox();
            this.txtCity = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(3, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.NullText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(272, 35);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(3, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.NullText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(272, 35);
            this.txtLastName.TabIndex = 1;
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(3, 139);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.NullText = "Division";
            this.txtDivision.Size = new System.Drawing.Size(272, 35);
            this.txtDivision.TabIndex = 2;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(3, 189);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.NullText = "Address Line 1";
            this.txtAddress1.Size = new System.Drawing.Size(272, 35);
            this.txtAddress1.TabIndex = 3;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(3, 247);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.NullText = "Address Line 2";
            this.txtAddress2.Size = new System.Drawing.Size(272, 35);
            this.txtAddress2.TabIndex = 4;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(3, 319);
            this.txtCity.Name = "txtCity";
            this.txtCity.NullText = "City";
            this.txtCity.Size = new System.Drawing.Size(272, 35);
            this.txtCity.TabIndex = 5;
            // 
            // AddressTextArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "AddressTextArea";
            this.Size = new System.Drawing.Size(479, 624);
            ((System.ComponentModel.ISupportInitialize)(this.txtFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtFirstName;
        private Telerik.WinControls.UI.RadTextBox txtLastName;
        private Telerik.WinControls.UI.RadTextBox txtDivision;
        private Telerik.WinControls.UI.RadTextBox txtAddress1;
        private Telerik.WinControls.UI.RadTextBox txtAddress2;
        private Telerik.WinControls.UI.RadTextBox txtCity;
    }
}
