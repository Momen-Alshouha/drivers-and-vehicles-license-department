using DVLD.Presentation.Controls;
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
namespace DVLD.Presentation.User
{
    public partial class FrmChangePassword : Form
    {
        StUser _CurrentUser;
        public FrmChangePassword(StUser CurrentUser)
        {
            this._CurrentUser = CurrentUser;
            InitializeComponent();
            CtrlUserCardChangePasswordForm.LoadUserInfo(_CurrentUser.UserID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ClsValidation.AreStringsEqual(TxtNewPassword.Text,TxtConfirmPassword.Text))
            {
                string EnterdCurrentPassword = TxtCurrentPassword.Text;
                string NewPassword = TxtNewPassword.Text;
                if (BusinessLogic.ClsUser.ChangePassword(_CurrentUser.UserID, EnterdCurrentPassword,NewPassword))
                {
                    MessageBox.Show("Password Changed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Error Changing Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Error Confirmation Password!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
