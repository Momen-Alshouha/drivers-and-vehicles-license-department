namespace DVLD.Presentation.Application_Types
{
    partial class FrmEditAppType
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
            this.LblEditAppTypeTitle = new System.Windows.Forms.Label();
            this.TxtAppTypeFeesEditForm = new System.Windows.Forms.TextBox();
            this.LblFees = new System.Windows.Forms.Label();
            this.LblAppTypeTitle = new System.Windows.Forms.Label();
            this.TxtAppTypeTitleEditForm = new System.Windows.Forms.TextBox();
            this.ButtonEditAppTypesSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEditAppTypeTitle
            // 
            this.LblEditAppTypeTitle.AutoSize = true;
            this.LblEditAppTypeTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEditAppTypeTitle.Location = new System.Drawing.Point(44, 74);
            this.LblEditAppTypeTitle.Name = "LblEditAppTypeTitle";
            this.LblEditAppTypeTitle.Size = new System.Drawing.Size(259, 31);
            this.LblEditAppTypeTitle.TabIndex = 0;
            this.LblEditAppTypeTitle.Text = "Edit Application Type";
            this.LblEditAppTypeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAppTypeFeesEditForm
            // 
            this.TxtAppTypeFeesEditForm.Location = new System.Drawing.Point(86, 150);
            this.TxtAppTypeFeesEditForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAppTypeFeesEditForm.MaxLength = 50;
            this.TxtAppTypeFeesEditForm.Name = "TxtAppTypeFeesEditForm";
            this.TxtAppTypeFeesEditForm.Size = new System.Drawing.Size(265, 22);
            this.TxtAppTypeFeesEditForm.TabIndex = 150;
            // 
            // LblFees
            // 
            this.LblFees.AutoSize = true;
            this.LblFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFees.Location = new System.Drawing.Point(18, 150);
            this.LblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFees.Name = "LblFees";
            this.LblFees.Size = new System.Drawing.Size(60, 25);
            this.LblFees.TabIndex = 152;
            this.LblFees.Text = "Fees";
            // 
            // LblAppTypeTitle
            // 
            this.LblAppTypeTitle.AutoSize = true;
            this.LblAppTypeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAppTypeTitle.Location = new System.Drawing.Point(24, 115);
            this.LblAppTypeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAppTypeTitle.Name = "LblAppTypeTitle";
            this.LblAppTypeTitle.Size = new System.Drawing.Size(54, 25);
            this.LblAppTypeTitle.TabIndex = 151;
            this.LblAppTypeTitle.Text = "Title";
            // 
            // TxtAppTypeTitleEditForm
            // 
            this.TxtAppTypeTitleEditForm.Location = new System.Drawing.Point(86, 118);
            this.TxtAppTypeTitleEditForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAppTypeTitleEditForm.MaxLength = 50;
            this.TxtAppTypeTitleEditForm.Name = "TxtAppTypeTitleEditForm";
            this.TxtAppTypeTitleEditForm.Size = new System.Drawing.Size(265, 22);
            this.TxtAppTypeTitleEditForm.TabIndex = 149;
            // 
            // ButtonEditAppTypesSave
            // 
            this.ButtonEditAppTypesSave.Location = new System.Drawing.Point(226, 180);
            this.ButtonEditAppTypesSave.Name = "ButtonEditAppTypesSave";
            this.ButtonEditAppTypesSave.Size = new System.Drawing.Size(125, 54);
            this.ButtonEditAppTypesSave.TabIndex = 153;
            this.ButtonEditAppTypesSave.Text = "Save";
            this.ButtonEditAppTypesSave.UseVisualStyleBackColor = true;
            this.ButtonEditAppTypesSave.Click += new System.EventHandler(this.ButtonEditAppTypesSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.Application_Types_64;
            this.pictureBox1.Location = new System.Drawing.Point(153, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // FrmEditAppType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonEditAppTypesSave);
            this.Controls.Add(this.TxtAppTypeFeesEditForm);
            this.Controls.Add(this.LblFees);
            this.Controls.Add(this.LblAppTypeTitle);
            this.Controls.Add(this.TxtAppTypeTitleEditForm);
            this.Controls.Add(this.LblEditAppTypeTitle);
            this.Name = "FrmEditAppType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Application Type";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEditAppTypeTitle;
        private System.Windows.Forms.TextBox TxtAppTypeFeesEditForm;
        private System.Windows.Forms.Label LblFees;
        private System.Windows.Forms.Label LblAppTypeTitle;
        private System.Windows.Forms.TextBox TxtAppTypeTitleEditForm;
        private System.Windows.Forms.Button ButtonEditAppTypesSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}