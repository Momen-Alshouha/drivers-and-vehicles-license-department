namespace DVLD.Presentation.Drivers
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCloseDriversForm = new System.Windows.Forms.Button();
            this.DataGridViewDrivers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(532, 12);
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
            this.label1.Location = new System.Drawing.Point(550, 174);
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
            this.DataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDrivers.Location = new System.Drawing.Point(12, 279);
            this.DataGridViewDrivers.Name = "DataGridViewDrivers";
            this.DataGridViewDrivers.ReadOnly = true;
            this.DataGridViewDrivers.RowHeadersWidth = 62;
            this.DataGridViewDrivers.RowTemplate.Height = 29;
            this.DataGridViewDrivers.Size = new System.Drawing.Size(1052, 275);
            this.DataGridViewDrivers.TabIndex = 3;
            // 
            // FrmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1091, 638);
            this.Controls.Add(this.DataGridViewDrivers);
            this.Controls.Add(this.BtnCloseDriversForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drivers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCloseDriversForm;
        private System.Windows.Forms.DataGridView DataGridViewDrivers;
    }
}