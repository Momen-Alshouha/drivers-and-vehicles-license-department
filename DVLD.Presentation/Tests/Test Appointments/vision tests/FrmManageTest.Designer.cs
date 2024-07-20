namespace DVLD.Presentation.Tests.Test_Appointments
{
    partial class FrmManageTest
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
            this.LblManageTestAppointmentsFrmTitle = new System.Windows.Forms.Label();
            this.DataGridViewTestVisionAppointments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBoxAddTestAppointment = new System.Windows.Forms.PictureBox();
            this.BtnCloseManageVisionTestAppointmentForm = new System.Windows.Forms.Button();
            this.ctrlLocalDrivingLicenseApplication1 = new DVLD.Presentation.Controls.CtrlLocalDrivingLicenseApplication();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTestVisionAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddTestAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // LblManageTestAppointmentsFrmTitle
            // 
            this.LblManageTestAppointmentsFrmTitle.AutoSize = true;
            this.LblManageTestAppointmentsFrmTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManageTestAppointmentsFrmTitle.Location = new System.Drawing.Point(162, 36);
            this.LblManageTestAppointmentsFrmTitle.Name = "LblManageTestAppointmentsFrmTitle";
            this.LblManageTestAppointmentsFrmTitle.Size = new System.Drawing.Size(409, 39);
            this.LblManageTestAppointmentsFrmTitle.TabIndex = 1;
            this.LblManageTestAppointmentsFrmTitle.Text = "Vision Test Appointment";
            // 
            // DataGridViewTestVisionAppointments
            // 
            this.DataGridViewTestVisionAppointments.AllowUserToAddRows = false;
            this.DataGridViewTestVisionAppointments.AllowUserToDeleteRows = false;
            this.DataGridViewTestVisionAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTestVisionAppointments.Location = new System.Drawing.Point(12, 621);
            this.DataGridViewTestVisionAppointments.MultiSelect = false;
            this.DataGridViewTestVisionAppointments.Name = "DataGridViewTestVisionAppointments";
            this.DataGridViewTestVisionAppointments.ReadOnly = true;
            this.DataGridViewTestVisionAppointments.RowHeadersWidth = 62;
            this.DataGridViewTestVisionAppointments.RowTemplate.Height = 29;
            this.DataGridViewTestVisionAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTestVisionAppointments.Size = new System.Drawing.Size(728, 150);
            this.DataGridViewTestVisionAppointments.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Appointments:";
            // 
            // PictureBoxAddTestAppointment
            // 
            this.PictureBoxAddTestAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxAddTestAppointment.Image = global::DVLD.Presentation.Properties.Resources.AddAppointment_32;
            this.PictureBoxAddTestAppointment.Location = new System.Drawing.Point(696, 584);
            this.PictureBoxAddTestAppointment.Name = "PictureBoxAddTestAppointment";
            this.PictureBoxAddTestAppointment.Size = new System.Drawing.Size(38, 34);
            this.PictureBoxAddTestAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxAddTestAppointment.TabIndex = 4;
            this.PictureBoxAddTestAppointment.TabStop = false;
            this.PictureBoxAddTestAppointment.Click += new System.EventHandler(this.PictureBoxAddTestAppointment_Click);
            // 
            // BtnCloseManageVisionTestAppointmentForm
            // 
            this.BtnCloseManageVisionTestAppointmentForm.Location = new System.Drawing.Point(593, 797);
            this.BtnCloseManageVisionTestAppointmentForm.Name = "BtnCloseManageVisionTestAppointmentForm";
            this.BtnCloseManageVisionTestAppointmentForm.Size = new System.Drawing.Size(141, 53);
            this.BtnCloseManageVisionTestAppointmentForm.TabIndex = 5;
            this.BtnCloseManageVisionTestAppointmentForm.Text = "Close";
            this.BtnCloseManageVisionTestAppointmentForm.UseVisualStyleBackColor = true;
            this.BtnCloseManageVisionTestAppointmentForm.Click += new System.EventHandler(this.BtnCloseManageVisionTestAppointmentForm_Click);
            // 
            // ctrlLocalDrivingLicenseApplication1
            // 
            this.ctrlLocalDrivingLicenseApplication1.Location = new System.Drawing.Point(12, 130);
            this.ctrlLocalDrivingLicenseApplication1.Name = "ctrlLocalDrivingLicenseApplication1";
            this.ctrlLocalDrivingLicenseApplication1.Size = new System.Drawing.Size(722, 450);
            this.ctrlLocalDrivingLicenseApplication1.TabIndex = 0;
            // 
            // FrmManageTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(752, 879);
            this.Controls.Add(this.BtnCloseManageVisionTestAppointmentForm);
            this.Controls.Add(this.PictureBoxAddTestAppointment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DataGridViewTestVisionAppointments);
            this.Controls.Add(this.LblManageTestAppointmentsFrmTitle);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplication1);
            this.Name = "FrmManageTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Vision Test Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTestVisionAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddTestAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlLocalDrivingLicenseApplication ctrlLocalDrivingLicenseApplication1;
        private System.Windows.Forms.Label LblManageTestAppointmentsFrmTitle;
        private System.Windows.Forms.DataGridView DataGridViewTestVisionAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureBoxAddTestAppointment;
        private System.Windows.Forms.Button BtnCloseManageVisionTestAppointmentForm;
    }
}