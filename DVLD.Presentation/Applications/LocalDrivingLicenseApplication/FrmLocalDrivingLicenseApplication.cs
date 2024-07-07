using System;
using System.Windows.Forms;
using ClsDataType;
using DVLD.Presentation.People.Controls;

namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    public partial class FrmLocalDrivingLicenseApplication : Form
    {
        ClsApplication.StApplicationData applicationData;

        public FrmLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            // subscribe to the OnPersonSelected event
            ctrlPersonDetailsWithFilter1.OnPersonSelected += CtrlPersonDetailsWithFilter_OnPersonSelected;
        }

        private void CtrlPersonDetailsWithFilter_OnPersonSelected(int personID)
        {
            // enable the button when a person is selected
            BtnNextLocalDrivingLicenseApplicationForm.Enabled = true;
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
    }
}
