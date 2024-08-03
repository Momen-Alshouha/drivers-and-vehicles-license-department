namespace DVLD.Presentation.Licenses
{
    partial class FrmLicenseInfoDetails
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
            this.BtnLicenseDetailsFrmClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctrlLicenseInfo1 = new DVLD.Presentation.Controls.CtrlLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLicenseDetailsFrmClose
            // 
            this.BtnLicenseDetailsFrmClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLicenseDetailsFrmClose.Location = new System.Drawing.Point(980, 718);
            this.BtnLicenseDetailsFrmClose.Name = "BtnLicenseDetailsFrmClose";
            this.BtnLicenseDetailsFrmClose.Size = new System.Drawing.Size(136, 72);
            this.BtnLicenseDetailsFrmClose.TabIndex = 1;
            this.BtnLicenseDetailsFrmClose.Text = "Close";
            this.BtnLicenseDetailsFrmClose.UseVisualStyleBackColor = true;
            this.BtnLicenseDetailsFrmClose.Click += new System.EventHandler(this.BtnLicenseDetailsFrmClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(373, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Driver License Info ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(12, 162);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(1104, 550);
            this.ctrlLicenseInfo1.TabIndex = 4;
            // 
            // FrmLicenseInfoDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1128, 802);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLicenseDetailsFrmClose);
            this.Name = "FrmLicenseInfoDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License Details";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLicenseDetailsFrmClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Controls.CtrlLicenseInfo ctrlLicenseInfo1;
    }
}