using DVLD.Presentation.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.User
{
    public partial class FrmManageUsers : Form
    {
        public FrmManageUsers()
        {
            
            InitializeComponent();
            _InitializeContextMenu();
        }

        private void _InitializeContextMenu()
        {
            this.DataGridViewManageUsers.ContextMenuStrip = ContextMenuStripManageUsers;
        }


        private void _RefreshNumberOfRecords()
        {
            LblUsersRecordsValue.Text = DataGridViewManageUsers.RowCount.ToString();
        }

        private void _LoadUsersInDataGrid()
        {
            DataGridViewManageUsers.DataSource = BusinessLogic.ClsUser.GetAllUsers();
            DataGridViewManageUsers.Columns[2].Width = 230;
        }
        private void FrmManageUsers_Load(object sender, EventArgs e)
        {
            _LoadUsersInDataGrid();
            _RefreshNumberOfRecords();

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser addUpdateUser = new FrmAddUpdateUser();
            addUpdateUser.ShowDialog();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewManageUsers.SelectedRows.Count > 0)
            {
                int UserID = Convert.ToInt32(DataGridViewManageUsers.SelectedRows[0].Cells[0].Value);
                FrmAddUpdateUser frmAddEditUser = new FrmAddUpdateUser(UserID);
                frmAddEditUser.ShowDialog();
            }
            _LoadUsersInDataGrid();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewManageUsers.SelectedRows.Count > 0)
            {
                int UserID = Convert.ToInt32(DataGridViewManageUsers.SelectedRows[0].Cells[0].Value);
                FrmUserInfo frmAddEditUser = new FrmUserInfo(UserID);
                frmAddEditUser.ShowDialog();
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure?",
                "Delete User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                if (DataGridViewManageUsers.SelectedRows.Count > 0)
                {
                    int userID = Convert.ToInt32(DataGridViewManageUsers.SelectedRows[0].Cells[0].Value);
                    BusinessLogic.ClsUser.DeleteUser(userID);
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadUsersInDataGrid();
                    _RefreshNumberOfRecords();
                }
                else
                {
                    MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //to ensure the form remains open
            this.DialogResult = DialogResult.None;
        }

        private void PictureBoxAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser frmAddUpdateUser = new FrmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
        }
    }
}
