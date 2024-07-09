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
            this.addNewApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.LblManageLocalTitle.Location = new System.Drawing.Point(161, 93);
            this.LblManageLocalTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblManageLocalTitle.Name = "LblManageLocalTitle";
            this.LblManageLocalTitle.Size = new System.Drawing.Size(415, 25);
            this.LblManageLocalTitle.TabIndex = 5;
            this.LblManageLocalTitle.Text = "Manage Local Driving License Application";
            // 
            // DataGridViewLocalDrivingLicenseApplications_View
            // 
            this.DataGridViewLocalDrivingLicenseApplications_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLocalDrivingLicenseApplications_View.Location = new System.Drawing.Point(12, 224);
            this.DataGridViewLocalDrivingLicenseApplications_View.MultiSelect = false;
            this.DataGridViewLocalDrivingLicenseApplications_View.Name = "DataGridViewLocalDrivingLicenseApplications_View";
            this.DataGridViewLocalDrivingLicenseApplications_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLocalDrivingLicenseApplications_View.Size = new System.Drawing.Size(691, 204);
            this.DataGridViewLocalDrivingLicenseApplications_View.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
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
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.Location = new System.Drawing.Point(121, 179);
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.Name = "ComboBoxFilterByManageLocalDrivingLicenseForm";
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.Size = new System.Drawing.Size(128, 21);
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.TabIndex = 8;
            this.ComboBoxFilterByManageLocalDrivingLicenseForm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterByManageLocalDrivingLicenseForm_SelectedIndexChanged);
            // 
            // PictureBoxAddNewLocalDrivingLicenseApplication
            // 
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Image = global::DVLD.Presentation.Properties.Resources.New_Application_64;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Location = new System.Drawing.Point(650, 157);
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Name = "PictureBoxAddNewLocalDrivingLicenseApplication";
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Size = new System.Drawing.Size(53, 61);
            this.PictureBoxAddNewLocalDrivingLicenseApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.TabIndex = 9;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.TabStop = false;
            this.PictureBoxAddNewLocalDrivingLicenseApplication.Click += new System.EventHandler(this.PictureBoxAddNewLocalDrivingLicenseApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.Manage_Applications_64;
            this.pictureBox1.Location = new System.Drawing.Point(319, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxFilterByManageLocalDrivingLicenseForm
            // 
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Location = new System.Drawing.Point(255, 179);
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Name = "TextBoxFilterByManageLocalDrivingLicenseForm";
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Size = new System.Drawing.Size(146, 20);
            this.TextBoxFilterByManageLocalDrivingLicenseForm.TabIndex = 10;
            this.TextBoxFilterByManageLocalDrivingLicenseForm.Visible = false;
            this.TextBoxFilterByManageLocalDrivingLicenseForm.TextChanged += new System.EventHandler(this.TextBoxFilterByManageLocalDrivingLicenseForm_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Records : ";
            // 
            // LblNumberOfApplications
            // 
            this.LblNumberOfApplications.AutoSize = true;
            this.LblNumberOfApplications.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumberOfApplications.Location = new System.Drawing.Point(96, 444);
            this.LblNumberOfApplications.Name = "LblNumberOfApplications";
            this.LblNumberOfApplications.Size = new System.Drawing.Size(24, 19);
            this.LblNumberOfApplications.TabIndex = 12;
            this.LblNumberOfApplications.Text = "...";
            // 
            // ContextMenuStripManageLocalDrivingLicenseApplicationForm
            // 
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
            this.ContextMenuStripManageLocalDrivingLicenseApplicationForm.Size = new System.Drawing.Size(238, 224);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTheoryTestToolStripMenuItem,
            this.practicalStreetTestToolStripMenuItem});
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.scheduleToolStripMenuItem.Text = "Schedule Tests";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.visionTestToolStripMenuItem.Text = "Vision Test";
            // 
            // writtenTheoryTestToolStripMenuItem
            // 
            this.writtenTheoryTestToolStripMenuItem.Name = "writtenTheoryTestToolStripMenuItem";
            this.writtenTheoryTestToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.writtenTheoryTestToolStripMenuItem.Text = "Written (Theory) Test";
            // 
            // practicalStreetTestToolStripMenuItem
            // 
            this.practicalStreetTestToolStripMenuItem.Name = "practicalStreetTestToolStripMenuItem";
            this.practicalStreetTestToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.practicalStreetTestToolStripMenuItem.Text = "Practical (Street) Test";
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License First Time";
            // 
            // showLicensesToolStripMenuItem
            // 
            this.showLicensesToolStripMenuItem.Name = "showLicensesToolStripMenuItem";
            this.showLicensesToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.showLicensesToolStripMenuItem.Text = "Show Licenses";
            // 
            // showPersonLicenesHistoryToolStripMenuItem
            // 
            this.showPersonLicenesHistoryToolStripMenuItem.Name = "showPersonLicenesHistoryToolStripMenuItem";
            this.showPersonLicenesHistoryToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.showPersonLicenesHistoryToolStripMenuItem.Text = "Show Person Licenes History";
            // 
            // addNewApplicationToolStripMenuItem
            // 
            this.addNewApplicationToolStripMenuItem.Name = "addNewApplicationToolStripMenuItem";
            this.addNewApplicationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.addNewApplicationToolStripMenuItem.Text = "Add New Application";
            // 
            // FrmManageLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.LblNumberOfApplications);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxFilterByManageLocalDrivingLicenseForm);
            this.Controls.Add(this.PictureBoxAddNewLocalDrivingLicenseApplication);
            this.Controls.Add(this.ComboBoxFilterByManageLocalDrivingLicenseForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridViewLocalDrivingLicenseApplications_View);
            this.Controls.Add(this.LblManageLocalTitle);
            this.Controls.Add(this.pictureBox1);
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
    }
}