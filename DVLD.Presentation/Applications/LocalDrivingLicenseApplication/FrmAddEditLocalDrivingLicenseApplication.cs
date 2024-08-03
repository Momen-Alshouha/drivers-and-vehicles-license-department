using System;
using System.Deployment.Internal;
using System.Windows.Forms;
using ClsDataType;
using DVLD.Presentation.People.Controls;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsDataType;
namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    public partial class FrmAddEditLocalDrivingLicenseApplication : Form
    {
        /* TODO:
         * check minimun allow age for class license
        */
        private readonly int ApplicationID; // used only on update mode
        private readonly int LocalApplicationID; // used only on update mode
        private readonly int PersonId;
        private EnMode FormMode;
        private readonly ClsApplication.EnApplicationStatus ApplicationStatus ;
        private ClsApplication.StApplicationData ApplicationData;
        private ClsApplication.StApplicationData TempApplicationData;
        private bool TabPageNewLocalLicenseApplicationInfoEnabled = false; // Flag to track the enablement state for TabPageNewLocalLicenseApplicationInfo
        private bool TabPageNewLocalLicensePersonalInfoEnabled=true;
        private EnMode enMode;

        public FrmAddEditLocalDrivingLicenseApplication(int ApplicationId, int LocalApplicationID)
        {
            this.ApplicationID = ApplicationId;
            this.LocalApplicationID = LocalApplicationID;
            FormMode= EnMode.Update;
            InitializeComponent();
            PersonId = BusinessLogic.ClsPerson.GetPersonId(ApplicationId);
            TabControlLocalDrivingLicenseApplication.SelectedIndex = 1;
            TabPageNewLocalLicenseApplicationInfoEnabled = true;
            TabPageNewLocalLicensePersonalInfoEnabled = false;
            LblLblAppIDLocalDrivingLicenseApplicationValue.Text = ApplicationId.ToString();
            LblLocalApplicationCreatedByValue.Text = ClsGlobal.CurrentUser.UserName.ToString();
            StApplicationData stApplicationData = BusinessLogic.ClsApplications.GetApplicationData(ApplicationId);
            LblLocalDrivingLicenseApplicationTitle.Text = "Update Local Driving License Application";
            LblApplicationDateLocalDrivingLicenseApplication.Text = DateTime.Now.ToString();
            ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.SelectedIndex = BusinessLogic.ClsLocalDrivingLicenseApplication.GetLicenseClassId(ApplicationId)-1;
        }
        public FrmAddEditLocalDrivingLicenseApplication()
        {
            FormMode = EnMode.AddNew;
            InitializeComponent();
            ApplicationStatus = ClsApplication.EnApplicationStatus.New;
            // subscribe to the OnPersonSelected event
            ctrlPersonDetailsWithFilter1.OnPersonSelected += CtrlPersonDetailsWithFilter_OnPersonSelected;
        }
        private void _FillTabPageValues()
        {
            LblApplicationDateLocalDrivingLicenseApplication.Text = DateTime.Now.ToString();
            LblLocalApplicationCreatedByValue.Text = ClsGlobal.CurrentUser.UserName.ToString();
        }
        private void _SetApplicationDataValues()
        {
            //TempApplicationData.stPerson.Id = ctrlPersonDetailsWithFilter1.PersonID; this will cause compliation error

            var person = TempApplicationData.stPerson; // to avoid "Cannot modify the return value of 'expression' because it is not a variable" Compiler Error CS1612
            person.Id = ctrlPersonDetailsWithFilter1.PersonID;
            
            TempApplicationData.stPerson = person;

            TempApplicationData.CreatedByUser = ClsGlobal.CurrentUser;

            TempApplicationData.PaidFees = 15;
            TempApplicationData.LastStatusDate = DateTime.Now;
            TempApplicationData.ApplicationDate = DateTime.Now;
            TempApplicationData.ApplicationStatus = 1;
            TempApplicationData.StApplicationTypeInfo = BusinessLogic.ClsApplicationType.GetAppType(1);

            this.ApplicationData = new StApplicationData(this.TempApplicationData);
        }
        private void CtrlPersonDetailsWithFilter_OnPersonSelected(int personID)
        {
            // enable the button when a person is selected
            TabPageNewLocalLicenseApplicationInfoEnabled = true;
            BtnNextLocalDrivingLicenseApplicationForm.Enabled = true;
            ApplicationData.ApplicantFullName = ctrlPersonDetailsWithFilter1.SelectedPersonInfo.Value.FullName.ToString();

            TabControlLocalDrivingLicenseApplication_Selecting(TabControlLocalDrivingLicenseApplication, new TabControlCancelEventArgs(TabPageNewLocalLicenseApplicationInfo, 1,false, TabControlAction.Selecting));

            _SetApplicationDataValues();
        }
        private void BtnCloseLocalDrivingLicenseApplicationForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnNextLocalDrivingLicenseApplicationForm_Click(object sender, EventArgs e)
        {
            TabControlLocalDrivingLicenseApplication.SelectedIndex = 1;
        }
        private void BtnBack2LocalDrivingLicenseApplicationForm_Click(object sender, EventArgs e)
        {
            TabControlLocalDrivingLicenseApplication.SelectedIndex = 0;
        }
        private void ctrlPersonDetailsWithFilter1_Load(object sender, EventArgs e)
        {
            _FillTabPageValues();
        }
        private EnLicenseClass _GetSelectedLicenseClass()
        {
            int selectedIndex = ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < Enum.GetValues(typeof(EnLicenseClass)).Length)
            {
                return (EnLicenseClass)selectedIndex + 1;
            }

            throw new InvalidOperationException("Invalid selection.");
        }
        private void BtnSavetLocalDrivingLicenseApplicationForm_Click(object sender, EventArgs e)
        {
            
            if (FormMode == EnMode.Update)
            {
                if (BusinessLogic.ClsLocalDrivingLicenseApplication.UpdateApplicationLicenseClass(PersonId, LocalApplicationID, _GetSelectedLicenseClass()))
                {
                    MessageBox.Show("Application Updated Successfully!");
                } else
                {
                    MessageBox.Show("Already has an application for this license class , Can't Edit!","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                return;
            }

            ApplicationData.ApplicationID = BusinessLogic.ClsLocalDrivingLicenseApplication.AddNew(ApplicationData);

            if (ApplicationData.ApplicationID == -1)
            {
                MessageBox.Show($"{ApplicationData.ApplicantFullName} Already have an application for {ComboBoxLicenseClassNewLocalDrivingLicenseAppForm.SelectedValue} License Class!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (ApplicationData.ApplicationID!=0)
            {
                MessageBox.Show("Application Added Successfully!", "New Local Driving License Application",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                LblLblAppIDLocalDrivingLicenseApplicationValue.Text = ApplicationData.ApplicationID.ToString();
            } else
            {
                 MessageBox.Show("Something Wrong Happened!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void ComboBoxLicenseClassNewLocalDrivingLicenseAppForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnSavetLocalDrivingLicenseApplicationForm.Enabled = true;
            ApplicationData.enLicenseClass = _GetSelectedLicenseClass();
            ApplicationData.LicenseClassID = (int)ApplicationData.enLicenseClass;
        }
        private void TabControlLocalDrivingLicenseApplication_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == TabPageNewLocalLicenseApplicationInfo && !TabPageNewLocalLicenseApplicationInfoEnabled)
            {
                e.Cancel = true;
                MessageBox.Show("Please Select a Person First!", "Select A Person!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (e.TabPage == TabPageNewLocalLicensePersonalInfo && !TabPageNewLocalLicensePersonalInfoEnabled)
            {
                e.Cancel = true;
                MessageBox.Show("Can't Edit Personal Info From Here!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
