namespace DVLD.Presentation.Controls
{
    partial class CtrlLicenseInfoDetailsWithFilter
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
            this.ctrlLicenseInfo1 = new DVLD.Presentation.Controls.CtrlLicenseInfo();
            this.groupBoxLicenseInfoCtrlFilter = new System.Windows.Forms.GroupBox();
            this.lblFilterLicenseID = new System.Windows.Forms.Label();
            this.textBoxLicenseIDFilterValue = new System.Windows.Forms.TextBox();
            this.pictureBoxSearchFilterLicenseID = new System.Windows.Forms.PictureBox();
            this.groupBoxLicenseInfoCtrlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchFilterLicenseID)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlLicenseInfo1
            // 
            this.ctrlLicenseInfo1.Location = new System.Drawing.Point(3, 115);
            this.ctrlLicenseInfo1.Name = "ctrlLicenseInfo1";
            this.ctrlLicenseInfo1.Size = new System.Drawing.Size(1071, 542);
            this.ctrlLicenseInfo1.TabIndex = 0;
            // 
            // groupBoxLicenseInfoCtrlFilter
            // 
            this.groupBoxLicenseInfoCtrlFilter.Controls.Add(this.pictureBoxSearchFilterLicenseID);
            this.groupBoxLicenseInfoCtrlFilter.Controls.Add(this.textBoxLicenseIDFilterValue);
            this.groupBoxLicenseInfoCtrlFilter.Controls.Add(this.lblFilterLicenseID);
            this.groupBoxLicenseInfoCtrlFilter.Location = new System.Drawing.Point(3, 9);
            this.groupBoxLicenseInfoCtrlFilter.Name = "groupBoxLicenseInfoCtrlFilter";
            this.groupBoxLicenseInfoCtrlFilter.Size = new System.Drawing.Size(714, 100);
            this.groupBoxLicenseInfoCtrlFilter.TabIndex = 1;
            this.groupBoxLicenseInfoCtrlFilter.TabStop = false;
            this.groupBoxLicenseInfoCtrlFilter.Text = "Filter";
            // 
            // lblFilterLicenseID
            // 
            this.lblFilterLicenseID.AutoSize = true;
            this.lblFilterLicenseID.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblFilterLicenseID.Location = new System.Drawing.Point(6, 36);
            this.lblFilterLicenseID.Name = "lblFilterLicenseID";
            this.lblFilterLicenseID.Size = new System.Drawing.Size(173, 36);
            this.lblFilterLicenseID.TabIndex = 0;
            this.lblFilterLicenseID.Text = "License ID :";
            // 
            // textBoxLicenseIDFilterValue
            // 
            this.textBoxLicenseIDFilterValue.Location = new System.Drawing.Point(185, 45);
            this.textBoxLicenseIDFilterValue.Name = "textBoxLicenseIDFilterValue";
            this.textBoxLicenseIDFilterValue.Size = new System.Drawing.Size(128, 27);
            this.textBoxLicenseIDFilterValue.TabIndex = 1;
            // 
            // pictureBoxSearchFilterLicenseID
            // 
            this.pictureBoxSearchFilterLicenseID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearchFilterLicenseID.Image = global::DVLD.Presentation.Properties.Resources.License_View_322;
            this.pictureBoxSearchFilterLicenseID.Location = new System.Drawing.Point(330, 36);
            this.pictureBoxSearchFilterLicenseID.Name = "pictureBoxSearchFilterLicenseID";
            this.pictureBoxSearchFilterLicenseID.Size = new System.Drawing.Size(65, 40);
            this.pictureBoxSearchFilterLicenseID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearchFilterLicenseID.TabIndex = 2;
            this.pictureBoxSearchFilterLicenseID.TabStop = false;
            this.pictureBoxSearchFilterLicenseID.Click += new System.EventHandler(this.pictureBoxSearchFilterLicenseID_Click);
            // 
            // CtrlLicenseInfoDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxLicenseInfoCtrlFilter);
            this.Controls.Add(this.ctrlLicenseInfo1);
            this.Name = "CtrlLicenseInfoDetailsWithFilter";
            this.Size = new System.Drawing.Size(1083, 669);
            this.groupBoxLicenseInfoCtrlFilter.ResumeLayout(false);
            this.groupBoxLicenseInfoCtrlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchFilterLicenseID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlLicenseInfo ctrlLicenseInfo1;
        private System.Windows.Forms.GroupBox groupBoxLicenseInfoCtrlFilter;
        private System.Windows.Forms.Label lblFilterLicenseID;
        private System.Windows.Forms.TextBox textBoxLicenseIDFilterValue;
        private System.Windows.Forms.PictureBox pictureBoxSearchFilterLicenseID;
    }
}
