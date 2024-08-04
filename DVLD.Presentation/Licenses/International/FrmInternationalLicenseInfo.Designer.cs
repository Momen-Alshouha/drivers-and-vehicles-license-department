namespace DVLD.Presentation.Licenses.International
{
    partial class FrmInternationalLicenseInfo
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
            this.BtnCloseInternationalLicenseInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ctrlInternationalLicenseInfo1 = new DVLD.Presentation.Controls.CtrlInternationalLicenseInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCloseInternationalLicenseInfo
            // 
            this.BtnCloseInternationalLicenseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseInternationalLicenseInfo.Location = new System.Drawing.Point(849, 512);
            this.BtnCloseInternationalLicenseInfo.Name = "BtnCloseInternationalLicenseInfo";
            this.BtnCloseInternationalLicenseInfo.Size = new System.Drawing.Size(119, 59);
            this.BtnCloseInternationalLicenseInfo.TabIndex = 1;
            this.BtnCloseInternationalLicenseInfo.Text = "Close";
            this.BtnCloseInternationalLicenseInfo.UseVisualStyleBackColor = true;
            this.BtnCloseInternationalLicenseInfo.Click += new System.EventHandler(this.BtnCloseInternationalLicenseInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(246, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Driver International License Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(88, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Presentation.Properties.Resources.International_32;
            this.pictureBox2.Location = new System.Drawing.Point(233, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // ctrlInternationalLicenseInfo1
            // 
            this.ctrlInternationalLicenseInfo1.Location = new System.Drawing.Point(12, 181);
            this.ctrlInternationalLicenseInfo1.Name = "ctrlInternationalLicenseInfo1";
            this.ctrlInternationalLicenseInfo1.Size = new System.Drawing.Size(956, 325);
            this.ctrlInternationalLicenseInfo1.TabIndex = 0;
            // 
            // FrmInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(986, 582);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCloseInternationalLicenseInfo);
            this.Controls.Add(this.ctrlInternationalLicenseInfo1);
            this.Name = "FrmInternationalLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Driver International License Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlInternationalLicenseInfo ctrlInternationalLicenseInfo1;
        private System.Windows.Forms.Button BtnCloseInternationalLicenseInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}