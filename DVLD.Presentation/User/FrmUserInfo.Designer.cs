namespace DVLD.Presentation.User
{
    partial class FrmUserInfo
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
            this.ButtonCloseUserInfoForm = new System.Windows.Forms.Button();
            this.ctrlUserCard1 = new DVLD.Presentation.Controls.CtrlUserCard();
            this.SuspendLayout();
            // 
            // ButtonCloseUserInfoForm
            // 
            this.ButtonCloseUserInfoForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseUserInfoForm.Location = new System.Drawing.Point(675, 445);
            this.ButtonCloseUserInfoForm.Name = "ButtonCloseUserInfoForm";
            this.ButtonCloseUserInfoForm.Size = new System.Drawing.Size(164, 57);
            this.ButtonCloseUserInfoForm.TabIndex = 1;
            this.ButtonCloseUserInfoForm.Text = "Close";
            this.ButtonCloseUserInfoForm.UseVisualStyleBackColor = true;
            this.ButtonCloseUserInfoForm.Click += new System.EventHandler(this.ButtonCloseUserInfoForm_Click);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.Location = new System.Drawing.Point(4, 12);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(835, 427);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 526);
            this.Controls.Add(this.ButtonCloseUserInfoForm);
            this.Controls.Add(this.ctrlUserCard1);
            this.Name = "FrmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CtrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Button ButtonCloseUserInfoForm;
    }
}