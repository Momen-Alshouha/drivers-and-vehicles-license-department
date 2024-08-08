namespace DVLD.Presentation.Applications.Renew_Local_Driving_License_Application
{
    partial class FrmRenewLocalDrivingLicenseApplication
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
            this.LblRenewFrmTitle = new System.Windows.Forms.Label();
            this.BtnRenew = new System.Windows.Forms.Button();
            this.BtnCloseRenewForm = new System.Windows.Forms.Button();
            this.ctrlLicenseInfoDetailsWithFilter1 = new DVLD.Presentation.Controls.CtrlLicenseInfoDetailsWithFilter();
            this.ctrlApplicationNewLicenseInfo1 = new DVLD.Presentation.Controls.CtrlApplicationNewLicenseInfo();
            this.SuspendLayout();
            // 
            // LblRenewFrmTitle
            // 
            this.LblRenewFrmTitle.AutoSize = true;
            this.LblRenewFrmTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.LblRenewFrmTitle.ForeColor = System.Drawing.Color.Firebrick;
            this.LblRenewFrmTitle.Location = new System.Drawing.Point(247, 18);
            this.LblRenewFrmTitle.Name = "LblRenewFrmTitle";
            this.LblRenewFrmTitle.Size = new System.Drawing.Size(663, 39);
            this.LblRenewFrmTitle.TabIndex = 1;
            this.LblRenewFrmTitle.Text = "Renew Local Driving License Application";
            // 
            // BtnRenew
            // 
            this.BtnRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRenew.Enabled = false;
            this.BtnRenew.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BtnRenew.Location = new System.Drawing.Point(908, 816);
            this.BtnRenew.Name = "BtnRenew";
            this.BtnRenew.Size = new System.Drawing.Size(164, 47);
            this.BtnRenew.TabIndex = 2;
            this.BtnRenew.Text = "Renew";
            this.BtnRenew.UseVisualStyleBackColor = true;
            this.BtnRenew.Click += new System.EventHandler(this.BtnRenew_Click);
            // 
            // BtnCloseRenewForm
            // 
            this.BtnCloseRenewForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseRenewForm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BtnCloseRenewForm.Location = new System.Drawing.Point(738, 816);
            this.BtnCloseRenewForm.Name = "BtnCloseRenewForm";
            this.BtnCloseRenewForm.Size = new System.Drawing.Size(164, 47);
            this.BtnCloseRenewForm.TabIndex = 3;
            this.BtnCloseRenewForm.Text = "Close";
            this.BtnCloseRenewForm.UseVisualStyleBackColor = true;
            this.BtnCloseRenewForm.Click += new System.EventHandler(this.BtnCloseRenewForm_Click);
            // 
            // ctrlLicenseInfoDetailsWithFilter1
            // 
            this.ctrlLicenseInfoDetailsWithFilter1.Location = new System.Drawing.Point(12, 66);
            this.ctrlLicenseInfoDetailsWithFilter1.Name = "ctrlLicenseInfoDetailsWithFilter1";
            this.ctrlLicenseInfoDetailsWithFilter1.Size = new System.Drawing.Size(1083, 466);
            this.ctrlLicenseInfoDetailsWithFilter1.TabIndex = 4;
            // 
            // ctrlApplicationNewLicenseInfo1
            // 
            this.ctrlApplicationNewLicenseInfo1.Location = new System.Drawing.Point(12, 538);
            this.ctrlApplicationNewLicenseInfo1.Name = "ctrlApplicationNewLicenseInfo1";
            this.ctrlApplicationNewLicenseInfo1.Size = new System.Drawing.Size(720, 344);
            this.ctrlApplicationNewLicenseInfo1.TabIndex = 5;
            // 
            // FrmRenewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1109, 884);
            this.Controls.Add(this.ctrlApplicationNewLicenseInfo1);
            this.Controls.Add(this.ctrlLicenseInfoDetailsWithFilter1);
            this.Controls.Add(this.BtnCloseRenewForm);
            this.Controls.Add(this.BtnRenew);
            this.Controls.Add(this.LblRenewFrmTitle);
            this.Name = "FrmRenewLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renew Local Driving License Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblRenewFrmTitle;
        private System.Windows.Forms.Button BtnRenew;
        private System.Windows.Forms.Button BtnCloseRenewForm;
        private Controls.CtrlLicenseInfoDetailsWithFilter ctrlLicenseInfoDetailsWithFilter1;
        private Controls.CtrlApplicationNewLicenseInfo ctrlApplicationNewLicenseInfo1;
    }
}