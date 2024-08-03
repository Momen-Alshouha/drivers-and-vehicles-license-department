using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.Controls
{
    public partial class CtrlLicenseInfoDetailsWithFilter : UserControl
    {
        public CtrlLicenseInfoDetailsWithFilter()
        {
            InitializeComponent();
        }

        private void pictureBoxSearchFilterLicenseID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLicenseIDFilterValue.Text))
            {
                return;
            } else
            {
                int licenseID = Convert.ToInt32(textBoxLicenseIDFilterValue.Text);
                BusinessLogic.ClsLicense.GetLicenseInfoByLicenseID(licenseID);
                ctrlLicenseInfo1.SetLicenseDataInCTRL(licenseID);
            }
        }
    }
}
