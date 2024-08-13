using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsLocalDrivingLicenseApplications;
using static ClsDataType.ClsDataType;
using ClsDataType;

namespace DVLD.Presentation.Applications.Release_Detained_License
{
    public partial class FrmReleaseDetainedLicenseApplication : Form
    {
        int LicenseIDToRelease;
        StApplicationData StApplicationData;
        public FrmReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
            ctrlLicenseInfoDetailsWithFilter1.LicenseIDSelected += OnLicenseIDSelected;
        }

        private void OnLicenseIDSelected(object sender, int LicenseID)
        {
            BtnReleaseDetainLicenseApply.Enabled = false;
            var licenseInfo = BusinessLogic.ClsLicense.GetLicenseInfoByLicenseID(LicenseID);
            LicenseIDToRelease = licenseInfo.LicenseID;
            
            if (licenseInfo.LicenseID == 0)
            {
                MessageBox.Show($"Can't Find License With ID: {LicenseID}!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!licenseInfo.IsActive)
            {
                MessageBox.Show($"Can't Apply Any Application On License With ID: {LicenseID}! It's not an active license!", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool IsLicenseDetained = BusinessLogic.ClsLicense.IsLicenseDetained(LicenseID);
            if (!IsLicenseDetained)
            {
                MessageBox.Show($"License With ID: {LicenseID} is Not Deained License!", "Not Detained!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                StApplicationData = _PrepareApplicationData();
                BtnReleaseDetainLicenseApply.Enabled = true;
                SetFeesValues();
                StApplicationData.LicenseClassID = (int)licenseInfo.EnLicenseClass;
            }
        }
        private void SetFeesValues()
        {
            decimal ApplciaitonFees = BusinessLogic.ClsApplicationType.GetApplicationFeesByApplicationTypeID(ClsDataType.ClsApplication.EnApplicationType.ReleaseDetainedDrivingLicense);
            decimal FineFees =BusinessLogic.ClsLicense.GetFineFeesForDetainedLicense(LicenseIDToRelease);
            StApplicationData.PaidFees = ApplciaitonFees+ FineFees;
            LblRelaeseDetainedLicenseAppFeesValue.Text = ApplciaitonFees.ToString();
            LblReleaseDetainedLicenseFineFeesValue.Text = FineFees.ToString();
            LblReleaseDetainedLicenseTotalFeesValue.Text = StApplicationData.PaidFees.ToString();
        }

        private StApplicationData _PrepareApplicationData()
        {
            StApplicationData stApplicationData = new StApplicationData
            {
                ApplicationDate = DateTime.Now,
                LastStatusDate = DateTime.Now,
                CreatedByUser = ClsGlobal.CurrentUser,
                enApplicationType = EnApplicationType.ReleaseDetainedDrivingLicense,
                EnApplicationStatus = EnApplicationStatus.Completed,
                ApplicationStatus = (int)EnApplicationStatus.Completed,
                stPerson = BusinessLogic.ClsLicense.GetLicenseInfoByLicenseID(LicenseIDToRelease).DriverPersonDetails,
                StApplicationTypeInfo = new StApplicationType
                {
                    id = (int)EnApplicationType.ReleaseDetainedDrivingLicense
                }
            };

            return stApplicationData;

        }
        private void BtnCloseReleaseDetLicense_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReleaseDetainLicenseApply_Click(object sender, EventArgs e)
        {
            if (BusinessLogic.ClsLocalDrivingLicenseApplication.AddNew(StApplicationData)!=-1)
            {
                int ApplicationId = BusinessLogic.ClsApplications.GetLastInsertedApplicationID();
                BusinessLogic.ClsLicense.ReleaseLicense(LicenseIDToRelease,ClsGlobal.CurrentUser.UserID,ApplicationId);
                MessageBox.Show($"License Released Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctrlLicenseInfoDetailsWithFilter1.ChangeDetainText("No");
                BtnReleaseDetainLicenseApply.Enabled = false;
                return;
            }
        }
    }
}
