namespace DVLD.Presentation.User
{
    partial class FrmChangePassword
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
            this.ctrlUserCard1 = new DVLD.Presentation.Controls.CtrlUserCard();
            this.LblCurrentPassword = new System.Windows.Forms.Label();
            this.TxtCurrentPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.LblConfirmPassword = new System.Windows.Forms.Label();
            this.LblNewPassword = new System.Windows.Forms.Label();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.Location = new System.Drawing.Point(12, 12);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(835, 427);
            this.ctrlUserCard1.TabIndex = 0;
            // 
            // LblCurrentPassword
            // 
            this.LblCurrentPassword.AutoSize = true;
            this.LblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentPassword.Location = new System.Drawing.Point(25, 430);
            this.LblCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCurrentPassword.Name = "LblCurrentPassword";
            this.LblCurrentPassword.Size = new System.Drawing.Size(191, 25);
            this.LblCurrentPassword.TabIndex = 147;
            this.LblCurrentPassword.Text = "Current Password:";
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.Location = new System.Drawing.Point(239, 430);
            this.TxtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCurrentPassword.MaxLength = 50;
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.PasswordChar = '*';
            this.TxtCurrentPassword.Size = new System.Drawing.Size(167, 22);
            this.TxtCurrentPassword.TabIndex = 138;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(568, 602);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 142;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(702, 602);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 141;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(239, 502);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConfirmPassword.MaxLength = 50;
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.Size = new System.Drawing.Size(167, 22);
            this.TxtConfirmPassword.TabIndex = 140;
            // 
            // LblConfirmPassword
            // 
            this.LblConfirmPassword.AutoSize = true;
            this.LblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmPassword.Location = new System.Drawing.Point(23, 502);
            this.LblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblConfirmPassword.Name = "LblConfirmPassword";
            this.LblConfirmPassword.Size = new System.Drawing.Size(194, 25);
            this.LblConfirmPassword.TabIndex = 145;
            this.LblConfirmPassword.Text = "Confirm Password:";
            // 
            // LblNewPassword
            // 
            this.LblNewPassword.AutoSize = true;
            this.LblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNewPassword.Location = new System.Drawing.Point(51, 466);
            this.LblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNewPassword.Name = "LblNewPassword";
            this.LblNewPassword.Size = new System.Drawing.Size(161, 25);
            this.LblNewPassword.TabIndex = 143;
            this.LblNewPassword.Text = "New Password:";
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Location = new System.Drawing.Point(239, 466);
            this.TxtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNewPassword.MaxLength = 50;
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '*';
            this.TxtNewPassword.Size = new System.Drawing.Size(167, 22);
            this.TxtNewPassword.TabIndex = 139;
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 651);
            this.Controls.Add(this.LblCurrentPassword);
            this.Controls.Add(this.TxtCurrentPassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.LblConfirmPassword);
            this.Controls.Add(this.LblNewPassword);
            this.Controls.Add(this.TxtNewPassword);
            this.Controls.Add(this.ctrlUserCard1);
            this.Name = "FrmChangePassword";
            this.Text = "FrmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CtrlUserCard ctrlUserCard1;
        private System.Windows.Forms.Label LblCurrentPassword;
        private System.Windows.Forms.TextBox TxtCurrentPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.Label LblConfirmPassword;
        private System.Windows.Forms.Label LblNewPassword;
        private System.Windows.Forms.TextBox TxtNewPassword;
    }
}