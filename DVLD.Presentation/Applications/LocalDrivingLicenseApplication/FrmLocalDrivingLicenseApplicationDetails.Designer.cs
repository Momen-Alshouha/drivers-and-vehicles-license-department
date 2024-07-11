namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    partial class FrmLocalDrivingLicenseApplicationDetails
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlLocalDrivingLicenseApplication1 = new DVLD.Presentation.Controls.CtrlLocalDrivingLicenseApplication();
            this.LblLDLappTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ctrlLocalDrivingLicenseApplication1
            // 
            this.ctrlLocalDrivingLicenseApplication1.Location = new System.Drawing.Point(12, 78);
            this.ctrlLocalDrivingLicenseApplication1.Name = "ctrlLocalDrivingLicenseApplication1";
            this.ctrlLocalDrivingLicenseApplication1.Size = new System.Drawing.Size(722, 450);
            this.ctrlLocalDrivingLicenseApplication1.TabIndex = 0;
            // 
            // LblLDLappTitle
            // 
            this.LblLDLappTitle.AutoSize = true;
            this.LblLDLappTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLDLappTitle.Location = new System.Drawing.Point(97, 9);
            this.LblLDLappTitle.Name = "LblLDLappTitle";
            this.LblLDLappTitle.Size = new System.Drawing.Size(581, 34);
            this.LblLDLappTitle.TabIndex = 2;
            this.LblLDLappTitle.Text = "Local Driving License Application Details";
            // 
            // FrmLocalDrivingLicenseApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 611);
            this.Controls.Add(this.LblLDLappTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplication1);
            this.Name = "FrmLocalDrivingLicenseApplicationDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlLocalDrivingLicenseApplication ctrlLocalDrivingLicenseApplication1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblLDLappTitle;
    }
}