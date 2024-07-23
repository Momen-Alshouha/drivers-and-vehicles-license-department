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
            this.components = new System.ComponentModel.Container();
            this.LblManageTestAppointmentsFrmTitle = new System.Windows.Forms.Label();
            this.DataGridViewManageTestAppointments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PictureBoxAddTestAppointment = new System.Windows.Forms.PictureBox();
            this.BtnCloseManageVisionTestAppointmentForm = new System.Windows.Forms.Button();
            this.ContextMenuStripTestAppintments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctrlLocalDrivingLicenseApplication1 = new DVLD.Presentation.Controls.CtrlLocalDrivingLicenseApplication();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewManageTestAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddTestAppointment)).BeginInit();
            this.ContextMenuStripTestAppintments.SuspendLayout();
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
            // DataGridViewManageTestAppointments
            // 
            this.DataGridViewManageTestAppointments.AllowUserToAddRows = false;
            this.DataGridViewManageTestAppointments.AllowUserToDeleteRows = false;
            this.DataGridViewManageTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewManageTestAppointments.Location = new System.Drawing.Point(12, 621);
            this.DataGridViewManageTestAppointments.MultiSelect = false;
            this.DataGridViewManageTestAppointments.Name = "DataGridViewManageTestAppointments";
            this.DataGridViewManageTestAppointments.ReadOnly = true;
            this.DataGridViewManageTestAppointments.RowHeadersWidth = 62;
            this.DataGridViewManageTestAppointments.RowTemplate.Height = 29;
            this.DataGridViewManageTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewManageTestAppointments.Size = new System.Drawing.Size(728, 150);
            this.DataGridViewManageTestAppointments.TabIndex = 2;
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
            this.BtnCloseManageVisionTestAppointmentForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseManageVisionTestAppointmentForm.Location = new System.Drawing.Point(593, 797);
            this.BtnCloseManageVisionTestAppointmentForm.Name = "BtnCloseManageVisionTestAppointmentForm";
            this.BtnCloseManageVisionTestAppointmentForm.Size = new System.Drawing.Size(141, 53);
            this.BtnCloseManageVisionTestAppointmentForm.TabIndex = 5;
            this.BtnCloseManageVisionTestAppointmentForm.Text = "Close";
            this.BtnCloseManageVisionTestAppointmentForm.UseVisualStyleBackColor = true;
            this.BtnCloseManageVisionTestAppointmentForm.Click += new System.EventHandler(this.BtnCloseManageVisionTestAppointmentForm_Click);
            // 
            // ContextMenuStripTestAppintments
            // 
            this.ContextMenuStripTestAppintments.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripTestAppintments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.ContextMenuStripTestAppintments.Name = "contextMenuStrip1";
            this.ContextMenuStripTestAppintments.Size = new System.Drawing.Size(257, 117);
            // 
            // ctrlLocalDrivingLicenseApplication1
            // 
            this.ctrlLocalDrivingLicenseApplication1.Location = new System.Drawing.Point(12, 130);
            this.ctrlLocalDrivingLicenseApplication1.Name = "ctrlLocalDrivingLicenseApplication1";
            this.ctrlLocalDrivingLicenseApplication1.Size = new System.Drawing.Size(722, 450);
            this.ctrlLocalDrivingLicenseApplication1.TabIndex = 0;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(256, 40);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(256, 40);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
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
            this.Controls.Add(this.DataGridViewManageTestAppointments);
            this.Controls.Add(this.LblManageTestAppointmentsFrmTitle);
            this.Controls.Add(this.ctrlLocalDrivingLicenseApplication1);
            this.Name = "FrmManageTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Vision Test Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewManageTestAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddTestAppointment)).EndInit();
            this.ContextMenuStripTestAppintments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlLocalDrivingLicenseApplication ctrlLocalDrivingLicenseApplication1;
        private System.Windows.Forms.Label LblManageTestAppointmentsFrmTitle;
        private System.Windows.Forms.DataGridView DataGridViewManageTestAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PictureBoxAddTestAppointment;
        private System.Windows.Forms.Button BtnCloseManageVisionTestAppointmentForm;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripTestAppintments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}