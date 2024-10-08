﻿namespace DVLD.Presentation.Licenses.Detain_License
{
    partial class FrmManageDetainedLicenses
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.pictureBoxDetainLicence = new System.Windows.Forms.PictureBox();
            this.pictureBoxReleaseLicense = new System.Windows.Forms.PictureBox();
            this.textBoxFilterManageDetainedLicenses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFilterManageDetainedLicenses = new System.Windows.Forms.ComboBox();
            this.buttonCloseFrm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetainedLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetainLicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReleaseLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(767, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(347, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Detained Licenses";
            // 
            // dataGridViewDetainedLicenses
            // 
            this.dataGridViewDetainedLicenses.AllowUserToAddRows = false;
            this.dataGridViewDetainedLicenses.AllowUserToDeleteRows = false;
            this.dataGridViewDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetainedLicenses.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDetainedLicenses.Location = new System.Drawing.Point(12, 269);
            this.dataGridViewDetainedLicenses.MultiSelect = false;
            this.dataGridViewDetainedLicenses.Name = "dataGridViewDetainedLicenses";
            this.dataGridViewDetainedLicenses.ReadOnly = true;
            this.dataGridViewDetainedLicenses.RowHeadersWidth = 62;
            this.dataGridViewDetainedLicenses.RowTemplate.Height = 29;
            this.dataGridViewDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetainedLicenses.Size = new System.Drawing.Size(1201, 324);
            this.dataGridViewDetainedLicenses.TabIndex = 2;
            // 
            // pictureBoxDetainLicence
            // 
            this.pictureBoxDetainLicence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDetainLicence.Image = global::DVLD.Presentation.Properties.Resources.Detain_512;
            this.pictureBoxDetainLicence.Location = new System.Drawing.Point(1090, 155);
            this.pictureBoxDetainLicence.Name = "pictureBoxDetainLicence";
            this.pictureBoxDetainLicence.Size = new System.Drawing.Size(123, 108);
            this.pictureBoxDetainLicence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetainLicence.TabIndex = 3;
            this.pictureBoxDetainLicence.TabStop = false;
            this.pictureBoxDetainLicence.Click += new System.EventHandler(this.pictureBoxDetainLicence_Click);
            // 
            // pictureBoxReleaseLicense
            // 
            this.pictureBoxReleaseLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxReleaseLicense.Image = global::DVLD.Presentation.Properties.Resources.Release_Detained_License_512;
            this.pictureBoxReleaseLicense.Location = new System.Drawing.Point(948, 155);
            this.pictureBoxReleaseLicense.Name = "pictureBoxReleaseLicense";
            this.pictureBoxReleaseLicense.Size = new System.Drawing.Size(136, 108);
            this.pictureBoxReleaseLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReleaseLicense.TabIndex = 4;
            this.pictureBoxReleaseLicense.TabStop = false;
            this.pictureBoxReleaseLicense.Click += new System.EventHandler(this.pictureBoxReleaseLicense_Click);
            // 
            // textBoxFilterManageDetainedLicenses
            // 
            this.textBoxFilterManageDetainedLicenses.Location = new System.Drawing.Point(292, 226);
            this.textBoxFilterManageDetainedLicenses.Name = "textBoxFilterManageDetainedLicenses";
            this.textBoxFilterManageDetainedLicenses.Size = new System.Drawing.Size(141, 27);
            this.textBoxFilterManageDetainedLicenses.TabIndex = 5;
            this.textBoxFilterManageDetainedLicenses.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter By :";
            // 
            // comboBoxFilterManageDetainedLicenses
            // 
            this.comboBoxFilterManageDetainedLicenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFilterManageDetainedLicenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterManageDetainedLicenses.FormattingEnabled = true;
            this.comboBoxFilterManageDetainedLicenses.Items.AddRange(new object[] {
            "None",
            "National No.",
            "License ID",
            "Full Name"});
            this.comboBoxFilterManageDetainedLicenses.Location = new System.Drawing.Point(139, 226);
            this.comboBoxFilterManageDetainedLicenses.Name = "comboBoxFilterManageDetainedLicenses";
            this.comboBoxFilterManageDetainedLicenses.Size = new System.Drawing.Size(138, 27);
            this.comboBoxFilterManageDetainedLicenses.TabIndex = 7;
            this.comboBoxFilterManageDetainedLicenses.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterManageDetainedLicenses_SelectedIndexChanged);
            // 
            // buttonCloseFrm
            // 
            this.buttonCloseFrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseFrm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.buttonCloseFrm.Location = new System.Drawing.Point(1036, 600);
            this.buttonCloseFrm.Name = "buttonCloseFrm";
            this.buttonCloseFrm.Size = new System.Drawing.Size(177, 61);
            this.buttonCloseFrm.TabIndex = 8;
            this.buttonCloseFrm.Text = "Close";
            this.buttonCloseFrm.UseVisualStyleBackColor = true;
            this.buttonCloseFrm.Click += new System.EventHandler(this.buttonCloseFrm_Click);
            // 
            // FrmManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1225, 682);
            this.Controls.Add(this.buttonCloseFrm);
            this.Controls.Add(this.comboBoxFilterManageDetainedLicenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFilterManageDetainedLicenses);
            this.Controls.Add(this.pictureBoxReleaseLicense);
            this.Controls.Add(this.pictureBoxDetainLicence);
            this.Controls.Add(this.dataGridViewDetainedLicenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmManageDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Detained Licenses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetainedLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetainLicence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReleaseLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDetainedLicenses;
        private System.Windows.Forms.PictureBox pictureBoxDetainLicence;
        private System.Windows.Forms.PictureBox pictureBoxReleaseLicense;
        private System.Windows.Forms.TextBox textBoxFilterManageDetainedLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFilterManageDetainedLicenses;
        private System.Windows.Forms.Button buttonCloseFrm;
    }
}