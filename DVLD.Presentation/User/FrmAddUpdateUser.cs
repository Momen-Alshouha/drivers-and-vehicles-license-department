using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static ClsDataType.ClsDataType;


namespace DVLD.Presentation.User
{
    public partial class FrmAddUpdateUser : Form
    {
        EnMode _Mode;
        StUser _User = new StUser();
        StPerson? _Person = new StPerson();
        int _PersonID = -1;
        public FrmAddUpdateUser()
        {
            _Mode=EnMode.AddNew;
            InitializeComponent();
        }

        public FrmAddUpdateUser(int PersonID)
        {
            _PersonID = PersonID;
            BusinessLogic.ClsUser.GetUserByPersonID(PersonID,ref _User);
            _Person = BusinessLogic.ClsPerson.Find(PersonID);
            _Mode = EnMode.Update;
            InitializeComponent();
            _ResetDefualtValues();
            _LoadPersonData();
            _LoadUserData();
        }

        private void _LoadPersonData()
        {
            ctrlUserDetailsWithFilter2.LoadPersonInfo(_PersonID);
        }
        private void _LoadUserData()
        {
            TextBoxUserName.Text = _User.UserName;
            lblUserID.Text = _User.UserID.ToString();
            TextBoxPassword.Text = _User.Password.ToString();
            TextBoxConfirmPassword.Text = _User.Password.ToString();
        }
        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values

            if (_Mode == EnMode.AddNew)
            {
                LblAddNewUserFormTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new StUser();

                TabLoginInfo.Enabled = false;
            }
            else
            {
                LblAddNewUserFormTitle.Text = "Update User";
                this.Text = "Update User";

                TabLoginInfo.Enabled = true;
                ButtonSaveAddUserForm.Enabled = true;
            }

            TextBoxUserName.Text = "";
            TextBoxPassword.Text = "";
            TextBoxConfirmPassword.Text = "";
            CheckBoxIsActive.Checked = true;
        }

        private void ButtonNextAddEditUser_Click(object sender, EventArgs e)
        {
            
            if (_Mode == EnMode.Update)
            {
                ButtonSaveAddUserForm.Enabled = true;
                TabLoginInfo.Enabled = true;
                TabControlUser.SelectedTab = TabControlUser.TabPages["TabLoginInfo"];
                return;
            }


            //incase of add new mode.
            if (ctrlUserDetailsWithFilter2.PersonID != -1)
            {

                if (BusinessLogic.ClsUser.IsExist(int.Parse(ctrlUserDetailsWithFilter2.PersonID.ToString())))
                {

                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                   
                    ButtonSaveAddUserForm.Enabled = true;
                    TabLoginInfo.Enabled = true;
                    TabControlUser.SelectedTab = TabControlUser.TabPages["TabLoginInfo"];
                }
            }

           
        }

        private void FrmAddUpdateUser_Load(object sender, EventArgs e)
        {
           
        }

        private void ButtonSaveAddUserForm_Click(object sender, EventArgs e)
        {
            _User.PersonID = ctrlUserDetailsWithFilter2.PersonID;
            _User.UserName = TextBoxUserName.Text;
            _User.Password= TextBoxPassword.Text;
            if (CheckBoxIsActive.Checked)
            {
                _User.IsActive = true;
            } else
            {
                _User.IsActive = false;
            }
            if (_Mode == EnMode.Update)
            {
                if (BusinessLogic.ClsUser.UpdateUser(_User))
                {
                    MessageBox.Show("User Updated Successfully!", "Update User!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                } else
                {
                    MessageBox.Show("Something Wrong Happened!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            } else
            {
                
                if (BusinessLogic.ClsUser.AddNewUser(_User))
                {
                    MessageBox.Show("User Added Successfully!", "Add User!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    MessageBox.Show("Something Wrong Happened!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void ButtonCloseAddUserForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
