using DVLD.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsLicense;
using static ClsDataType.ClsDriver;

namespace DVLD.Presentation.Licenses.IssueLicense
{
    public partial class FrmIssueDrivingLicense : Form
    {
        StApplicationData StApplicationData;
        StLicense license;
        StDriver driver;
        public FrmIssueDrivingLicense(int LocalApplicationID, EnIssueReason enIssueReason)
        {
            license.IssueReason = enIssueReason;
            int ApplicationId = BusinessLogic.ClsApplications.GetApplicationIDByLocalDrivingLicenseAppID(LocalApplicationID);
            int PersonId=BusinessLogic.ClsPerson.GetPersonId(ApplicationId);
            driver.PersonID = PersonId;
            driver.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            driver.CreatedDate = DateTime.Now;
            StApplicationData stApplicationData;
            stApplicationData = BusinessLogic.ClsLocalDrivingLicenseApplication.GetApplicationData(ApplicationId);
            StApplicationData = new StApplicationData(stApplicationData);
            InitializeComponent();
            ctrlLocalDrivingLicenseApplication1.LoadApplicationInfoByLocalDrivingApplicationID(LocalApplicationID);
        }
        private void InitialLicenseData(ref StLicense license)
        {
            license.IsActive = true;
            license.ApplicationID = StApplicationData.ApplicationID;
            license.EnLicenseClass = StApplicationData.enLicenseClass;
            license.PaidFees = BusinessLogic.ClsLicense.GetFees(license.EnLicenseClass);
            license.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(ClsLicense.GetDefaultValidityDateLength((int)license.EnLicenseClass));
            if (RichTextLicenseNotesForm.Text==string.Empty)
            {
                license.Notes = null;
            } else
            {
                license.Notes=RichTextLicenseNotesForm.Text;
            }
        }
        private void BtnIssueLicense_Click(object sender, EventArgs e)
        {
            int NewDriverId = BusinessLogic.ClsDriver.AddNewDriver(driver);
            license.DriverID = NewDriverId;
            InitialLicenseData(ref license);
            int NewLicenseId = BusinessLogic.ClsLicense.IssueLicense(license);
            if (NewLicenseId != -1)
            {
                MessageBox.Show($"License Issued Successfully! New License ID : {NewLicenseId}","License Issued!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            BusinessLogic.ClsApplications.UpdateApplicationStatus(StApplicationData.ApplicationID, EnApplicationStatus.Completed);
        }
    }
}
