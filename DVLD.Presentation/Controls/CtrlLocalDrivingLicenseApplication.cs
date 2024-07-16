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
using DVLD.Presentation.People;
using DVLD.Presentation.People.Controls;

namespace DVLD.Presentation.Controls
{
    public partial class CtrlLocalDrivingLicenseApplication : UserControl
    {
        StApplicationData _applicationData;
        int PersonID;
        int DrivingLicenseApplicationID = 0;
        int ApplicationID;
        int LicenseID;
        public CtrlLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        private int GetApplicationIDByLDLid() {
            return BusinessLogic.ClsLocalDrivingLicenseApplication.GetApplicationIDByLocalDrivingLicenseAppID(DrivingLicenseApplicationID);
        }
        //public void LoadApplicationInfoByApplicationID(int ApplicationID)
        //{
        //    this.ApplicationID = ApplicationID;
        //    this.DrivingLicenseApplicationID = GetApplicationIDByLDLid();
        //}
        public StPerson GetPersonData(int PersonID)
        {
            return BusinessLogic.ClsPerson.Find(PersonID);
        }
        private int GetPersonIDByApplicationID()
        {
            return BusinessLogic.ClsPerson.GetPersonId(ApplicationID);
        }
        public StUser GetUserInfo()
        {
            StUser user = new StUser();
            BusinessLogic.ClsUser.GetUserByUserID(this._applicationData.CreatedByUser.UserID,ref user);
            return user;
        }
        public void SetApplicationInfoInCTRL(StApplicationData applicationData)
        {
            LblDLAInfo_ID.Text = DrivingLicenseApplicationID.ToString();
            LblApp_info_idValue.Text = ApplicationID.ToString();
            LblApp_info_statusValue.Text = applicationData.StatusText;
            LblApp_info_idValue.Text = applicationData.ApplicationID.ToString();
            LblDLAInfo_Class.Text = applicationData.LicenseClassText;
            LblApp_info_createdbyValue.Text = applicationData.CreatedByUser.UserName;
            LblApp_info_feesValue.Text = applicationData.StApplicationTypeInfo.fee.ToString();
        }

        public void LoadApplicationInfoByLocalDrivingApplicationID(int LocalDrivingApplicationID)
        {
            
            this.DrivingLicenseApplicationID = LocalDrivingApplicationID;
            this.ApplicationID = GetApplicationIDByLDLid();
            this._applicationData = BusinessLogic.ClsLocalDrivingLicenseApplication.GetApplicationData(ApplicationID);
            this.PersonID = GetPersonIDByApplicationID();
            this._applicationData.stPerson = GetPersonData(PersonID);
            this._applicationData.CreatedByUser = GetUserInfo();
            SetApplicationInfoInCTRL(this._applicationData);
        }

        private void LinkLabelShowPersonInfoCTRL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmPersonDetails frmPersonDetails = new FrmPersonDetails(PersonID);
            frmPersonDetails.ShowDialog();  
        }
    }
}
