using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsInternationaLicenseInfo;
namespace DVLD.Presentation.Controls
{
    public partial class CtrlInternationalLicenseInfo : UserControl
    {
        public CtrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }
        public void SetDataInCTRL(int InternationalLicenseId , int DriverID)
        {
            int personID=BusinessLogic.ClsPerson.GetPersonIdByDriverId(DriverID);
            StInternationalLicense stInternationalLicense = BusinessLogic.ClsLicense.GetInternationalLicense(InternationalLicenseId);
            stInternationalLicense.DriverPersonDetails = BusinessLogic.ClsPerson.Find(personID);
            string PersonFullName = BusinessLogic.ClsPerson.GetApplicantFullName(personID);
            LblInternationalLicenseInfoName.Text = PersonFullName;
            LblInternationalLicenseInfoInternationalLicenseID.Text = stInternationalLicense.InternationalLicenseID.ToString();
            LblInternationalApplicationID.Text = stInternationalLicense.ApplicationID.ToString();
            LblInternationalDriverID.Text = stInternationalLicense.DriverID.ToString();
            LblInternationalExpirationDate.Text = stInternationalLicense.ExpirationDate.ToString("yyyy-MM-dd");
            LblInternationalIsActive.Text = stInternationalLicense.IsActive ? "Yes" : "No";
            LblInternationalLicenseID.Text = stInternationalLicense.LocalLicenseID.ToString();
            LblInternationalLicenseInfoGender.Text = stInternationalLicense.DriverPersonDetails.Gender == 0 ? "Male" : "Female";
            LblInternationalBirthDate.Text = stInternationalLicense.DriverPersonDetails.BirthDate.ToString("yyyy-MM-dd");
            LblInternationalLicenseInfoNationalNumber.Text = stInternationalLicense.DriverPersonDetails.NationalNo;
            LblInternationalIssueDate.Text = stInternationalLicense.IssueDate.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(stInternationalLicense.DriverPersonDetails.ImagePath))
            {
                switch (stInternationalLicense.DriverPersonDetails.Gender)
                {
                    case 0:
                        pictureBoxInternationalLicensePersonImage.Image = Properties.Resources.Male;
                        break;
                        case 1:
                        pictureBoxInternationalLicensePersonImage.Image = Properties.Resources.Female;
                        break;
                    default:
                        break;
                }
            } else
            {
                pictureBoxInternationalLicensePersonImage.Image = Image.FromFile(stInternationalLicense.DriverPersonDetails.ImagePath);
            }
        }
    }
}
