namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    partial class FrmManageLocalDrivingLicenseApplication
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
            this.LblManageLocalTitle = new System.Windows.Forms.Label();
            this.DataGridViewLocalDrivingLicenseApplications_View = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxFilterByManageLocalDrivingLicenseForm = new System.Windows.Forms.ComboBox();
            this.PictureBoxAddNewLocalDrivingLicenseApplication = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxFilterByManageLocalDrivingLicenseForm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNumberOfApplications = new System.Windows.Forms.Label();
            this.ContextMenuStripManageLocalDrivingLicenseApplicationForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTheoryTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicalStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCloseManageLocalApplicationsForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocalDrivingLicenseApplications_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddNewLocalDrivingLicenseApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContextMenuStripManageLocalDrivingLicenseApplicationForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblManageLocalTitle
            // 
            this.LblManageLocalTitle.AutoSize = true;
            this.LblManageLocalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManageLocalTitle.Location = new System.Drawing.Point(466, 131);
            this.LblManageLocalTitle.Name = "LblManageLocalTitle";
            this.LblManageLocalTitle.Size = new System.Drawing.Size(612, 36);
            this.LblManageLocalTitle.TabIndex = 5;
            this.LblManageLocalTitle.Text = "Manage Local Driving License Application";
            // 
            // DataGridViewLocalDrivingLicenseApplications_View
            // 
            this.DataGridViewLocalDrivingLicenseApplications_View.AllowUserToAddRows = false;
            this.DataGridViewLocalDrivingLicenseApplications_View.AllowUserToDeleteRows = false;
            this.DataGridViewLocalDrivingLicenseApplications_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLocalDrivingLicenseApplications_View.Location = new System.Drawing.Point(18, 327);
            this.DataGridViewLocalDrivingLicenseApplications_View.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewLocalDrivingLicenseApplications_View.MultiSelect = false;
            this.DataGridViewLocalDrivingLicenseApplications_View.Name = "DataGridViewLocalDrivingLicenseApplications_View";
            this.DataGridViewLocalDrivingLicenseApplications_View.ReadOnly = true;
            this.DataGridViewLocalDrivingLicenseApplications_View.RowHeadersWidth = 62;
            this.DataGridViewLocalDrivingLicenseApplications_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLocalDrivingLicenseApplications_View.Size = new System.Drawing.Size(1415, 406);
            this.DataGridViewLocalDrivingLicenseApplications_View.TabIndex = 6;
            this.DataGridViewLocalDrivingLicenseApplications_View.SelectionChanged += new System.EventHandler(this.DataGridViewLocalDrivingLicenseApplications_View_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 256);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter By:";
            // 
            // ComboBoxFilterByManageLocalDrivingLicenseForm
            // 
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "L.D.L App ID",
            "National No.",
            "Full Name",
            "Status"});
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.FormattingEnabled = true;
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.Items.AddRange(new object[] {
            "None",
            "L.D.L App ID",
            "National No.",
            "Full Name",
            "Status"});
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.Location = new System.Drawing.Point(182, 262);
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.Name = "ComboBoxFilterByManageLocalDrivingLicenseForm";
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.Size = new System.Drawing.Size(190, 27);
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.TabIndex = 8;
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterByManageLocalDrivingLicenseForm_SelectedIndexChanged);
            // 
            // PictureBoxAddNewLocalDrivingLicenseApplication
            // 
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Image = global::DVLD.Presentation.Properties.Resources.New_Application_64;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Location = new System.Drawing.Point(1353, 230);
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Name = "PictureBoxAddNewLocalDrivingLicenseApplication";
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Size = new System.Drawing.Size(80, 89);
            this.PictureBoxAddNewLocalDrivingLicenseApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.TabIndex = 9;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.TabStop = false;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Click += new System.EventHandler(this.PictureBoxAddNewLocalDrivingLicenseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.Manage_Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(702, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxFilterByManageLocalDrivingLicenseForm
            // 
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Location = new System.Drawing.Point(382, 262);
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Name = "TextBoxFilterByManageLocalDrivingLicenseForm";
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Size = new System.Drawing.Size(217, 27);
            this.TextBoxFilterByManageLocalDrivingLicenseForm.TabIndex = 10;
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Visible = false;
            this.TextBoxFilterByManageLocalDrivingLicenseForm.TextChanged += new System.EventHandler(this.TextBoxFilterByManageLocalDrivingLicenseForm_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 759);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Records : ";
            // 
            // LblNumberOfApplications
            // 
            this.LblNumberOfApplications.AutoSize = true;
            this.LblNumberOfApplications.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfApplications.Location = new System.Drawing.Point(144, 759);
            this.LblNumberOfApplications.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNumberOfApplications.Name = "LblNumberOfApplications";
            this.LblNumberOfApplications.Size = new System.Drawing.Size(37, 29);
            this.LblNumberOfApplications.TabIndex = 12;
            this.LblNumberOfApplications.Text = "...";
            // 
            // ContextMenuStripManageLocalDrivingLicenseApplicationForm
            // 
            this.ContextMenuStripManageLocalDrivingLicenseApplicationForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripManageLocalDrivingLicenseApplicationForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewApplicationToolStripMenuItem,
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showLicensesToolStripMenuItem,
            this.showPersonLicenesHistoryToolStripMenuItem});
            this.ContextMenuStripManageLocalDrivingLicenseApplicationForm.Name = "ContextMenuStripManageLocalDrivingLicenseApplicationForm";
            this.ContextMenuStripManageLocalDrivingLicenseApplicationForm.Size = new System.Drawing.Size(339, 325);
            // 
            // addNewApplicationToolStripMenuItem
            // 
            this.addNewApplicationToolStripMenuItem.Name = "addNewApplicationToolStripMenuItem";
            this.addNewApplicationToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.addNewApplicationToolStripMenuItem.Text = "Add New Application";
            this.addNewApplicationToolStripMenuItem.Click += new System.EventHandler(this.addNewApplicationToolStripMenuItem_Click);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTheoryTestToolStripMenuItem,
            this.practicalStreetTestToolStripMenuItem});
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.scheduleToolStripMenuItem.Text = "Schedule Tests";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.visionTestToolStripMenuItem_Click);
            // 
            // writtenTheoryTestToolStripMenuItem
            // 
            this.writtenTheoryTestToolStripMenuItem.Name = "writtenTheoryTestToolStripMenuItem";
            this.writtenTheoryTestToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.writtenTheoryTestToolStripMenuItem.Text = "Written (Theory) Test";
            // 
            // practicalStreetTestToolStripMenuItem
            // 
            this.practicalStreetTestToolStripMenuItem.Name = "practicalStreetTestToolStripMenuItem";
            this.practicalStreetTestToolStripMenuItem.Size = new System.Drawing.Size(276, 34);
            this.practicalStreetTestToolStripMenuItem.Text = "Practical (Street) Test";
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // showLicensesToolStripMenuItem
            // 
            this.showLicensesToolStripMenuItem.Name = "showLicensesToolStripMenuItem";
            this.showLicensesToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.showLicensesToolStripMenuItem.Text = "Show Licenses";
            // 
            // showPersonLicenesHistoryToolStripMenuItem
            // 
            this.showPersonLicenesHistoryToolStripMenuItem.Name = "showPersonLicenesHistoryToolStripMenuItem";
            this.showPersonLicenesHistoryToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.showPersonLicenesHistoryToolStripMenuItem.Text = "Show Person Licenes History";
            // 
            // BtnCloseManageLocalApplicationsForm
            // 
            this.BtnCloseManageLocalApplicationsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseManageLocalApplicationsForm.Location = new System.Drawing.Point(1263, 743);
            this.BtnCloseManageLocalApplicationsForm.Name = "BtnCloseManageLocalApplicationsForm";
            this.BtnCloseManageLocalApplicationsForm.Size = new System.Drawing.Size(170, 67);
            this.BtnCloseManageLocalApplicationsForm.TabIndex = 13;
            this.BtnCloseManageLocalApplicationsForm.Text = "Close";
            this.BtnCloseManageLocalApplicationsForm.UseVisualStyleBackColor = true;
            // 
            // FrmManageLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1467, 836);
            this.Controls.Add(this.BtnCloseManageLocalApplicationsForm);
            this.Controls.Add(this.LblNumberOfApplications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxFilterByManageLocalDrivingLicenseForm);
            this.Controls.Add(this.PictureBoxAddNewLocalDrivingLicenseApplication);
            this.Controls.Add(this.ComboBoxFilterByManageLocalDrivingLicenseForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewLocalDrivingLicenseApplications_View);
            this.Controls.Add(this.LblManageLocalTitle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmManageLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Local Driving License Application";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocalDrivingLicenseApplications_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddNewLocalDrivingLicenseApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContextMenuStripManageLocalDrivingLicenseApplicationForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblManageLocalTitle;
        private System.Windows.Forms.DataGridView DataGridViewLocalDrivingLicenseApplications_View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxFilterByManageLocalDrivingLicenseForm;
        private System.Windows.Forms.PictureBox PictureBoxAddNewLocalDrivingLicenseApplication;
        private System.Windows.Forms.TextBox TextBoxFilterByManageLocalDrivingLicenseForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNumberOfApplications;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripManageLocalDrivingLicenseApplicationForm;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTheoryTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicalStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewApplicationToolStripMenuItem;
        private System.Windows.Forms.Button BtnCloseManageLocalApplicationsForm;
    }
}