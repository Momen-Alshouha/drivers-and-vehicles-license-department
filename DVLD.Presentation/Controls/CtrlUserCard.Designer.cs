namespace DVLD.Presentation.Controls
{
    partial class CtrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CtrlPersonDetails1 = new DVLD.Presentation.People.Controls.CtrlPersonDetails();
            this.GroupBoxUserCardLoginInfo = new System.Windows.Forms.GroupBox();
            this.LblUserIsActiveValue = new System.Windows.Forms.Label();
            this.LblUserIsActive = new System.Windows.Forms.Label();
            this.LblUserNameValue = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblUserIDValue = new System.Windows.Forms.Label();
            this.LblUserID = new System.Windows.Forms.Label();
            this.GroupBoxUserCardLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlPersonDetails1
            // 
            this.CtrlPersonDetails1.Location = new System.Drawing.Point(3, 3);
            this.CtrlPersonDetails1.Name = "CtrlPersonDetails1";
            this.CtrlPersonDetails1.Size = new System.Drawing.Size(836, 303);
            this.CtrlPersonDetails1.TabIndex = 0;
            // 
            // GroupBoxUserCardLoginInfo
            // 
            this.GroupBoxUserCardLoginInfo.Controls.Add(this.LblUserIsActiveValue);
            this.GroupBoxUserCardLoginInfo.Controls.Add(this.LblUserIsActive);
            this.GroupBoxUserCardLoginInfo.Controls.Add(this.LblUserNameValue);
            this.GroupBoxUserCardLoginInfo.Controls.Add(this.LblUserName);
            this.GroupBoxUserCardLoginInfo.Controls.Add(this.LblUserIDValue);
            this.GroupBoxUserCardLoginInfo.Controls.Add(this.LblUserID);
            this.GroupBoxUserCardLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxUserCardLoginInfo.Location = new System.Drawing.Point(3, 312);
            this.GroupBoxUserCardLoginInfo.Name = "GroupBoxUserCardLoginInfo";
            this.GroupBoxUserCardLoginInfo.Size = new System.Drawing.Size(829, 100);
            this.GroupBoxUserCardLoginInfo.TabIndex = 1;
            this.GroupBoxUserCardLoginInfo.TabStop = false;
            this.GroupBoxUserCardLoginInfo.Text = "Login Information";
            // 
            // LblUserIsActiveValue
            // 
            this.LblUserIsActiveValue.AutoSize = true;
            this.LblUserIsActiveValue.Location = new System.Drawing.Point(585, 41);
            this.LblUserIsActiveValue.Name = "LblUserIsActiveValue";
            this.LblUserIsActiveValue.Size = new System.Drawing.Size(27, 25);
            this.LblUserIsActiveValue.TabIndex = 5;
            this.LblUserIsActiveValue.Text = "...";
            // 
            // LblUserIsActive
            // 
            this.LblUserIsActive.AutoSize = true;
            this.LblUserIsActive.Location = new System.Drawing.Point(482, 41);
            this.LblUserIsActive.Name = "LblUserIsActive";
            this.LblUserIsActive.Size = new System.Drawing.Size(97, 25);
            this.LblUserIsActive.TabIndex = 4;
            this.LblUserIsActive.Text = "Is Active :";
            // 
            // LblUserNameValue
            // 
            this.LblUserNameValue.AutoSize = true;
            this.LblUserNameValue.Location = new System.Drawing.Point(338, 41);
            this.LblUserNameValue.Name = "LblUserNameValue";
            this.LblUserNameValue.Size = new System.Drawing.Size(27, 25);
            this.LblUserNameValue.TabIndex = 3;
            this.LblUserNameValue.Text = "...";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(213, 41);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(121, 25);
            this.LblUserName.TabIndex = 2;
            this.LblUserName.Text = "User Name :";
            // 
            // LblUserIDValue
            // 
            this.LblUserIDValue.AutoSize = true;
            this.LblUserIDValue.Location = new System.Drawing.Point(98, 41);
            this.LblUserIDValue.Name = "LblUserIDValue";
            this.LblUserIDValue.Size = new System.Drawing.Size(27, 25);
            this.LblUserIDValue.TabIndex = 1;
            this.LblUserIDValue.Text = "...";
            // 
            // LblUserID
            // 
            this.LblUserID.AutoSize = true;
            this.LblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.Location = new System.Drawing.Point(6, 41);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(88, 25);
            this.LblUserID.TabIndex = 0;
            this.LblUserID.Text = "User ID :";
            // 
            // CtrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxUserCardLoginInfo);
            this.Controls.Add(this.CtrlPersonDetails1);
            this.Name = "CtrlUserCard";
            this.Size = new System.Drawing.Size(835, 427);
            this.GroupBoxUserCardLoginInfo.ResumeLayout(false);
            this.GroupBoxUserCardLoginInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private People.Controls.CtrlPersonDetails CtrlPersonDetails1;
        private System.Windows.Forms.GroupBox GroupBoxUserCardLoginInfo;
        private System.Windows.Forms.Label LblUserIsActiveValue;
        private System.Windows.Forms.Label LblUserIsActive;
        private System.Windows.Forms.Label LblUserNameValue;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblUserIDValue;
        private System.Windows.Forms.Label LblUserID;
    }
}
