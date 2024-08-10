using DVLD.Presentation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsLicense;
using static ClsDataType.ClsLocalDrivingLicenseApplications;
using static ClsDataType.ClsDataType;
using ClsDataType;
using DVLD.Presentation.Licenses;
namespace DVLD.Presentation.Applications.Renew_Local_Driving_License_Application
{
    public partial class FrmRenewLocalDrivingLicenseApplication : Form
    {
        int _LicenseID;
        StLicense _StLicense;
        StApplicationData _StApplicationData;
        public FrmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            ctrlLicenseInfoDetailsWithFilter1.LicenseIDSelected += ctrlLicenseInfoDetailsWithFilter1_LicenseIDSelected;
        }

        private void BtnCloseRenewForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlLicenseInfoDetailsWithFilter1_LicenseIDSelected(object sender, int LicenseID)
        {
            BtnRenew.Enabled = false;
            StLicense LicenseInfo = BusinessLogic.ClsLicense.GetLicenseInfoByLicenseID(LicenseID);
            if (LicenseInfo.LicenseID == 0)
            {
                MessageBox.Show($"Can't Find License With ID: {LicenseID}!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!LicenseInfo.IsActive)
            {
                MessageBox.Show($"Can't Renew License With ID: {LicenseID}! it's not active license!", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BtnRenew.Enabled = true;
            _LicenseID = LicenseInfo.LicenseID;
            _StLicense = LicenseInfo;
            _StLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            _StLicense.IssueDate = DateTime.Now;
            _StApplicationData = _PrepareApplicationData();
            _StApplicationData.LicenseClassID = (int)LicenseInfo.EnLicenseClass;
            ctrlApplicationNewLicenseInfo1.SetDefaultValuesDataInCTRL(LicenseInfo.Notes, LicenseInfo.LicenseID, LicenseInfo.EnLicenseClass, EnApplicationType.RenewDrivingLicenseService);
        }

        private void BtnRenew_Click(object sender, EventArgs e)
        {

            _StLicense.ExpirationDate = ctrlApplicationNewLicenseInfo1.StLicense.ExpirationDate;
            _StLicense.IsActive = ctrlApplicationNewLicenseInfo1.StLicense.IsActive;
            _StLicense.PaidFees = ctrlApplicationNewLicenseInfo1.StLicense.PaidFees;
            _StLicense.Notes = ctrlApplicationNewLicenseInfo1.Notes;

            if (BusinessLogic.ClsLocalDrivingLicenseApplication.AddNew(_StApplicationData) != -1)
            {
                int ApplicationID = BusinessLogic.ClsApplications.GetLastInsertedApplicationID();
                _StLicense.ApplicationID = ApplicationID;
                _StLicense.IssueReason = EnIssueReason.Renew;
                int NewLicenseID = BusinessLogic.ClsLicense.IssueLicense(_StLicense);
                BusinessLogic.ClsLicense.DeactivateLicense(_LicenseID);
                ctrlApplicationNewLicenseInfo1.loadNewLicenseIDinCTRL(NewLicenseID);
                if (NewLicenseID != -1)
                {
                    MessageBox.Show("License Renewed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLicenseInfoDetails frmLicenseInfoDetails = new FrmLicenseInfoDetails(ApplicationID);
                    this.Close();
                    frmLicenseInfoDetails.ShowDialog();
                }
            }
        }

        private StApplicationData _PrepareApplicationData()
        {
            StApplicationData stApplicationData = new StApplicationData
            {
                ApplicationDate = DateTime.Now,
                LastStatusDate = DateTime.Now,
                CreatedByUser = ClsGlobal.CurrentUser,
                PaidFees = BusinessLogic.ClsApplicationType.GetApplicationFeesByApplicationTypeID(EnApplicationType.RenewDrivingLicenseService),
                enApplicationType = EnApplicationType.RenewDrivingLicenseService,
                EnApplicationStatus = EnApplicationStatus.Completed,
                ApplicationStatus = (int)EnApplicationStatus.Completed,
                stPerson = _StLicense.DriverPersonDetails,
                StApplicationTypeInfo = new StApplicationType
                {
                    id = (int)EnApplicationType.RenewDrivingLicenseService
                }
            };

            return stApplicationData;
        }
    }
}
