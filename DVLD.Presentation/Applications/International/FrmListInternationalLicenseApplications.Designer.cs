namespace DVLD.Presentation.Applications.International
{
    partial class FrmListInternationalLicenseApplications
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInternationalApplications = new System.Windows.Forms.DataGridView();
            this.BtnInternationalApplicationsClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblInternationalLicenseApplicationsRecordsCountValues = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFilterInternationalLicenses = new System.Windows.Forms.ComboBox();
            this.textBoxFilterInternationalLicenseIDValue = new System.Windows.Forms.TextBox();
            this.LblValidateInputLicenseAppList = new System.Windows.Forms.Label();
            this.contextMenuStripListInternationalLicenseForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxNewInternationalApplication = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInternationalApplications)).BeginInit();
            this.contextMenuStripListInternationalLicenseForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewInternationalApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(222, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "International Applications";
            // 
            // dataGridViewInternationalApplications
            // 
            this.dataGridViewInternationalApplications.AllowUserToAddRows = false;
            this.dataGridViewInternationalApplications.AllowUserToDeleteRows = false;
            this.dataGridViewInternationalApplications.AllowUserToResizeColumns = false;
            this.dataGridViewInternationalApplications.AllowUserToResizeRows = false;
            this.dataGridViewInternationalApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInternationalApplications.Location = new System.Drawing.Point(12, 324);
            this.dataGridViewInternationalApplications.MultiSelect = false;
            this.dataGridViewInternationalApplications.Name = "dataGridViewInternationalApplications";
            this.dataGridViewInternationalApplications.ReadOnly = true;
            this.dataGridViewInternationalApplications.RowHeadersWidth = 62;
            this.dataGridViewInternationalApplications.RowTemplate.Height = 29;
            this.dataGridViewInternationalApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInternationalApplications.Size = new System.Drawing.Size(896, 287);
            this.dataGridViewInternationalApplications.TabIndex = 4;
            this.dataGridViewInternationalApplications.SelectionChanged += new System.EventHandler(this.dataGridViewInternationalApplications_SelectionChanged);
            // 
            // BtnInternationalApplicationsClose
            // 
            this.BtnInternationalApplicationsClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInternationalApplicationsClose.Location = new System.Drawing.Point(788, 617);
            this.BtnInternationalApplicationsClose.Name = "BtnInternationalApplicationsClose";
            this.BtnInternationalApplicationsClose.Size = new System.Drawing.Size(120, 54);
            this.BtnInternationalApplicationsClose.TabIndex = 5;
            this.BtnInternationalApplicationsClose.Text = "Close";
            this.BtnInternationalApplicationsClose.UseVisualStyleBackColor = true;
            this.BtnInternationalApplicationsClose.Click += new System.EventHandler(this.BtnInternationalApplicationsClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(12, 637);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Records : ";
            // 
            // LblInternationalLicenseApplicationsRecordsCountValues
            // 
            this.LblInternationalLicenseApplicationsRecordsCountValues.AutoSize = true;
            this.LblInternationalLicenseApplicationsRecordsCountValues.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.LblInternationalLicenseApplicationsRecordsCountValues.ForeColor = System.Drawing.Color.Firebrick;
            this.LblInternationalLicenseApplicationsRecordsCountValues.Location = new System.Drawing.Point(159, 637);
            this.LblInternationalLicenseApplicationsRecordsCountValues.Name = "LblInternationalLicenseApplicationsRecordsCountValues";
            this.LblInternationalLicenseApplicationsRecordsCountValues.Size = new System.Drawing.Size(69, 34);
            this.LblInternationalLicenseApplicationsRecordsCountValues.TabIndex = 8;
            this.LblInternationalLicenseApplicationsRecordsCountValues.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter By: ";
            // 
            // comboBoxFilterInternationalLicenses
            // 
            this.comboBoxFilterInternationalLicenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterInternationalLicenses.FormattingEnabled = true;
            this.comboBoxFilterInternationalLicenses.Items.AddRange(new object[] {
            "Driver ID",
            "International License ID"});
            this.comboBoxFilterInternationalLicenses.Location = new System.Drawing.Point(152, 290);
            this.comboBoxFilterInternationalLicenses.Name = "comboBoxFilterInternationalLicenses";
            this.comboBoxFilterInternationalLicenses.Size = new System.Drawing.Size(220, 27);
            this.comboBoxFilterInternationalLicenses.TabIndex = 10;
            this.comboBoxFilterInternationalLicenses.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterInternationalLicenses_SelectedIndexChanged);
            // 
            // textBoxFilterInternationalLicenseIDValue
            // 
            this.textBoxFilterInternationalLicenseIDValue.Location = new System.Drawing.Point(378, 290);
            this.textBoxFilterInternationalLicenseIDValue.Name = "textBoxFilterInternationalLicenseIDValue";
            this.textBoxFilterInternationalLicenseIDValue.Size = new System.Drawing.Size(100, 27);
            this.textBoxFilterInternationalLicenseIDValue.TabIndex = 11;
            this.textBoxFilterInternationalLicenseIDValue.TextChanged += new System.EventHandler(this.textBoxFilterInternationalLicenseIDValue_TextChanged);
            // 
            // LblValidateInputLicenseAppList
            // 
            this.LblValidateInputLicenseAppList.AutoSize = true;
            this.LblValidateInputLicenseAppList.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.LblValidateInputLicenseAppList.ForeColor = System.Drawing.Color.Firebrick;
            this.LblValidateInputLicenseAppList.Location = new System.Drawing.Point(484, 300);
            this.LblValidateInputLicenseAppList.Name = "LblValidateInputLicenseAppList";
            this.LblValidateInputLicenseAppList.Size = new System.Drawing.Size(151, 17);
            this.LblValidateInputLicenseAppList.TabIndex = 12;
            this.LblValidateInputLicenseAppList.Text = "Enter valid number...";
            this.LblValidateInputLicenseAppList.Visible = false;
            // 
            // contextMenuStripListInternationalLicenseForm
            // 
            this.contextMenuStripListInternationalLicenseForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripListInternationalLicenseForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStripListInternationalLicenseForm.Name = "contextMenuStripListInternationalLicenseForm";
            this.contextMenuStripListInternationalLicenseForm.Size = new System.Drawing.Size(326, 124);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.License_View_32;
            this.showLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // pictureBoxNewInternationalApplication
            // 
            this.pictureBoxNewInternationalApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNewInternationalApplication.Image = global::DVLD.Presentation.Properties.Resources.New_Application_64;
            this.pictureBoxNewInternationalApplication.Location = new System.Drawing.Point(836, 245);
            this.pictureBoxNewInternationalApplication.Name = "pictureBoxNewInternationalApplication";
            this.pictureBoxNewInternationalApplication.Size = new System.Drawing.Size(72, 73);
            this.pictureBoxNewInternationalApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNewInternationalApplication.TabIndex = 3;
            this.pictureBoxNewInternationalApplication.TabStop = false;
            this.pictureBoxNewInternationalApplication.Click += new System.EventHandler(this.pictureBoxNewInternationalApplication_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD.Presentation.Properties.Resources.International_32;
            this.pictureBox2.Location = new System.Drawing.Point(566, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.Applications1;
            this.pictureBox1.Location = new System.Drawing.Point(416, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.User_32__2;
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // FrmListInternationalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(923, 683);
            this.Controls.Add(this.LblValidateInputLicenseAppList);
            this.Controls.Add(this.textBoxFilterInternationalLicenseIDValue);
            this.Controls.Add(this.comboBoxFilterInternationalLicenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblInternationalLicenseApplicationsRecordsCountValues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnInternationalApplicationsClose);
            this.Controls.Add(this.dataGridViewInternationalApplications);
            this.Controls.Add(this.pictureBoxNewInternationalApplication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmListInternationalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "International License Applications";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInternationalApplications)).EndInit();
            this.contextMenuStripListInternationalLicenseForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewInternationalApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNewInternationalApplication;
        private System.Windows.Forms.DataGridView dataGridViewInternationalApplications;
        private System.Windows.Forms.Button BtnInternationalApplicationsClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblInternationalLicenseApplicationsRecordsCountValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFilterInternationalLicenses;
        private System.Windows.Forms.TextBox textBoxFilterInternationalLicenseIDValue;
        private System.Windows.Forms.Label LblValidateInputLicenseAppList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListInternationalLicenseForm;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}