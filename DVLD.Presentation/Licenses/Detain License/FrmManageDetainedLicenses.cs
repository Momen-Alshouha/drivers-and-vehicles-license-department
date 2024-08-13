using DVLD.Presentation.Applications.Release_Detained_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.Licenses.Detain_License
{
    public partial class FrmManageDetainedLicenses : Form
    {
        public FrmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void pictureBoxReleaseLicense_Click(object sender, EventArgs e)
        {
            FrmReleaseDetainedLicenseApplication frmReleaseDetainedLicenseApplication = new FrmReleaseDetainedLicenseApplication();
            frmReleaseDetainedLicenseApplication.ShowDialog();
        }

        private void pictureBoxDetainLicence_Click(object sender, EventArgs e)
        {
            FrmDetainLicense frmDetainLicense = new FrmDetainLicense();
            frmDetainLicense.ShowDialog();
        }
    }
}
