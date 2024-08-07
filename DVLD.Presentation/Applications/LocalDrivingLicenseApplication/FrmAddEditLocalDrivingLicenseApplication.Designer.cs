﻿namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    partial class FrmAddEditLocalDrivingLicenseApplication
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
            this.LblLocalDrivingLicenseApplicationTitle = new System.Windows.Forms.Label();
            this.TabControlLocalDrivingLicenseApplication = new System.Windows.Forms.TabControl();
            this.TabPageNewLocalLicensePersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonDetailsWithFilter1 = new DVLD.Presentation.People.Controls.CtrlPersonDetailsWithFilter();
            this.BtnBackLocalDrivingLicenseApplicationForm = new System.Windows.Forms.Button();
            this.BtnNextLocalDrivingLicenseApplicationForm = new System.Windows.Forms.Button();
            this.TabPageNewLocalLicenseApplicationInfo = new System.Windows.Forms.TabPage();
            this.LblLblAppIDLocalDrivingLicenseApplicationValue = new System.Windows.Forms.Label();
            this.LblAppIDLocalDrivingLicenseApplicationTitle = new System.Windows.Forms.Label();
            this.LblLocalApplicationCreatedByValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblApplicationDateLocalDrivingLicenseApplication = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm = new System.Windows.Forms.ComboBox();
            this.BtnBack2LocalDrivingLicenseApplicationForm = new System.Windows.Forms.Button();
            this.BtnSavetLocalDrivingLicenseApplicationForm = new System.Windows.Forms.Button();
            this.BtnCloseLocalDrivingLicenseApplicationForm = new System.Windows.Forms.Button();
            this.TabControlLocalDrivingLicenseApplication.SuspendLayout();
            this.TabPageNewLocalLicensePersonalInfo.SuspendLayout();
            this.TabPageNewLocalLicenseApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblLocalDrivingLicenseApplicationTitle
            // 
            this.LblLocalDrivingLicenseApplicationTitle.AutoSize = true;
            this.LblLocalDrivingLicenseApplicationTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalDrivingLicenseApplicationTitle.Location = new System.Drawing.Point(250, 30);
            this.LblLocalDrivingLicenseApplicationTitle.Name = "LblLocalDrivingLicenseApplicationTitle";
            this.LblLocalDrivingLicenseApplicationTitle.Size = new System.Drawing.Size(591, 43);
            this.LblLocalDrivingLicenseApplicationTitle.TabIndex = 0;
            this.LblLocalDrivingLicenseApplicationTitle.Text = "New Local Driving License Application";
            // 
            // TabControlLocalDrivingLicenseApplication
            // 
            this.TabControlLocalDrivingLicenseApplication.Controls.Add(this.TabPageNewLocalLicensePersonalInfo);
            this.TabControlLocalDrivingLicenseApplication.Controls.Add(this.TabPageNewLocalLicenseApplicationInfo);
            this.TabControlLocalDrivingLicenseApplication.Location = new System.Drawing.Point(24, 87);
            this.TabControlLocalDrivingLicenseApplication.Name = "TabControlLocalDrivingLicenseApplication";
            this.TabControlLocalDrivingLicenseApplication.SelectedIndex = 0;
            this.TabControlLocalDrivingLicenseApplication.Size = new System.Drawing.Size(988, 636);
            this.TabControlLocalDrivingLicenseApplication.TabIndex = 1;
            this.TabControlLocalDrivingLicenseApplication.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControlLocalDrivingLicenseApplication_Selecting);
            // 
            // TabPageNewLocalLicensePersonalInfo
            // 
            this.TabPageNewLocalLicensePersonalInfo.Controls.Add(this.ctrlPersonDetailsWithFilter1);
            this.TabPageNewLocalLicensePersonalInfo.Controls.Add(this.BtnBackLocalDrivingLicenseApplicationForm);
            this.TabPageNewLocalLicensePersonalInfo.Controls.Add(this.BtnNextLocalDrivingLicenseApplicationForm);
            this.TabPageNewLocalLicensePersonalInfo.Location = new System.Drawing.Point(4, 28);
            this.TabPageNewLocalLicensePersonalInfo.Name = "TabPageNewLocalLicensePersonalInfo";
            this.TabPageNewLocalLicensePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNewLocalLicensePersonalInfo.Size = new System.Drawing.Size(980, 604);
            this.TabPageNewLocalLicensePersonalInfo.TabIndex = 0;
            this.TabPageNewLocalLicensePersonalInfo.Text = "Personal Info";
            this.TabPageNewLocalLicensePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonDetailsWithFilter1
            // 
            this.ctrlPersonDetailsWithFilter1.Location = new System.Drawing.Point(6, 4);
            this.ctrlPersonDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlPersonDetailsWithFilter1.Name = "ctrlPersonDetailsWithFilter1";
            this.ctrlPersonDetailsWithFilter1.Size = new System.Drawing.Size(944, 507);
            this.ctrlPersonDetailsWithFilter1.TabIndex = 4;
            this.ctrlPersonDetailsWithFilter1.Load += new System.EventHandler(this.ctrlPersonDetailsWithFilter1_Load);
            // 
            // BtnBackLocalDrivingLicenseApplicationForm
            // 
            this.BtnBackLocalDrivingLicenseApplicationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBackLocalDrivingLicenseApplicationForm.Enabled = false;
            this.BtnBackLocalDrivingLicenseApplicationForm.Location = new System.Drawing.Point(20, 520);
            this.BtnBackLocalDrivingLicenseApplicationForm.Name = "BtnBackLocalDrivingLicenseApplicationForm";
            this.BtnBackLocalDrivingLicenseApplicationForm.Size = new System.Drawing.Size(134, 60);
            this.BtnBackLocalDrivingLicenseApplicationForm.TabIndex = 3;
            this.BtnBackLocalDrivingLicenseApplicationForm.Text = "Back";
            this.BtnBackLocalDrivingLicenseApplicationForm.UseVisualStyleBackColor = true;
            // 
            // BtnNextLocalDrivingLicenseApplicationForm
            // 
            this.BtnNextLocalDrivingLicenseApplicationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNextLocalDrivingLicenseApplicationForm.Enabled = false;
            this.BtnNextLocalDrivingLicenseApplicationForm.Location = new System.Drawing.Point(816, 520);
            this.BtnNextLocalDrivingLicenseApplicationForm.Name = "BtnNextLocalDrivingLicenseApplicationForm";
            this.BtnNextLocalDrivingLicenseApplicationForm.Size = new System.Drawing.Size(134, 60);
            this.BtnNextLocalDrivingLicenseApplicationForm.TabIndex = 2;
            this.BtnNextLocalDrivingLicenseApplicationForm.Text = "Next";
            this.BtnNextLocalDrivingLicenseApplicationForm.UseVisualStyleBackColor = true;
            this.BtnNextLocalDrivingLicenseApplicationForm.Click += new System.EventHandler(this.BtnNextLocalDrivingLicenseApplicationForm_Click);
            // 
            // TabPageNewLocalLicenseApplicationInfo
            // 
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.LblLblAppIDLocalDrivingLicenseApplicationValue);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.LblAppIDLocalDrivingLicenseApplicationTitle);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.LblLocalApplicationCreatedByValue);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.label4);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.label3);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.LblApplicationDateLocalDrivingLicenseApplication);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.label2);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.label1);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm);
            this.TabPageNewLocalLicenseApplicationInfo.Controls.Add(this.BtnBack2LocalDrivingLicenseApplicationForm);
            this.TabPageNewLocalLicenseApplicationInfo.Location = new System.Drawing.Point(4, 28);
            this.TabPageNewLocalLicenseApplicationInfo.Name = "TabPageNewLocalLicenseApplicationInfo";
            this.TabPageNewLocalLicenseApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNewLocalLicenseApplicationInfo.Size = new System.Drawing.Size(980, 604);
            this.TabPageNewLocalLicenseApplicationInfo.TabIndex = 1;
            this.TabPageNewLocalLicenseApplicationInfo.Text = "Application Info";
            this.TabPageNewLocalLicenseApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // LblLblAppIDLocalDrivingLicenseApplicationValue
            // 
            this.LblLblAppIDLocalDrivingLicenseApplicationValue.AutoSize = true;
            this.LblLblAppIDLocalDrivingLicenseApplicationValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLblAppIDLocalDrivingLicenseApplicationValue.Location = new System.Drawing.Point(222, 45);
            this.LblLblAppIDLocalDrivingLicenseApplicationValue.Name = "LblLblAppIDLocalDrivingLicenseApplicationValue";
            this.LblLblAppIDLocalDrivingLicenseApplicationValue.Size = new System.Drawing.Size(75, 29);
            this.LblLblAppIDLocalDrivingLicenseApplicationValue.TabIndex = 13;
            this.LblLblAppIDLocalDrivingLicenseApplicationValue.Text = "[????]";
            // 
            // LblAppIDLocalDrivingLicenseApplicationTitle
            // 
            this.LblAppIDLocalDrivingLicenseApplicationTitle.AutoSize = true;
            this.LblAppIDLocalDrivingLicenseApplicationTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppIDLocalDrivingLicenseApplicationTitle.Location = new System.Drawing.Point(28, 45);
            this.LblAppIDLocalDrivingLicenseApplicationTitle.Name = "LblAppIDLocalDrivingLicenseApplicationTitle";
            this.LblAppIDLocalDrivingLicenseApplicationTitle.Size = new System.Drawing.Size(159, 29);
            this.LblAppIDLocalDrivingLicenseApplicationTitle.TabIndex = 12;
            this.LblAppIDLocalDrivingLicenseApplicationTitle.Text = "Application ID";
            // 
            // LblLocalApplicationCreatedByValue
            // 
            this.LblLocalApplicationCreatedByValue.AutoSize = true;
            this.LblLocalApplicationCreatedByValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocalApplicationCreatedByValue.Location = new System.Drawing.Point(206, 228);
            this.LblLocalApplicationCreatedByValue.Name = "LblLocalApplicationCreatedByValue";
            this.LblLocalApplicationCreatedByValue.Size = new System.Drawing.Size(34, 29);
            this.LblLocalApplicationCreatedByValue.TabIndex = 11;
            this.LblLocalApplicationCreatedByValue.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Created By :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Application Fees : 15";
            // 
            // LblApplicationDateLocalDrivingLicenseApplication
            // 
            this.LblApplicationDateLocalDrivingLicenseApplication.AutoSize = true;
            this.LblApplicationDateLocalDrivingLicenseApplication.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApplicationDateLocalDrivingLicenseApplication.Location = new System.Drawing.Point(214, 140);
            this.LblApplicationDateLocalDrivingLicenseApplication.Name = "LblApplicationDateLocalDrivingLicenseApplication";
            this.LblApplicationDateLocalDrivingLicenseApplication.Size = new System.Drawing.Size(34, 29);
            this.LblApplicationDateLocalDrivingLicenseApplication.TabIndex = 8;
            this.LblApplicationDateLocalDrivingLicenseApplication.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Application Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "License Class";
            // 
            // ComboBoxLicenseClassNewLocalDrivingLicenseAppForm
            // 
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.FormattingEnabled = true;
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.Items.AddRange(new object[] {
            "Class 1 - Small Motorcycle",
            "Class 2 - Heavy Motorcycle License",
            "Class 3 - Ordinary driving license",
            "Class 4 - Commercial",
            "Class 5 - Agricultural",
            "Class 6 - Small and medium bus",
            "Class 7 - Truck and heavy vehicle"});
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.Location = new System.Drawing.Point(220, 96);
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.Name = "ComboBoxLicenseClassNewLocalDrivingLicenseAppForm";
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.Size = new System.Drawing.Size(248, 27);
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.TabIndex = 5;
            this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLicenseClassNewLocalDrivingLicenseAppForm_SelectedIndexChanged);
            // 
            // BtnBack2LocalDrivingLicenseApplicationForm
            // 
            this.BtnBack2LocalDrivingLicenseApplicationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack2LocalDrivingLicenseApplicationForm.Location = new System.Drawing.Point(22, 519);
            this.BtnBack2LocalDrivingLicenseApplicationForm.Name = "BtnBack2LocalDrivingLicenseApplicationForm";
            this.BtnBack2LocalDrivingLicenseApplicationForm.Size = new System.Drawing.Size(134, 60);
            this.BtnBack2LocalDrivingLicenseApplicationForm.TabIndex = 4;
            this.BtnBack2LocalDrivingLicenseApplicationForm.Text = "Back";
            this.BtnBack2LocalDrivingLicenseApplicationForm.UseVisualStyleBackColor = true;
            this.BtnBack2LocalDrivingLicenseApplicationForm.Click += new System.EventHandler(this.BtnBack2LocalDrivingLicenseApplicationForm_Click);
            // 
            // BtnSavetLocalDrivingLicenseApplicationForm
            // 
            this.BtnSavetLocalDrivingLicenseApplicationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSavetLocalDrivingLicenseApplicationForm.Enabled = false;
            this.BtnSavetLocalDrivingLicenseApplicationForm.Location = new System.Drawing.Point(878, 729);
            this.BtnSavetLocalDrivingLicenseApplicationForm.Name = "BtnSavetLocalDrivingLicenseApplicationForm";
            this.BtnSavetLocalDrivingLicenseApplicationForm.Size = new System.Drawing.Size(134, 60);
            this.BtnSavetLocalDrivingLicenseApplicationForm.TabIndex = 3;
            this.BtnSavetLocalDrivingLicenseApplicationForm.Text = "Save";
            this.BtnSavetLocalDrivingLicenseApplicationForm.UseVisualStyleBackColor = true;
            this.BtnSavetLocalDrivingLicenseApplicationForm.Click += new System.EventHandler(this.BtnSavetLocalDrivingLicenseApplicationForm_Click);
            // 
            // BtnCloseLocalDrivingLicenseApplicationForm
            // 
            this.BtnCloseLocalDrivingLicenseApplicationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseLocalDrivingLicenseApplicationForm.Location = new System.Drawing.Point(722, 729);
            this.BtnCloseLocalDrivingLicenseApplicationForm.Name = "BtnCloseLocalDrivingLicenseApplicationForm";
            this.BtnCloseLocalDrivingLicenseApplicationForm.Size = new System.Drawing.Size(134, 60);
            this.BtnCloseLocalDrivingLicenseApplicationForm.TabIndex = 4;
            this.BtnCloseLocalDrivingLicenseApplicationForm.Text = "Close";
            this.BtnCloseLocalDrivingLicenseApplicationForm.UseVisualStyleBackColor = true;
            this.BtnCloseLocalDrivingLicenseApplicationForm.Click += new System.EventHandler(this.BtnCloseLocalDrivingLicenseApplicationForm_Click);
            // 
            // FrmAddEditLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1060, 808);
            this.Controls.Add(this.BtnCloseLocalDrivingLicenseApplicationForm);
            this.Controls.Add(this.BtnSavetLocalDrivingLicenseApplicationForm);
            this.Controls.Add(this.TabControlLocalDrivingLicenseApplication);
            this.Controls.Add(this.LblLocalDrivingLicenseApplicationTitle);
            this.Name = "FrmAddEditLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Local Driving License Application";
            this.TabControlLocalDrivingLicenseApplication.ResumeLayout(false);
            this.TabPageNewLocalLicensePersonalInfo.ResumeLayout(false);
            this.TabPageNewLocalLicenseApplicationInfo.ResumeLayout(false);
            this.TabPageNewLocalLicenseApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLocalDrivingLicenseApplicationTitle;
        private System.Windows.Forms.TabControl TabControlLocalDrivingLicenseApplication;
        private System.Windows.Forms.TabPage TabPageNewLocalLicensePersonalInfo;
        private System.Windows.Forms.Button BtnNextLocalDrivingLicenseApplicationForm;
        private System.Windows.Forms.TabPage TabPageNewLocalLicenseApplicationInfo;
        private System.Windows.Forms.Button BtnSavetLocalDrivingLicenseApplicationForm;
        private System.Windows.Forms.Button BtnCloseLocalDrivingLicenseApplicationForm;
        private System.Windows.Forms.Button BtnBackLocalDrivingLicenseApplicationForm;
        private System.Windows.Forms.Button BtnBack2LocalDrivingLicenseApplicationForm;
        private People.Controls.CtrlPersonDetailsWithFilter ctrlPersonDetailsWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxLicenseClassNewLocalDrivingLicenseAppForm;
        private System.Windows.Forms.Label LblLocalApplicationCreatedByValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblApplicationDateLocalDrivingLicenseApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAppIDLocalDrivingLicenseApplicationTitle;
        private System.Windows.Forms.Label LblLblAppIDLocalDrivingLicenseApplicationValue;
    }
}