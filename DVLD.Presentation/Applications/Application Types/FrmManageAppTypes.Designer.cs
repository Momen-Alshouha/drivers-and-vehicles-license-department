namespace DVLD.Presentation.Application_Types
{
    partial class FrmManageAppTypes
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
            this.LblManageAppTypesTitle = new System.Windows.Forms.Label();
            this.DataGridViewAppTypes = new System.Windows.Forms.DataGridView();
            this.LblAppTypesRecords = new System.Windows.Forms.Label();
            this.LblAppTypesRecordsValue = new System.Windows.Forms.Label();
            this.ButtonCloseAppTypesForm = new System.Windows.Forms.Button();
            this.ContextMenuAppTypesForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAppTypes)).BeginInit();
            this.ContextMenuAppTypesForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblManageAppTypesTitle
            // 
            this.LblManageAppTypesTitle.AutoSize = true;
            this.LblManageAppTypesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManageAppTypesTitle.Location = new System.Drawing.Point(209, 134);
            this.LblManageAppTypesTitle.Name = "LblManageAppTypesTitle";
            this.LblManageAppTypesTitle.Size = new System.Drawing.Size(292, 38);
            this.LblManageAppTypesTitle.TabIndex = 8;
            this.LblManageAppTypesTitle.Text = "Application Types";
            // 
            // DataGridViewAppTypes
            // 
            this.DataGridViewAppTypes.AllowUserToAddRows = false;
            this.DataGridViewAppTypes.AllowUserToDeleteRows = false;
            this.DataGridViewAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAppTypes.Location = new System.Drawing.Point(12, 211);
            this.DataGridViewAppTypes.MultiSelect = false;
            this.DataGridViewAppTypes.Name = "DataGridViewAppTypes";
            this.DataGridViewAppTypes.ReadOnly = true;
            this.DataGridViewAppTypes.RowHeadersWidth = 51;
            this.DataGridViewAppTypes.RowTemplate.Height = 24;
            this.DataGridViewAppTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAppTypes.Size = new System.Drawing.Size(663, 250);
            this.DataGridViewAppTypes.TabIndex = 9;
            // 
            // LblAppTypesRecords
            // 
            this.LblAppTypesRecords.AutoSize = true;
            this.LblAppTypesRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppTypesRecords.Location = new System.Drawing.Point(12, 484);
            this.LblAppTypesRecords.Name = "LblAppTypesRecords";
            this.LblAppTypesRecords.Size = new System.Drawing.Size(106, 25);
            this.LblAppTypesRecords.TabIndex = 11;
            this.LblAppTypesRecords.Text = "#Records :";
            // 
            // LblAppTypesRecordsValue
            // 
            this.LblAppTypesRecordsValue.AutoSize = true;
            this.LblAppTypesRecordsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppTypesRecordsValue.Location = new System.Drawing.Point(113, 484);
            this.LblAppTypesRecordsValue.Name = "LblAppTypesRecordsValue";
            this.LblAppTypesRecordsValue.Size = new System.Drawing.Size(17, 25);
            this.LblAppTypesRecordsValue.TabIndex = 12;
            this.LblAppTypesRecordsValue.Text = ".";
            // 
            // ButtonCloseAppTypesForm
            // 
            this.ButtonCloseAppTypesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseAppTypesForm.Location = new System.Drawing.Point(538, 469);
            this.ButtonCloseAppTypesForm.Name = "ButtonCloseAppTypesForm";
            this.ButtonCloseAppTypesForm.Size = new System.Drawing.Size(137, 52);
            this.ButtonCloseAppTypesForm.TabIndex = 13;
            this.ButtonCloseAppTypesForm.Text = "Close";
            this.ButtonCloseAppTypesForm.UseVisualStyleBackColor = true;
            this.ButtonCloseAppTypesForm.Click += new System.EventHandler(this.ButtonCloseAppTypesForm_Click);
            // 
            // ContextMenuAppTypesForm
            // 
            this.ContextMenuAppTypesForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuAppTypesForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypeToolStripMenuItem});
            this.ContextMenuAppTypesForm.Name = "ContextMenuAppTypesForm";
            this.ContextMenuAppTypesForm.Size = new System.Drawing.Size(221, 28);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.editApplicationTypeToolStripMenuItem.Text = "Edit Application Type";
            this.editApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(297, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManageAppTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 532);
            this.Controls.Add(this.ButtonCloseAppTypesForm);
            this.Controls.Add(this.LblAppTypesRecordsValue);
            this.Controls.Add(this.LblAppTypesRecords);
            this.Controls.Add(this.DataGridViewAppTypes);
            this.Controls.Add(this.LblManageAppTypesTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmManageAppTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Types";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAppTypes)).EndInit();
            this.ContextMenuAppTypesForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblManageAppTypesTitle;
        private System.Windows.Forms.DataGridView DataGridViewAppTypes;
        private System.Windows.Forms.Label LblAppTypesRecords;
        private System.Windows.Forms.Label LblAppTypesRecordsValue;
        private System.Windows.Forms.Button ButtonCloseAppTypesForm;
        private System.Windows.Forms.ContextMenuStrip ContextMenuAppTypesForm;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
    }
}