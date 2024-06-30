namespace DVLD.Presentation.User
{
    partial class FrmManageUsers
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
            this.LblManageUsersFormTitle = new System.Windows.Forms.Label();
            this.DataGridViewManageUsers = new System.Windows.Forms.DataGridView();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LblUsersRecords = new System.Windows.Forms.Label();
            this.LblUsersRecordsValue = new System.Windows.Forms.Label();
            this.ContextMenuStripManageUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBoxAddUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewManageUsers)).BeginInit();
            this.ContextMenuStripManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblManageUsersFormTitle
            // 
            this.LblManageUsersFormTitle.AutoSize = true;
            this.LblManageUsersFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManageUsersFormTitle.Location = new System.Drawing.Point(284, 133);
            this.LblManageUsersFormTitle.Name = "LblManageUsersFormTitle";
            this.LblManageUsersFormTitle.Size = new System.Drawing.Size(250, 39);
            this.LblManageUsersFormTitle.TabIndex = 7;
            this.LblManageUsersFormTitle.Text = "Manage Users";
            // 
            // DataGridViewManageUsers
            // 
            this.DataGridViewManageUsers.AllowUserToAddRows = false;
            this.DataGridViewManageUsers.AllowUserToDeleteRows = false;
            this.DataGridViewManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewManageUsers.Location = new System.Drawing.Point(12, 236);
            this.DataGridViewManageUsers.Name = "DataGridViewManageUsers";
            this.DataGridViewManageUsers.ReadOnly = true;
            this.DataGridViewManageUsers.RowHeadersWidth = 51;
            this.DataGridViewManageUsers.RowTemplate.Height = 24;
            this.DataGridViewManageUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewManageUsers.Size = new System.Drawing.Size(781, 322);
            this.DataGridViewManageUsers.TabIndex = 8;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Location = new System.Drawing.Point(655, 564);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(138, 53);
            this.ButtonClose.TabIndex = 9;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LblUsersRecords
            // 
            this.LblUsersRecords.AutoSize = true;
            this.LblUsersRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsersRecords.Location = new System.Drawing.Point(12, 582);
            this.LblUsersRecords.Name = "LblUsersRecords";
            this.LblUsersRecords.Size = new System.Drawing.Size(95, 25);
            this.LblUsersRecords.TabIndex = 10;
            this.LblUsersRecords.Text = "#Records";
            // 
            // LblUsersRecordsValue
            // 
            this.LblUsersRecordsValue.AutoSize = true;
            this.LblUsersRecordsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsersRecordsValue.Location = new System.Drawing.Point(113, 582);
            this.LblUsersRecordsValue.Name = "LblUsersRecordsValue";
            this.LblUsersRecordsValue.Size = new System.Drawing.Size(17, 25);
            this.LblUsersRecordsValue.TabIndex = 11;
            this.LblUsersRecordsValue.Text = ".";
            // 
            // ContextMenuStripManageUsers
            // 
            this.ContextMenuStripManageUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStripManageUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.ContextMenuStripManageUsers.Name = "ContextMenuStripManageUsers";
            this.ContextMenuStripManageUsers.Size = new System.Drawing.Size(194, 124);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // PictureBoxAddUser
            // 
            this.PictureBoxAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxAddUser.Image = global::DVLD.Presentation.Properties.Resources.Add_Person_72;
            this.PictureBoxAddUser.Location = new System.Drawing.Point(721, 158);
            this.PictureBoxAddUser.Name = "PictureBoxAddUser";
            this.PictureBoxAddUser.Size = new System.Drawing.Size(72, 72);
            this.PictureBoxAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAddUser.TabIndex = 13;
            this.PictureBoxAddUser.TabStop = false;
            this.PictureBoxAddUser.Click += new System.EventHandler(this.PictureBoxAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(370, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // FrmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 629);
            this.Controls.Add(this.PictureBoxAddUser);
            this.Controls.Add(this.LblUsersRecordsValue);
            this.Controls.Add(this.LblUsersRecords);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.DataGridViewManageUsers);
            this.Controls.Add(this.LblManageUsersFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmManageUsers";
            this.Load += new System.EventHandler(this.FrmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewManageUsers)).EndInit();
            this.ContextMenuStripManageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblManageUsersFormTitle;
        private System.Windows.Forms.DataGridView DataGridViewManageUsers;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LblUsersRecords;
        private System.Windows.Forms.Label LblUsersRecordsValue;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripManageUsers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.PictureBox PictureBoxAddUser;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}