using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.Licenses
{
    public partial class FrmLicenseInfoDetails : Form
    {
        public FrmLicenseInfoDetails(int ApplicationID)
        {
            InitializeComponent();
            ctrlLicenseInfo1.SetLicenseDataInCTRL(ApplicationID);
        }
        private void BtnLicenseDetailsFrmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
