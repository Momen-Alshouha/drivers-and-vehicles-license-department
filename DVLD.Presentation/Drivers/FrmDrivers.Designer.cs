﻿namespace DVLD.Presentation.Drivers
{
    partial class FrmDrivers
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCloseDriversForm = new System.Windows.Forms.Button();
            this.DataGridViewDrivers = new System.Windows.Forms.DataGridView();
            this.LblDriversFilterBy = new System.Windows.Forms.Label();
            this.comboBoxDriversFilter = new System.Windows.Forms.ComboBox();
            this.textBoxDriversFilterValue = new System.Windows.Forms.TextBox();
            this.LblDriversRowsCount = new System.Windows.Forms.Label();
            this.LblDriversRowsCountValue = new System.Windows.Forms.Label();
            this.contextMenuStripDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDrivers)).BeginInit();
            this.contextMenuStripDrivers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(449, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(467, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drivers";
            // 
            // BtnCloseDriversForm
            // 
            this.BtnCloseDriversForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseDriversForm.Location = new System.Drawing.Point(934, 560);
            this.BtnCloseDriversForm.Name = "BtnCloseDriversForm";
            this.BtnCloseDriversForm.Size = new System.Drawing.Size(130, 66);
            this.BtnCloseDriversForm.TabIndex = 2;
            this.BtnCloseDriversForm.Text = "Close";
            this.BtnCloseDriversForm.UseVisualStyleBackColor = true;
            this.BtnCloseDriversForm.Click += new System.EventHandler(this.BtnCloseDriversForm_Click);
            // 
            // DataGridViewDrivers
            // 
            this.DataGridViewDrivers.AllowUserToAddRows = false;
            this.DataGridViewDrivers.AllowUserToDeleteRows = false;
            this.DataGridViewDrivers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGridViewDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDrivers.Location = new System.Drawing.Point(12, 279);
            this.DataGridViewDrivers.MultiSelect = false;
            this.DataGridViewDrivers.Name = "DataGridViewDrivers";
            this.DataGridViewDrivers.ReadOnly = true;
            this.DataGridViewDrivers.RowHeadersWidth = 62;
            this.DataGridViewDrivers.RowTemplate.Height = 29;
            this.DataGridViewDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDrivers.Size = new System.Drawing.Size(1052, 275);
            this.DataGridViewDrivers.TabIndex = 3;
            this.DataGridViewDrivers.SelectionChanged += new System.EventHandler(this.DataGridViewDrivers_SelectionChanged);
            // 
            // LblDriversFilterBy
            // 
            this.LblDriversFilterBy.AutoSize = true;
            this.LblDriversFilterBy.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.LblDriversFilterBy.ForeColor = System.Drawing.Color.Firebrick;
            this.LblDriversFilterBy.Location = new System.Drawing.Point(12, 233);
            this.LblDriversFilterBy.Name = "LblDriversFilterBy";
            this.LblDriversFilterBy.Size = new System.Drawing.Size(140, 31);
            this.LblDriversFilterBy.TabIndex = 4;
            this.LblDriversFilterBy.Text = "Filter By :";
            // 
            // comboBoxDriversFilter
            // 
            this.comboBoxDriversFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriversFilter.FormattingEnabled = true;
            this.comboBoxDriversFilter.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No.",
            "Full Name"});
            this.comboBoxDriversFilter.Location = new System.Drawing.Point(159, 236);
            this.comboBoxDriversFilter.Name = "comboBoxDriversFilter";
            this.comboBoxDriversFilter.Size = new System.Drawing.Size(163, 27);
            this.comboBoxDriversFilter.TabIndex = 5;
            this.comboBoxDriversFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxDriversFilter_SelectedIndexChanged);
            // 
            // textBoxDriversFilterValue
            // 
            this.textBoxDriversFilterValue.Location = new System.Drawing.Point(328, 236);
            this.textBoxDriversFilterValue.Name = "textBoxDriversFilterValue";
            this.textBoxDriversFilterValue.Size = new System.Drawing.Size(152, 27);
            this.textBoxDriversFilterValue.TabIndex = 6;
            this.textBoxDriversFilterValue.Visible = false;
            this.textBoxDriversFilterValue.TextChanged += new System.EventHandler(this.textBoxDriversFilterValue_TextChanged);
            // 
            // LblDriversRowsCount
            // 
            this.LblDriversRowsCount.AutoSize = true;
            this.LblDriversRowsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.LblDriversRowsCount.ForeColor = System.Drawing.Color.Firebrick;
            this.LblDriversRowsCount.Location = new System.Drawing.Point(12, 583);
            this.LblDriversRowsCount.Name = "LblDriversRowsCount";
            this.LblDriversRowsCount.Size = new System.Drawing.Size(132, 29);
            this.LblDriversRowsCount.TabIndex = 7;
            this.LblDriversRowsCount.Text = "Records : ";
            // 
            // LblDriversRowsCountValue
            // 
            this.LblDriversRowsCountValue.AutoSize = true;
            this.LblDriversRowsCountValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.LblDriversRowsCountValue.ForeColor = System.Drawing.Color.Firebrick;
            this.LblDriversRowsCountValue.Location = new System.Drawing.Point(137, 583);
            this.LblDriversRowsCountValue.Name = "LblDriversRowsCountValue";
            this.LblDriversRowsCountValue.Size = new System.Drawing.Size(37, 29);
            this.LblDriversRowsCountValue.TabIndex = 8;
            this.LblDriversRowsCountValue.Text = "...";
            // 
            // contextMenuStripDrivers
            // 
            this.contextMenuStripDrivers.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.issueInternationalLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStripDrivers.Name = "contextMenuStripDrivers";
            this.contextMenuStripDrivers.Size = new System.Drawing.Size(326, 124);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.User_32__21;
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            this.issueInternationalLicenseToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.International_32;
            this.issueInternationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            this.issueInternationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            this.issueInternationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueInternationalLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.License_View_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(325, 40);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // FrmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1091, 638);
            this.Controls.Add(this.LblDriversRowsCountValue);
            this.Controls.Add(this.LblDriversRowsCount);
            this.Controls.Add(this.textBoxDriversFilterValue);
            this.Controls.Add(this.comboBoxDriversFilter);
            this.Controls.Add(this.LblDriversFilterBy);
            this.Controls.Add(this.DataGridViewDrivers);
            this.Controls.Add(this.BtnCloseDriversForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drivers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDrivers)).EndInit();
            this.contextMenuStripDrivers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCloseDriversForm;
        private System.Windows.Forms.DataGridView DataGridViewDrivers;
        private System.Windows.Forms.Label LblDriversFilterBy;
        private System.Windows.Forms.ComboBox comboBoxDriversFilter;
        private System.Windows.Forms.TextBox textBoxDriversFilterValue;
        private System.Windows.Forms.Label LblDriversRowsCount;
        private System.Windows.Forms.Label LblDriversRowsCountValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDrivers;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}