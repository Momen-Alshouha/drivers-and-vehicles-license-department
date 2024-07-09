using System;
using System.Windows.Forms;
using ClsDataType;
using DVLD.Presentation.People.Controls;
using static ClsDataType.ClsApplication;

namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    public partial class FrmAddEditLocalDrivingLicenseApplication : Form
    {
        /* to do: disable second tab if person not selected
         * check minimun allow age for class license
        */
        private ClsApplication.EnLicenseClass enLicenseClassSelected;
        private readonly ClsApplication.EnApplicationType applicationType = ClsApplication.EnApplicationType.NewLocalDrivingLicenseService;
        private readonly ClsApplication.EnApplicationStatus ApplicationStatus = ClsApplication.EnApplicationStatus.New;
        private ClsDataType.ClsDataType.StPerson StApplicantPerson { get; set; }
        private ClsApplication.StApplicationData ApplicationData;
        private ClsApplication.StApplicationData TempApplicationData;
        private ClsDataType.ClsDataType.StUser CreatedByUser;

        public FrmAddEditLocalDrivingLicenseApplication()
        {
            InitializeComponent();
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
         
            TempApplicationData.PaidFees = 15;
            TempApplicationData.EnApplicationType = this.applicationType;
            TempApplicationData.ApplicantPersonID = ctrlPersonDetailsWithFilter1.PersonID;
            TempApplicationData.LastStatusDate = DateTime.Now;
            TempApplicationData.ApplicationDate = DateTime.Now;
            TempApplicationData.EnApplicationStatus = this.ApplicationStatus;
            TempApplicationData.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            BusinessLogic.ClsUser.GetUserByUserID(ClsGlobal.CurrentUser.UserID, ref this.CreatedByUser);

            this.ApplicationData = new StApplicationData(this.TempApplicationData);
        }
        private void CtrlPersonDetailsWithFilter_OnPersonSelected(int personID)
        {
            // enable the button when a person is selected
            BtnNextLocalDrivingLicenseApplicationForm.Enabled = true;
            ApplicationData.ApplicantFullName = ctrlPersonDetailsWithFilter1.SelectedPersonInfo.Value.FullName.ToString();
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

            throw new InvalidOperationException("Invalid ComboBox selection.");
        }

        private void BtnSavetLocalDrivingLicenseApplicationForm_Click(object sender, EventArgs e)
        {
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
    }
}
