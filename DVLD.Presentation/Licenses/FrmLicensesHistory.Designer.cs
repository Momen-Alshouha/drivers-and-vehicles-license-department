namespace DVLD.Presentation.Licenses
{
    partial class FrmLicensesHistory
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLicenseHistoryCloseForm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLocalLicenseHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.tabPageInternationalLicenseHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewInternationalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.contextMenuStripLicensesHistoryFormShowLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlPersonDetailsWithFilter1 = new DVLD.Presentation.People.Controls.CtrlPersonDetailsWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageLocalLicenseHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalLicensesHistory)).BeginInit();
            this.tabPageInternationalLicenseHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInternationalLicensesHistory)).BeginInit();
            this.contextMenuStripLicensesHistoryFormShowLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(534, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Licenses History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(41, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLicenseHistoryCloseForm
            // 
            this.BtnLicenseHistoryCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLicenseHistoryCloseForm.Location = new System.Drawing.Point(1184, 818);
            this.BtnLicenseHistoryCloseForm.Name = "BtnLicenseHistoryCloseForm";
            this.BtnLicenseHistoryCloseForm.Size = new System.Drawing.Size(139, 69);
            this.BtnLicenseHistoryCloseForm.TabIndex = 3;
            this.BtnLicenseHistoryCloseForm.Text = "Close";
            this.BtnLicenseHistoryCloseForm.UseVisualStyleBackColor = true;
            this.BtnLicenseHistoryCloseForm.Click += new System.EventHandler(this.BtnLicenseHistoryCloseForm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLocalLicenseHistory);
            this.tabControl1.Controls.Add(this.tabPageInternationalLicenseHistory);
            this.tabControl1.Location = new System.Drawing.Point(41, 569);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 317);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageLocalLicenseHistory
            // 
            this.tabPageLocalLicenseHistory.Controls.Add(this.dataGridViewLocalLicensesHistory);
            this.tabPageLocalLicenseHistory.Location = new System.Drawing.Point(4, 28);
            this.tabPageLocalLicenseHistory.Name = "tabPageLocalLicenseHistory";
            this.tabPageLocalLicenseHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocalLicenseHistory.Size = new System.Drawing.Size(1088, 285);
            this.tabPageLocalLicenseHistory.TabIndex = 0;
            this.tabPageLocalLicenseHistory.Text = "Local";
            this.tabPageLocalLicenseHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLocalLicensesHistory
            // 
            this.dataGridViewLocalLicensesHistory.AllowUserToAddRows = false;
            this.dataGridViewLocalLicensesHistory.AllowUserToDeleteRows = false;
            this.dataGridViewLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalLicensesHistory.Location = new System.Drawing.Point(6, 4);
            this.dataGridViewLocalLicensesHistory.Name = "dataGridViewLocalLicensesHistory";
            this.dataGridViewLocalLicensesHistory.ReadOnly = true;
            this.dataGridViewLocalLicensesHistory.RowHeadersWidth = 62;
            this.dataGridViewLocalLicensesHistory.RowTemplate.Height = 29;
            this.dataGridViewLocalLicensesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLocalLicensesHistory.Size = new System.Drawing.Size(1076, 276);
            this.dataGridViewLocalLicensesHistory.TabIndex = 0;
            this.dataGridViewLocalLicensesHistory.SelectionChanged += new System.EventHandler(this.dataGridViewLocalLicensesHistory_SelectionChanged);
            // 
            // tabPageInternationalLicenseHistory
            // 
            this.tabPageInternationalLicenseHistory.Controls.Add(this.dataGridViewInternationalLicensesHistory);
            this.tabPageInternationalLicenseHistory.Location = new System.Drawing.Point(4, 28);
            this.tabPageInternationalLicenseHistory.Name = "tabPageInternationalLicenseHistory";
            this.tabPageInternationalLicenseHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInternationalLicenseHistory.Size = new System.Drawing.Size(1088, 285);
            this.tabPageInternationalLicenseHistory.TabIndex = 1;
            this.tabPageInternationalLicenseHistory.Text = "International";
            this.tabPageInternationalLicenseHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInternationalLicensesHistory
            // 
            this.dataGridViewInternationalLicensesHistory.AllowUserToAddRows = false;
            this.dataGridViewInternationalLicensesHistory.AllowUserToDeleteRows = false;
            this.dataGridViewInternationalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInternationalLicensesHistory.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewInternationalLicensesHistory.Name = "dataGridViewInternationalLicensesHistory";
            this.dataGridViewInternationalLicensesHistory.ReadOnly = true;
            this.dataGridViewInternationalLicensesHistory.RowHeadersWidth = 62;
            this.dataGridViewInternationalLicensesHistory.RowTemplate.Height = 29;
            this.dataGridViewInternationalLicensesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInternationalLicensesHistory.Size = new System.Drawing.Size(1076, 273);
            this.dataGridViewInternationalLicensesHistory.TabIndex = 0;
            // 
            // contextMenuStripLicensesHistoryFormShowLicense
            // 
            this.contextMenuStripLicensesHistoryFormShowLicense.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripLicensesHistoryFormShowLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.contextMenuStripLicensesHistoryFormShowLicense.Name = "contextMenuStripLicensesHistoryFormShowLicense";
            this.contextMenuStripLicensesHistoryFormShowLicense.Size = new System.Drawing.Size(243, 44);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Presentation.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(256, 40);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // ctrlPersonDetailsWithFilter1
            // 
            this.ctrlPersonDetailsWithFilter1.Location = new System.Drawing.Point(324, 94);
            this.ctrlPersonDetailsWithFilter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlPersonDetailsWithFilter1.Name = "ctrlPersonDetailsWithFilter1";
            this.ctrlPersonDetailsWithFilter1.Size = new System.Drawing.Size(942, 471);
            this.ctrlPersonDetailsWithFilter1.TabIndex = 6;
            // 
            // FrmLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1335, 956);
            this.Controls.Add(this.ctrlPersonDetailsWithFilter1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnLicenseHistoryCloseForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Licenses History";
            this.Load += new System.EventHandler(this.FrmLicensesHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageLocalLicenseHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalLicensesHistory)).EndInit();
            this.tabPageInternationalLicenseHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInternationalLicensesHistory)).EndInit();
            this.contextMenuStripLicensesHistoryFormShowLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLicenseHistoryCloseForm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLocalLicenseHistory;
        private System.Windows.Forms.DataGridView dataGridViewLocalLicensesHistory;
        private System.Windows.Forms.TabPage tabPageInternationalLicenseHistory;
        private System.Windows.Forms.DataGridView dataGridViewInternationalLicensesHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLicensesHistoryFormShowLicense;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private People.Controls.CtrlPersonDetailsWithFilter ctrlPersonDetailsWithFilter1;
    }
}