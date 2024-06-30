namespace DVLD.Presentation.User
{
    partial class FrmAddUpdateUser
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
            this.TabControlUser = new System.Windows.Forms.TabControl();
            this.TabPersonalInfo = new System.Windows.Forms.TabPage();
            this.ButtonNextAddEditUser = new System.Windows.Forms.Button();
            this.TabLoginInfo = new System.Windows.Forms.TabPage();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckBoxIsActive = new System.Windows.Forms.CheckBox();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonNextAddUserForm = new System.Windows.Forms.Button();
            this.ButtonCloseAddUserForm = new System.Windows.Forms.Button();
            this.ButtonSaveAddUserForm = new System.Windows.Forms.Button();
            this.LblAddNewUserFormTitle = new System.Windows.Forms.Label();
            this.ctrlUserDetailsWithFilter2 = new DVLD.Presentation.People.Controls.CtrlPersonDetailsWithFilter();
            this.TabControlUser.SuspendLayout();
            this.TabPersonalInfo.SuspendLayout();
            this.TabLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlUser
            // 
            this.TabControlUser.Controls.Add(this.TabPersonalInfo);
            this.TabControlUser.Controls.Add(this.TabLoginInfo);
            this.TabControlUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlUser.Location = new System.Drawing.Point(12, 109);
            this.TabControlUser.Name = "TabControlUser";
            this.TabControlUser.SelectedIndex = 0;
            this.TabControlUser.Size = new System.Drawing.Size(877, 543);
            this.TabControlUser.TabIndex = 1;
            // 
            // TabPersonalInfo
            // 
            this.TabPersonalInfo.Controls.Add(this.ButtonNextAddEditUser);
            this.TabPersonalInfo.Controls.Add(this.ctrlUserDetailsWithFilter2);
            this.TabPersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.TabPersonalInfo.Name = "TabPersonalInfo";
            this.TabPersonalInfo.Size = new System.Drawing.Size(869, 514);
            this.TabPersonalInfo.TabIndex = 0;
            this.TabPersonalInfo.Text = "Personal Info";
            this.TabPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ButtonNextAddEditUser
            // 
            this.ButtonNextAddEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNextAddEditUser.Location = new System.Drawing.Point(672, 445);
            this.ButtonNextAddEditUser.Name = "ButtonNextAddEditUser";
            this.ButtonNextAddEditUser.Size = new System.Drawing.Size(169, 56);
            this.ButtonNextAddEditUser.TabIndex = 3;
            this.ButtonNextAddEditUser.Text = "Next";
            this.ButtonNextAddEditUser.UseVisualStyleBackColor = true;
            this.ButtonNextAddEditUser.Click += new System.EventHandler(this.ButtonNextAddEditUser_Click);
            // 
            // TabLoginInfo
            // 
            this.TabLoginInfo.Controls.Add(this.lblUserID);
            this.TabLoginInfo.Controls.Add(this.label4);
            this.TabLoginInfo.Controls.Add(this.CheckBoxIsActive);
            this.TabLoginInfo.Controls.Add(this.TextBoxUserName);
            this.TabLoginInfo.Controls.Add(this.TextBoxConfirmPassword);
            this.TabLoginInfo.Controls.Add(this.label1);
            this.TabLoginInfo.Controls.Add(this.label3);
            this.TabLoginInfo.Controls.Add(this.label2);
            this.TabLoginInfo.Controls.Add(this.TextBoxPassword);
            this.TabLoginInfo.Location = new System.Drawing.Point(4, 25);
            this.TabLoginInfo.Name = "TabLoginInfo";
            this.TabLoginInfo.Size = new System.Drawing.Size(869, 514);
            this.TabLoginInfo.TabIndex = 1;
            this.TabLoginInfo.Text = "Login Info";
            this.TabLoginInfo.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(229, 50);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 25);
            this.lblUserID.TabIndex = 142;
            this.lblUserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 141;
            this.label4.Text = "UserID:";
            // 
            // CheckBoxIsActive
            // 
            this.CheckBoxIsActive.AutoSize = true;
            this.CheckBoxIsActive.Checked = true;
            this.CheckBoxIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxIsActive.Location = new System.Drawing.Point(244, 206);
            this.CheckBoxIsActive.Name = "CheckBoxIsActive";
            this.CheckBoxIsActive.Size = new System.Drawing.Size(82, 21);
            this.CheckBoxIsActive.TabIndex = 140;
            this.CheckBoxIsActive.Text = "Is Active";
            this.CheckBoxIsActive.UseVisualStyleBackColor = true;
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Location = new System.Drawing.Point(227, 88);
            this.TextBoxUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxUserName.MaxLength = 50;
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(167, 23);
            this.TextBoxUserName.TabIndex = 131;
            // 
            // TextBoxConfirmPassword
            // 
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(227, 160);
            this.TextBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxConfirmPassword.MaxLength = 50;
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.PasswordChar = '*';
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(167, 23);
            this.TextBoxConfirmPassword.TabIndex = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 133;
            this.label1.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 138;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 134;
            this.label2.Text = "Password:";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(227, 124);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxPassword.MaxLength = 50;
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(167, 23);
            this.TextBoxPassword.TabIndex = 132;
            // 
            // ButtonNextAddUserForm
            // 
            this.ButtonNextAddUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNextAddUserForm.Location = new System.Drawing.Point(661, 431);
            this.ButtonNextAddUserForm.Name = "ButtonNextAddUserForm";
            this.ButtonNextAddUserForm.Size = new System.Drawing.Size(169, 56);
            this.ButtonNextAddUserForm.TabIndex = 1;
            this.ButtonNextAddUserForm.Text = "Next";
            this.ButtonNextAddUserForm.UseVisualStyleBackColor = true;
            // 
            // ButtonCloseAddUserForm
            // 
            this.ButtonCloseAddUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseAddUserForm.Location = new System.Drawing.Point(494, 682);
            this.ButtonCloseAddUserForm.Name = "ButtonCloseAddUserForm";
            this.ButtonCloseAddUserForm.Size = new System.Drawing.Size(169, 56);
            this.ButtonCloseAddUserForm.TabIndex = 2;
            this.ButtonCloseAddUserForm.Text = "Close";
            this.ButtonCloseAddUserForm.UseVisualStyleBackColor = true;
            this.ButtonCloseAddUserForm.Click += new System.EventHandler(this.ButtonCloseAddUserForm_Click);
            // 
            // ButtonSaveAddUserForm
            // 
            this.ButtonSaveAddUserForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSaveAddUserForm.Enabled = false;
            this.ButtonSaveAddUserForm.Location = new System.Drawing.Point(669, 682);
            this.ButtonSaveAddUserForm.Name = "ButtonSaveAddUserForm";
            this.ButtonSaveAddUserForm.Size = new System.Drawing.Size(169, 56);
            this.ButtonSaveAddUserForm.TabIndex = 3;
            this.ButtonSaveAddUserForm.Text = "Save";
            this.ButtonSaveAddUserForm.UseVisualStyleBackColor = true;
            this.ButtonSaveAddUserForm.Click += new System.EventHandler(this.ButtonSaveAddUserForm_Click);
            // 
            // LblAddNewUserFormTitle
            // 
            this.LblAddNewUserFormTitle.AutoSize = true;
            this.LblAddNewUserFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddNewUserFormTitle.Location = new System.Drawing.Point(301, 46);
            this.LblAddNewUserFormTitle.Name = "LblAddNewUserFormTitle";
            this.LblAddNewUserFormTitle.Size = new System.Drawing.Size(340, 46);
            this.LblAddNewUserFormTitle.TabIndex = 5;
            this.LblAddNewUserFormTitle.Text = "Add/Update User";
            // 
            // ctrlUserDetailsWithFilter2
            // 
            this.ctrlUserDetailsWithFilter2.Location = new System.Drawing.Point(14, 12);
            this.ctrlUserDetailsWithFilter2.Name = "ctrlUserDetailsWithFilter2";
            this.ctrlUserDetailsWithFilter2.Size = new System.Drawing.Size(839, 427);
            this.ctrlUserDetailsWithFilter2.TabIndex = 0;
            // 
            // FrmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 750);
            this.Controls.Add(this.LblAddNewUserFormTitle);
            this.Controls.Add(this.ButtonSaveAddUserForm);
            this.Controls.Add(this.TabControlUser);
            this.Controls.Add(this.ButtonCloseAddUserForm);
            this.Name = "FrmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Update User";
            this.Load += new System.EventHandler(this.FrmAddUpdateUser_Load);
            this.TabControlUser.ResumeLayout(false);
            this.TabPersonalInfo.ResumeLayout(false);
            this.TabLoginInfo.ResumeLayout(false);
            this.TabLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlUser;
        private People.Controls.CtrlPersonDetailsWithFilter ctrlUserDetailsWithFilter1;
        private System.Windows.Forms.Button ButtonNextAddUserForm;
        private System.Windows.Forms.Button ButtonCloseAddUserForm;
        private System.Windows.Forms.Button ButtonSaveAddUserForm;
        private System.Windows.Forms.Label LblAddNewUserFormTitle;
        private System.Windows.Forms.TabPage TabPersonalInfo;
        private System.Windows.Forms.Button ButtonNextAddEditUser;
        private People.Controls.CtrlPersonDetailsWithFilter ctrlUserDetailsWithFilter2;
        private System.Windows.Forms.TabPage TabLoginInfo;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBoxIsActive;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxPassword;
    }
}