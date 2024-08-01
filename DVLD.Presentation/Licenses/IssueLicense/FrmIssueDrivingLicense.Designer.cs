namespace DVLD.Presentation.Licenses.IssueLicense
{
    partial class FrmIssueDrivingLicense
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
            this.ctrlLocalDrivingLicenseApplication1 = new DVLD.Presentation.Controls.CtrlLocalDrivingLicenseApplication();
            this.RichTextLicenseNotesForm = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIssueLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseApplication1
            // 
            this.ctrlLocalDrivingLicenseApplication1.Location = new System.Drawing.Point(12, 10);
            this.ctrlLocalDrivingLicenseApplication1.Name = "ctrlLocalDrivingLicenseApplication1";
            this.ctrlLocalDrivingLicenseApplication1.Size = new System.Drawing.Size(722, 450);
            this.ctrlLocalDrivingLicenseApplication1.TabIndex = 0;
            // 
            // RichTextLicenseNotesForm
            // 
            this.RichTextLicenseNotesForm.Location = new System.Drawing.Point(12, 502);
            this.RichTextLicenseNotesForm.Name = "RichTextLicenseNotesForm";
            this.RichTextLicenseNotesForm.Size = new System.Drawing.Size(722, 158);
            this.RichTextLicenseNotesForm.TabIndex = 1;
            this.RichTextLicenseNotesForm.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes : ";
            // 
            // BtnIssueLicense
            // 
            this.BtnIssueLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIssueLicense.Location = new System.Drawing.Point(594, 666);
            this.BtnIssueLicense.Name = "BtnIssueLicense";
            this.BtnIssueLicense.Size = new System.Drawing.Size(140, 53);
            this.BtnIssueLicense.TabIndex = 3;
            this.BtnIssueLicense.Text = "Issue License";
            this.BtnIssueLicense.UseVisualStyleBackColor = true;
            this.BtnIssueLicense.Click += new System.EventHandler(this.BtnIssueLicense_Click);
            // 
            // FrmIssueDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(752, 731);
            this.Controls.Add(this.BtnIssueLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RichTextLicenseNotesForm);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplication1);
            this.Name = "FrmIssueDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmIssueDrivingLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlLocalDrivingLicenseApplication ctrlLocalDrivingLicenseApplication1;
        private System.Windows.Forms.RichTextBox RichTextLicenseNotesForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIssueLicense;
    }
}