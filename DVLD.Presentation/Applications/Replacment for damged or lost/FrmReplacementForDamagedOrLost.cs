using System;
using System.Windows.Forms;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsLicense;
using DVLD.Presentation.Licenses;
using DVLD.Presentation.Controls;
using static ClsDataType.ClsDataType;

namespace DVLD.Presentation.Applications.ReplacementForDamagedOrLost
{
    public partial class FrmReplacementForDamagedOrLost : Form
    {
        private int _LicenseID;
        private int _PersonID;
        private int _NewLicenseID;
        private int _ApplicationId;
        private StLicense _StLicense;
        private StApplicationData _StApplicationData;

        public FrmReplacementForDamagedOrLost()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            linkLabelNewLicenseInfoReplacedOrDamaged.Enabled = false;
            linkLabelShowLicensesHistory.Enabled = false;
            BtnReplacmentOrDamagedApply.Enabled = false;
            ctrlLicenseInfoDetailsWithFilter1.LicenseIDSelected += OnLicenseIDSelected;
        }

        private StApplicationData PrepareApplicationData(EnApplicationType applicationType)
        {
            return new StApplicationData
            {
                ApplicationDate = DateTime.Now,
                LastStatusDate = DateTime.Now,
                CreatedByUser = ClsGlobal.CurrentUser,
                PaidFees = BusinessLogic.ClsApplicationType.GetApplicationFeesByApplicationTypeID(applicationType),
                enApplicationType = applicationType,
                EnApplicationStatus = EnApplicationStatus.Completed,
                ApplicationStatus = (int)EnApplicationStatus.Completed,
                stPerson = _StLicense.DriverPersonDetails,
                StApplicationTypeInfo = new StApplicationType
                {
                    id = (int)applicationType
                }
            };
        }

        private void OnLicenseIDSelected(object sender, int LicenseID)
        {
            ResetControls();

            var licenseInfo = BusinessLogic.ClsLicense.GetLicenseInfoByLicenseID(LicenseID);
            if (licenseInfo.LicenseID == 0)
            {
                MessageBox.Show($"Can't Find License With ID: {LicenseID}!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetLicenseInfo(licenseInfo);

            if (!licenseInfo.IsActive)
            {
                linkLabelShowLicensesHistory.Enabled = true;
                MessageBox.Show($"Can't Apply Any Application On License With ID: {LicenseID}! It's not an active license!", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EnableApplicationOptions();
        }

        private void ResetControls()
        {
            linkLabelNewLicenseInfoReplacedOrDamaged.Enabled = false;
            linkLabelShowLicensesHistory.Enabled = false;
            BtnReplacmentOrDamagedApply.Enabled = false;
        }

        private void SetLicenseInfo(StLicense licenseInfo)
        {
            _PersonID = licenseInfo.DriverPersonDetails.Id;
            _LicenseID = licenseInfo.LicenseID;
            _StLicense = licenseInfo;
            _StLicense.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            _StLicense.IssueDate = DateTime.Now;
        }

        private void EnableApplicationOptions()
        {
            linkLabelShowLicensesHistory.Enabled = true;
            _StApplicationData.LicenseClassID = (int)_StLicense.EnLicenseClass;

            if (radioButtonDamaged.Checked)
            {
                PrepareAndSetApplicationData(EnApplicationType.ReplacementForDamagedDrivingLicense);
            }
            else if (radioButtonLost.Checked)
            {
                PrepareAndSetApplicationData(EnApplicationType.ReplacementForLostDrivingLicense);
            }
        }

        private void PrepareAndSetApplicationData(EnApplicationType applicationType)
        {
            _StApplicationData = PrepareApplicationData(applicationType);
            ctrlApplicationNewLicenseInfo1.SetDefaultValuesDataInCTRL(
                _StLicense.Notes,
                _StLicense.LicenseID,
                _StLicense.EnLicenseClass,
                applicationType
            );
            BtnReplacmentOrDamagedApply.Enabled = true;
        }

        private void radioButtonDamagedOrLost_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLost.Checked)
            {
                PrepareAndSetApplicationData(EnApplicationType.ReplacementForLostDrivingLicense);
            }
            else if (radioButtonDamaged.Checked)
            {
                PrepareAndSetApplicationData(EnApplicationType.ReplacementForDamagedDrivingLicense);
            }
        }

        private void linkLabelShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmLicensesHistory = new FrmLicensesHistory(_PersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void BtnReplacmentOrDamagedApply_Click(object sender, EventArgs e)
        {
            UpdateLicenseDetails();

            if (BusinessLogic.ClsLocalDrivingLicenseApplication.AddNew(_StApplicationData) != -1)
            {
                ProcessNewApplication();
            }
        }

        private void UpdateLicenseDetails()
        {
            _StLicense.ExpirationDate = ctrlApplicationNewLicenseInfo1.StLicense.ExpirationDate;
            _StLicense.IsActive = ctrlApplicationNewLicenseInfo1.StLicense.IsActive;
            _StLicense.PaidFees = ctrlApplicationNewLicenseInfo1.StLicense.PaidFees;
            _StLicense.Notes = ctrlApplicationNewLicenseInfo1.Notes;
            _StApplicationData.LicenseClassID = (int)_StLicense.EnLicenseClass;
        }

        private void ProcessNewApplication()
        {
            _ApplicationId = BusinessLogic.ClsApplications.GetLastInsertedApplicationID();
            _StLicense.ApplicationID = _ApplicationId;

            SetIssueReason();

            _NewLicenseID = BusinessLogic.ClsLicense.IssueLicense(_StLicense);
            BusinessLogic.ClsLicense.DeactivateLicense(_LicenseID);

            ctrlApplicationNewLicenseInfo1.loadNewLicenseIDinCTRL(_NewLicenseID);

            if (_NewLicenseID != -1)
            {
                BtnReplacmentOrDamagedApply.Enabled = false;
                linkLabelNewLicenseInfoReplacedOrDamaged.Enabled = true;
                MessageBox.Show("Operation Done Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var frmLicenseInfoDetails = new FrmLicenseInfoDetails(_ApplicationId);
                frmLicenseInfoDetails.ShowDialog();
            }
        }

        private void SetIssueReason()
        {
            if (radioButtonDamaged.Checked)
            {
                _StLicense.IssueReason = EnIssueReason.ReplacementDamaged;
            }
            else if (radioButtonLost.Checked)
            {
                _StLicense.IssueReason = EnIssueReason.ReplacementLost;
            }
        }

        private void linkLabelNewLicenseInfoReplacedOrDamaged_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmLicenseInfoDetails = new FrmLicenseInfoDetails(_ApplicationId);
            frmLicenseInfoDetails.ShowDialog();
        }

        private void buttonFrmReplacementOrDamagedClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
