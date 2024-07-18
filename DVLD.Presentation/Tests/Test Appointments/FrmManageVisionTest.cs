using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsLocalDrivingLicenseApplications;

namespace DVLD.Presentation.Tests.Test_Appointments
{
    public partial class FrmManageVisionTest : Form
    {
        int LocalDrivingLicenseAppID = 0;
        public FrmManageVisionTest(int LocalDrivingLicenseAppID)
        {
            InitializeComponent();
            this.LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            ctrlLocalDrivingLicenseApplication1.LoadApplicationInfoByLocalDrivingApplicationID(LocalDrivingLicenseAppID);
        }
    }
}
