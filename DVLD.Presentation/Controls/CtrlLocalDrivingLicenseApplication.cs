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

namespace DVLD.Presentation.Controls
{
    public partial class CtrlLocalDrivingLicenseApplication : UserControl
    {
        StApplicationData _applicationData;
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
        public void LoadApplicationInfoByApplicationID(int ApplicationID)
        {
            this.ApplicationID = ApplicationID;
            this.DrivingLicenseApplicationID = GetApplicationIDByLDLid();
        }

        public void LoadApplicationInfoByLocalDrivingApplicationID(int ApplicationID)
        {
            this.ApplicationID = ApplicationID;
            this.DrivingLicenseApplicationID = GetApplicationIDByLDLid();
        }

    }
}
