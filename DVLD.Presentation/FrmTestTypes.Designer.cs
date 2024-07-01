namespace DVLD.Presentation
{
    partial class FrmTestTypes
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
            this.LbltestTypesTitleForm = new System.Windows.Forms.Label();
            this.DataGridViewTestTypes = new System.Windows.Forms.DataGridView();
            this.LblTestTypesRecordsValue = new System.Windows.Forms.Label();
            this.LbltestTypesRecords = new System.Windows.Forms.Label();
            this.ButtonCloseTestTypesForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTestTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LbltestTypesTitleForm
            // 
            this.LbltestTypesTitleForm.AutoSize = true;
            this.LbltestTypesTitleForm.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltestTypesTitleForm.Location = new System.Drawing.Point(293, 111);
            this.LbltestTypesTitleForm.Name = "LbltestTypesTitleForm";
            this.LbltestTypesTitleForm.Size = new System.Drawing.Size(266, 35);
            this.LbltestTypesTitleForm.TabIndex = 1;
            this.LbltestTypesTitleForm.Text = "Manage Test Types";
            // 
            // DataGridViewTestTypes
            // 
            this.DataGridViewTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTestTypes.Location = new System.Drawing.Point(12, 182);
            this.DataGridViewTestTypes.MultiSelect = false;
            this.DataGridViewTestTypes.Name = "DataGridViewTestTypes";
            this.DataGridViewTestTypes.RowHeadersWidth = 51;
            this.DataGridViewTestTypes.RowTemplate.Height = 24;
            this.DataGridViewTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTestTypes.Size = new System.Drawing.Size(793, 275);
            this.DataGridViewTestTypes.TabIndex = 2;
            // 
            // LblTestTypesRecordsValue
            // 
            this.LblTestTypesRecordsValue.AutoSize = true;
            this.LblTestTypesRecordsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestTypesRecordsValue.Location = new System.Drawing.Point(113, 485);
            this.LblTestTypesRecordsValue.Name = "LblTestTypesRecordsValue";
            this.LblTestTypesRecordsValue.Size = new System.Drawing.Size(17, 25);
            this.LblTestTypesRecordsValue.TabIndex = 14;
            this.LblTestTypesRecordsValue.Text = ".";
            // 
            // LbltestTypesRecords
            // 
            this.LbltestTypesRecords.AutoSize = true;
            this.LbltestTypesRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltestTypesRecords.Location = new System.Drawing.Point(12, 485);
            this.LbltestTypesRecords.Name = "LbltestTypesRecords";
            this.LbltestTypesRecords.Size = new System.Drawing.Size(95, 25);
            this.LbltestTypesRecords.TabIndex = 13;
            this.LbltestTypesRecords.Text = "#Records";
            // 
            // ButtonCloseTestTypesForm
            // 
            this.ButtonCloseTestTypesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseTestTypesForm.Location = new System.Drawing.Point(667, 463);
            this.ButtonCloseTestTypesForm.Name = "ButtonCloseTestTypesForm";
            this.ButtonCloseTestTypesForm.Size = new System.Drawing.Size(138, 53);
            this.ButtonCloseTestTypesForm.TabIndex = 12;
            this.ButtonCloseTestTypesForm.Text = "Close";
            this.ButtonCloseTestTypesForm.UseVisualStyleBackColor = true;
            this.ButtonCloseTestTypesForm.Click += new System.EventHandler(this.ButtonCloseTestTypesForm_Click);
            // 
            // FrmTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 542);
            this.Controls.Add(this.LblTestTypesRecordsValue);
            this.Controls.Add(this.LbltestTypesRecords);
            this.Controls.Add(this.ButtonCloseTestTypesForm);
            this.Controls.Add(this.DataGridViewTestTypes);
            this.Controls.Add(this.LbltestTypesTitleForm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Types";
            this.Load += new System.EventHandler(this.FrmTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTestTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LbltestTypesTitleForm;
        private System.Windows.Forms.DataGridView DataGridViewTestTypes;
        private System.Windows.Forms.Label LblTestTypesRecordsValue;
        private System.Windows.Forms.Label LbltestTypesRecords;
        private System.Windows.Forms.Button ButtonCloseTestTypesForm;
    }
}