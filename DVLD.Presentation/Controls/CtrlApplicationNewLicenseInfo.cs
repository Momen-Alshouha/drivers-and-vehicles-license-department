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
using static ClsDataType.ClsLicense;

namespace DVLD.Presentation.Controls
{
    public partial class CtrlApplicationNewLicenseInfo : UserControl
    {
        public StLicense StLicense;
        public string Notes
        {
            get => this.richTextBoxApplicationNewLicenseInfoNotesValue.Text;
        }

        public CtrlApplicationNewLicenseInfo()
        {
            InitializeComponent();
            LblApplicationNewLicenseInfoCreatedByValue.Text = ClsGlobal.CurrentUser.UserName;
            ApplicationNewLicenseInfoIssueDateValue.Text = DateTime.Now.ToString("yyyy-MM-dd");
            ApplicationNewLicenseInfoApplicationDateValue.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void SetDefaultValuesDataInCTRL(string LicenseNotes,int OldLicenseID, EnLicenseClass enLicenseClass,EnApplicationType enApplicationType)
        {
            LblApplicationLicenseInfoOldLicenseIdValue.Text = "...";
            LblApplicationNewLicenseInfoExpDateValue.Text = "...";
            ApplicationNewLicenseInfoApplicationFeesValue.Text = "...";
            ApplicationNewLicenseInfoLicenseFeesValue.Text = "...";
            LblApplicationNewLicenseInfoTotalFeesValue.Text = "...";
            //LblApplicationNewLicenseInfoAppIDValue.Text = "...";

            richTextBoxApplicationNewLicenseInfoNotesValue.Text = LicenseNotes;
            LblApplicationLicenseInfoOldLicenseIdValue.Text = OldLicenseID.ToString();
            decimal LicenseFees = BusinessLogic.ClsLicense.GetFees(enLicenseClass);
            int DefaultValidityLength = BusinessLogic.ClsLicense.GetDefaultValidityDateLength((int)enLicenseClass);
            decimal ApplicationFees = BusinessLogic.ClsApplicationType.GetApplicationFeesByApplicationTypeID(enApplicationType);
            int DefaultValidity = BusinessLogic.ClsLicense.GetDefaultValidityDateLength((int)enLicenseClass);
            LblApplicationNewLicenseInfoExpDateValue.Text = DateTime.Now.AddYears(DefaultValidity).ToString("yyyy-MM-dd");
            ApplicationNewLicenseInfoApplicationFeesValue.Text = ApplicationFees.ToString();
            ApplicationNewLicenseInfoLicenseFeesValue.Text = LicenseFees.ToString();
            LblApplicationNewLicenseInfoTotalFeesValue.Text = (ApplicationFees + LicenseFees).ToString();


            this.StLicense.Notes = richTextBoxApplicationNewLicenseInfoNotesValue.Text;
            this.StLicense.PaidFees = ApplicationFees + LicenseFees;
            this.StLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidity);
            this.StLicense.IssueDate = DateTime.Now;
            this.StLicense.IsActive = true;
        }
        public void loadNewLicenseIDinCTRL(int newLicenseID)
        {
            LblApplicationNewLicenseInfoNewLicenseIDValue.Text = newLicenseID.ToString();
        }

    }
}
