using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    public partial class FrmLocalDrivingLicenseApplicationDetails : Form
    {
        public FrmLocalDrivingLicenseApplicationDetails(int LDLappID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseApplication1.LoadApplicationInfoByLocalDrivingApplicationID(LDLappID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
