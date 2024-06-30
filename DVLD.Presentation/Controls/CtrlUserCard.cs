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
using static ClsDataType.ClsDataType;
namespace DVLD.Presentation.Controls
{
    public partial class CtrlUserCard : UserControl
    {
        StUser _User;
        public CtrlUserCard()
        {
            InitializeComponent();
        }

       
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }


        public void LoadUserInfo(int UserID)
        {
            
            if (!BusinessLogic.ClsUser.GetUserByUserID(UserID, ref _User))
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }

        private void _FillUserInfo()
        {

            CtrlPersonDetails1.LoadPersonInfo(_User.PersonID);
            LblUserIDValue.Text = _User.UserID.ToString();
            LblUserNameValue.Text = _User.UserName.ToString();

            if (_User.IsActive)
                LblUserIsActiveValue.Text = "Yes";
            else
                LblUserIsActiveValue.Text = "No";

        }

        private void _ResetPersonInfo()
        {

            CtrlPersonDetails1.ResetText();
            LblUserIDValue.Text = "[???]";
            LblUserNameValue.Text = "[???]";
            LblUserIsActiveValue.Text = "[???]";
        }
    }
}
