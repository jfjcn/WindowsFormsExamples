namespace WindowsFormsApplication1.UserControls
{
    partial class ChkLabelTextbox
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
            this.txtTextbox = new Telerik.WinControls.UI.RadTextBox();
            this.chkCheckbox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.txtTextbox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTextbox
            // 
            this.txtTextbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTextbox.Location = new System.Drawing.Point(159, 3);
            this.txtTextbox.Name = "txtTextbox";
            this.txtTextbox.NullText = "Add details here";
            this.txtTextbox.Size = new System.Drawing.Size(214, 35);
            this.txtTextbox.TabIndex = 0;
            // 
            // chkCheckbox
            // 
            this.chkCheckbox.AutoSize = true;
            this.chkCheckbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkCheckbox.Location = new System.Drawing.Point(3, 3);
            this.chkCheckbox.Name = "chkCheckbox";
            this.chkCheckbox.Size = new System.Drawing.Size(150, 35);
            this.chkCheckbox.TabIndex = 1;
            this.chkCheckbox.Text = "checkBox1";
            this.chkCheckbox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.chkCheckbox);
            this.flowLayoutPanel1.Controls.Add(this.txtTextbox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 45);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ChkLabelTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ChkLabelTextbox";
            this.Size = new System.Drawing.Size(524, 45);
            ((System.ComponentModel.ISupportInitialize)(this.txtTextbox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtTextbox;
        private System.Windows.Forms.CheckBox chkCheckbox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
