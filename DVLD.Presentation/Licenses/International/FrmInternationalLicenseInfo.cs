using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.Licenses.International
{
    public partial class FrmInternationalLicenseInfo : Form
    {
        int DriverID, InternationalLicenseId;
        public FrmInternationalLicenseInfo(int driverID, int internationalLicenseId)
        {
            this.DriverID = driverID;
            this.InternationalLicenseId = internationalLicenseId;
            InitializeComponent();
            ctrlInternationalLicenseInfo1.SetDataInCTRL(InternationalLicenseId,driverID );
        }
        private void BtnCloseInternationalLicenseInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
