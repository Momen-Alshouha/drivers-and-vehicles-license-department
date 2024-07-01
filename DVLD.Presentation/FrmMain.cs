using DVLD.Presentation.Login;
using DVLD.Presentation.People;
using DVLD.Presentation.People.Controls;
using DVLD.Presentation.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsDataType;
namespace DVLD.Presentation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePeople frmManagePeople = new FrmManagePeople();
            frmManagePeople.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageUsers frmManageUsers = new FrmManageUsers();
            frmManageUsers.ShowDialog();
        }

        private void currnetUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInfo frmUserInfo = new FrmUserInfo(ClsGlobal.CurrentUser.UserID);
            frmUserInfo.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsGlobal.CurrentUser = new StUser();
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword(ClsGlobal.CurrentUser);
            frmChangePassword.ShowDialog();
        }
    }
}
