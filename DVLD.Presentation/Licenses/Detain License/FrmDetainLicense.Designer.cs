namespace DVLD.Presentation.Licenses.Detain_License
{
    partial class FrmDetainLicense
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
            this.ctrlLicenseInfoDetailsWithFilter1 = new DVLD.Presentation.Controls.CtrlLicenseInfoDetailsWithFilter();
            this.LblDetainLicenseFrmTitle = new System.Windows.Forms.Label();
            this.LblFineFeesDetainLicenseFrm = new System.Windows.Forms.Label();
            this.textBoxFineFeesDetainLicenseFrm = new System.Windows.Forms.TextBox();
            this.BtnCloseDetainLicenseFrm = new System.Windows.Forms.Button();
            this.BtnDetainLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlLicenseInfoDetailsWithFilter1
            // 
            this.ctrlLicenseInfoDetailsWithFilter1.Location = new System.Drawing.Point(12, 85);
            this.ctrlLicenseInfoDetailsWithFilter1.Name = "ctrlLicenseInfoDetailsWithFilter1";
            this.ctrlLicenseInfoDetailsWithFilter1.Size = new System.Drawing.Size(1083, 474);
            this.ctrlLicenseInfoDetailsWithFilter1.TabIndex = 0;
            // 
            // LblDetainLicenseFrmTitle
            // 
            this.LblDetainLicenseFrmTitle.AutoSize = true;
            this.LblDetainLicenseFrmTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDetainLicenseFrmTitle.ForeColor = System.Drawing.Color.Brown;
            this.LblDetainLicenseFrmTitle.Location = new System.Drawing.Point(465, 26);
            this.LblDetainLicenseFrmTitle.Name = "LblDetainLicenseFrmTitle";
            this.LblDetainLicenseFrmTitle.Size = new System.Drawing.Size(233, 43);
            this.LblDetainLicenseFrmTitle.TabIndex = 1;
            this.LblDetainLicenseFrmTitle.Text = "Detain License";
            // 
            // LblFineFeesDetainLicenseFrm
            // 
            this.LblFineFeesDetainLicenseFrm.AutoSize = true;
            this.LblFineFeesDetainLicenseFrm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFineFeesDetainLicenseFrm.ForeColor = System.Drawing.Color.Brown;
            this.LblFineFeesDetainLicenseFrm.Location = new System.Drawing.Point(12, 583);
            this.LblFineFeesDetainLicenseFrm.Name = "LblFineFeesDetainLicenseFrm";
            this.LblFineFeesDetainLicenseFrm.Size = new System.Drawing.Size(153, 37);
            this.LblFineFeesDetainLicenseFrm.TabIndex = 2;
            this.LblFineFeesDetainLicenseFrm.Text = "Fine Fees :";
            // 
            // textBoxFineFeesDetainLicenseFrm
            // 
            this.textBoxFineFeesDetainLicenseFrm.Location = new System.Drawing.Point(171, 590);
            this.textBoxFineFeesDetainLicenseFrm.Name = "textBoxFineFeesDetainLicenseFrm";
            this.textBoxFineFeesDetainLicenseFrm.Size = new System.Drawing.Size(100, 27);
            this.textBoxFineFeesDetainLicenseFrm.TabIndex = 3;
            this.textBoxFineFeesDetainLicenseFrm.TextChanged += new System.EventHandler(this.textBoxFineFeesDetainLicenseFrm_TextChanged);
            this.textBoxFineFeesDetainLicenseFrm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFineFeesDetainLicenseFrm_KeyPress);
            // 
            // BtnCloseDetainLicenseFrm
            // 
            this.BtnCloseDetainLicenseFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseDetainLicenseFrm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BtnCloseDetainLicenseFrm.Location = new System.Drawing.Point(953, 574);
            this.BtnCloseDetainLicenseFrm.Name = "BtnCloseDetainLicenseFrm";
            this.BtnCloseDetainLicenseFrm.Size = new System.Drawing.Size(126, 64);
            this.BtnCloseDetainLicenseFrm.TabIndex = 4;
            this.BtnCloseDetainLicenseFrm.Text = "Close";
            this.BtnCloseDetainLicenseFrm.UseVisualStyleBackColor = true;
            this.BtnCloseDetainLicenseFrm.Click += new System.EventHandler(this.BtnCloseDetainLicenseFrm_Click);
            // 
            // BtnDetainLicense
            // 
            this.BtnDetainLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDetainLicense.Enabled = false;
            this.BtnDetainLicense.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.BtnDetainLicense.Location = new System.Drawing.Point(821, 574);
            this.BtnDetainLicense.Name = "BtnDetainLicense";
            this.BtnDetainLicense.Size = new System.Drawing.Size(126, 64);
            this.BtnDetainLicense.TabIndex = 5;
            this.BtnDetainLicense.Text = "Detain";
            this.BtnDetainLicense.UseVisualStyleBackColor = true;
            this.BtnDetainLicense.Click += new System.EventHandler(this.BtnDetainLicense_Click);
            // 
            // FrmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1120, 666);
            this.Controls.Add(this.BtnDetainLicense);
            this.Controls.Add(this.BtnCloseDetainLicenseFrm);
            this.Controls.Add(this.textBoxFineFeesDetainLicenseFrm);
            this.Controls.Add(this.LblFineFeesDetainLicenseFrm);
            this.Controls.Add(this.LblDetainLicenseFrmTitle);
            this.Controls.Add(this.ctrlLicenseInfoDetailsWithFilter1);
            this.Name = "FrmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detain License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlLicenseInfoDetailsWithFilter ctrlLicenseInfoDetailsWithFilter1;
        private System.Windows.Forms.Label LblDetainLicenseFrmTitle;
        private System.Windows.Forms.Label LblFineFeesDetainLicenseFrm;
        private System.Windows.Forms.TextBox textBoxFineFeesDetainLicenseFrm;
        private System.Windows.Forms.Button BtnCloseDetainLicenseFrm;
        private System.Windows.Forms.Button BtnDetainLicense;
    }
}