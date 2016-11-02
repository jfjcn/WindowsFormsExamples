namespace WindowsFormsApplication1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblClientContact = new System.Windows.Forms.Label();
            this.addrClientContact = new WindowsFormsApplication1.UserControls.AddressTextArea();
            this.cltDiscreteChoice = new WindowsFormsApplication1.UserControls.ChkLabelTextbox();
            this.cltMarketDriverModeling = new WindowsFormsApplication1.UserControls.ChkLabelTextbox();
            this.lblResearchMethodologyDesign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1021, 876);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 67);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblClientContact
            // 
            this.lblClientContact.AutoSize = true;
            this.lblClientContact.Location = new System.Drawing.Point(38, 57);
            this.lblClientContact.Name = "lblClientContact";
            this.lblClientContact.Size = new System.Drawing.Size(153, 25);
            this.lblClientContact.TabIndex = 2;
            this.lblClientContact.Text = "Client Contact:";
            // 
            // addrClientContact
            // 
            this.addrClientContact.Location = new System.Drawing.Point(38, 82);
            this.addrClientContact.Name = "addrClientContact";
            this.addrClientContact.Size = new System.Drawing.Size(479, 624);
            this.addrClientContact.TabIndex = 0;
            // 
            // cltDiscreteChoice
            // 
            this.cltDiscreteChoice.Location = new System.Drawing.Point(625, 152);
            this.cltDiscreteChoice.Name = "cltDiscreteChoice";
            this.cltDiscreteChoice.Size = new System.Drawing.Size(524, 45);
            this.cltDiscreteChoice.TabIndex = 3;
            // 
            // cltMarketDriverModeling
            // 
            this.cltMarketDriverModeling.Location = new System.Drawing.Point(625, 217);
            this.cltMarketDriverModeling.Name = "cltMarketDriverModeling";
            this.cltMarketDriverModeling.Size = new System.Drawing.Size(524, 45);
            this.cltMarketDriverModeling.TabIndex = 4;
            // 
            // lblResearchMethodologyDesign
            // 
            this.lblResearchMethodologyDesign.AutoSize = true;
            this.lblResearchMethodologyDesign.Location = new System.Drawing.Point(609, 82);
            this.lblResearchMethodologyDesign.Name = "lblResearchMethodologyDesign";
            this.lblResearchMethodologyDesign.Size = new System.Drawing.Size(161, 25);
            this.lblResearchMethodologyDesign.TabIndex = 5;
            this.lblResearchMethodologyDesign.Text = "Market Science";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 1032);
            this.Controls.Add(this.lblResearchMethodologyDesign);
            this.Controls.Add(this.cltMarketDriverModeling);
            this.Controls.Add(this.cltDiscreteChoice);
            this.Controls.Add(this.lblClientContact);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.addrClientContact);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.AddressTextArea addrClientContact;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblClientContact;
        private UserControls.ChkLabelTextbox cltDiscreteChoice;
        private UserControls.ChkLabelTextbox cltMarketDriverModeling;
        private System.Windows.Forms.Label lblResearchMethodologyDesign;
    }
}

