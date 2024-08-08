using DVLD.Presentation.Properties;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsLicense;

namespace DVLD.Presentation.Controls
{
    public partial class CtrlLicenseInfo : UserControl
    {
        private int _LicenseID;
        private StLicense _StLicense;

        public int LicenseID
        {
            get { return _LicenseID; }
        }
        public StLicense StLicense
        {
            get { return _StLicense; }
        }
        public CtrlLicenseInfo()
        {
            InitializeComponent();
        }
        public void SetLicenseDataInCTRLByLicenseID(int LicenseID)
        {
            StLicense LicenseInfo = BusinessLogic.ClsLicense.GetLicenseInfoByLicenseID(LicenseID);
            _LicenseID = LicenseID;
            _StLicense = LicenseInfo;
            if (LicenseInfo.LicenseID ==0)
            {
                return;
            }
            lblLicenseDetailsLicenseIDValue.Text = LicenseInfo.LicenseID.ToString();
            LblLicenseDetailsBirthDateValue.Text = LicenseInfo.DriverPersonDetails.BirthDate.ToString("yyyy-MM-dd");
            LblLicenseDetailsFullNameValue.Text = $"{LicenseInfo.DriverPersonDetails.FirstName} {LicenseInfo.DriverPersonDetails.SecondName} {LicenseInfo.DriverPersonDetails.ThirdName} {LicenseInfo.DriverPersonDetails.LastName}";
            LblLicenseDetailsDriverIDValue.Text = LicenseInfo.DriverID.ToString();
            LblLicenseDetailsNationalNoValue.Text = LicenseInfo.DriverPersonDetails.NationalNo;
            LblLicenseDetailsLicenseClassValue.Text = GetLicenseClassDescription(LicenseInfo.EnLicenseClass);
            LblLicenseDetailsIssueReasonValue.Text = GetIssueReasonDescription(LicenseInfo.IssueReason);
            LblLicenseDetailsIsActiveValue.Text = LicenseInfo.IsActive ? "Yes" : "No";
            LblLicenseDetailsIsDetainedValue.Text = BusinessLogic.ClsLicense.IsLicenseDetained(_LicenseID) ? "Yes" : "No";
            LblLicenseDetailsExpirationDateValue.Text = LicenseInfo.ExpirationDate.ToString("yyyy-MM-dd");
            LblLicenseDetailsDriverIDValue.Text = LicenseInfo.DriverID.ToString();
            LblLicenseDetailsGenderValue.Text = LicenseInfo.DriverPersonDetails.Gender == 0 ? "Male" : "Female";
            LblLicenseDetailsIssueDateValue.Text = LicenseInfo.IssueDate.ToString("yyyy-MM-dd");
            LblLicenseDetailsNotesValue.Text = !string.IsNullOrEmpty(LicenseInfo.Notes) ? LicenseInfo.Notes : "No Notes!";

            // set default image based on gender if ImagePath is empty
            if (string.IsNullOrEmpty(LicenseInfo.DriverPersonDetails.ImagePath))
            {
                PictureBoxDriverPhotoLicenseInfo.Image = LicenseInfo.DriverPersonDetails.Gender == 0 ? Resources.Male : Resources.Female;
            }
            else
            {
                PictureBoxDriverPhotoLicenseInfo.ImageLocation = LicenseInfo.DriverPersonDetails.ImagePath;
            }
        }

        public void SetLicenseDataInCTRLByApplicationID(int ApplicationID)
        {
            StLicense LicenseInfo = BusinessLogic.ClsLicense.GetLicenseInfo(ApplicationID);
            _LicenseID = LicenseInfo.LicenseID;
            _StLicense = LicenseInfo;

            lblLicenseDetailsLicenseIDValue.Text = LicenseInfo.LicenseID.ToString();
            LblLicenseDetailsBirthDateValue.Text = LicenseInfo.DriverPersonDetails.BirthDate.ToString("yyyy-MM-dd");
            LblLicenseDetailsFullNameValue.Text = $"{LicenseInfo.DriverPersonDetails.FirstName} {LicenseInfo.DriverPersonDetails.SecondName} {LicenseInfo.DriverPersonDetails.ThirdName} {LicenseInfo.DriverPersonDetails.LastName}";
            LblLicenseDetailsDriverIDValue.Text = LicenseInfo.DriverID.ToString();
            LblLicenseDetailsNationalNoValue.Text = LicenseInfo.DriverPersonDetails.NationalNo;
            LblLicenseDetailsLicenseClassValue.Text = GetLicenseClassDescription(LicenseInfo.EnLicenseClass);
            LblLicenseDetailsIssueReasonValue.Text = GetIssueReasonDescription(LicenseInfo.IssueReason);
            LblLicenseDetailsIsActiveValue.Text = LicenseInfo.IsActive ? "Yes" : "No";
            LblLicenseDetailsIsDetainedValue.Text = BusinessLogic.ClsLicense.IsLicenseDetained(_LicenseID) ? "Yes" : "No";
            LblLicenseDetailsExpirationDateValue.Text = LicenseInfo.ExpirationDate.ToString("yyyy-MM-dd");
            LblLicenseDetailsDriverIDValue.Text = LicenseInfo.DriverID.ToString();
            LblLicenseDetailsGenderValue.Text = LicenseInfo.DriverPersonDetails.Gender == 0 ? "Male" : "Female";
            LblLicenseDetailsIssueDateValue.Text = LicenseInfo.IssueDate.ToString("yyyy-MM-dd");
            LblLicenseDetailsNotesValue.Text = !string.IsNullOrEmpty(LicenseInfo.Notes) ? LicenseInfo.Notes : "No Notes!";

            // set default image based on gender if ImagePath is empty
            if (string.IsNullOrEmpty(LicenseInfo.DriverPersonDetails.ImagePath))
            {
                PictureBoxDriverPhotoLicenseInfo.Image = LicenseInfo.DriverPersonDetails.Gender == 0 ? Resources.Male : Resources.Female;
            }
            else
            {
                PictureBoxDriverPhotoLicenseInfo.ImageLocation = LicenseInfo.DriverPersonDetails.ImagePath;
            }
        }
        private string GetLicenseClassDescription(EnLicenseClass licenseClass)
        {
            switch (licenseClass)
            {
                case EnLicenseClass.SmallMotorcycle:
                    return "Class 1 - Small Motorcycle";
                case EnLicenseClass.HeavyMotorcycle:
                    return "Class 2 - Heavy Motorcycle";
                case EnLicenseClass.OrdinaryDriving:
                    return "Class 3 - Ordinary Driving";
                case EnLicenseClass.Commercial:
                    return "Class 4 - Commercial";
                case EnLicenseClass.Agricultural:
                    return "Class 5 - Agricultural";
                case EnLicenseClass.SmallMediumBus:
                    return "Class 6 - Small/Medium Bus";
                case EnLicenseClass.TruckHeavyVehicle:
                    return "Class 7 - Truck/Heavy Vehicle";
                default:
                    return "Unknown License Class";
            }
        }
        private string GetIssueReasonDescription(EnIssueReason issueReason)
        {
            switch (issueReason)
            {
                case EnIssueReason.FirstTime:
                    return "First Time";
                case EnIssueReason.Renew:
                    return "Renew";
                case EnIssueReason.ReplacementDamaged:
                    return "Replacement (Damaged)";
                case EnIssueReason.ReplacementLost:
                    return "Replacement (Lost)";
                default:
                    return "Unknown Issue Reason";
            }
        }

        private void GroupBoxDriverLicenseInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
