using ClsDataType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsLicense;

namespace DVLD.Presentation.Licenses.Detain_License
{
    public partial class FrmDetainLicense : Form
    {
        private int LicenseIDToDetain;
        public FrmDetainLicense()
        {
            InitializeComponent();
            ctrlLicenseInfoDetailsWithFilter1.LicenseIDSelected += OnLicenseIDSelected;
        }

        private void OnLicenseIDSelected(object sender, int LicenseID)
        {
            BtnDetainLicense.Enabled = false;
            var licenseInfo = BusinessLogic.ClsLicense.GetLicenseInfoByLicenseID(LicenseID);
            LicenseIDToDetain = licenseInfo.LicenseID;

            if (licenseInfo.LicenseID == 0)
            {
                MessageBox.Show($"Can't Find License With ID: {LicenseID}!", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!licenseInfo.IsActive)
            {
                MessageBox.Show($"Can't Apply Any Application On License With ID: {LicenseID}! It's not an active license!", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool IsLicenseDetained = BusinessLogic.ClsLicense.IsLicenseDetained(LicenseID);
            if (IsLicenseDetained)
            {
                MessageBox.Show($"License With ID: {LicenseID} is Deained License!", "Already Detained!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(textBoxFineFeesDetainLicenseFrm.Text))
            {
                BtnDetainLicense.Enabled = true;
            }
        }

        private void BtnCloseDetainLicenseFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxFineFeesDetainLicenseFrm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxFineFeesDetainLicenseFrm.Text))
            {
                BtnDetainLicense.Enabled = true;
            } else
            {
                BtnDetainLicense.Enabled = false ;
            }
        }

        private void textBoxFineFeesDetainLicenseFrm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys like backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // Allow only digits (0-9) and one decimal point if needed
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Prevent more than one decimal point
            if (e.KeyChar == '.' && textBoxFineFeesDetainLicenseFrm.Text.Contains("."))
            {
                e.Handled = true;
            }

            // Prevent negative sign
            if (e.KeyChar == '-' || e.KeyChar == '+')
            {
                e.Handled = true;
            }
        }

        private void BtnDetainLicense_Click(object sender, EventArgs e)
        {
            decimal FineFees = Convert.ToDecimal(textBoxFineFeesDetainLicenseFrm.Text);
            BusinessLogic.ClsLicense.DetainLicense(LicenseIDToDetain, FineFees, ClsGlobal.CurrentUser.UserID);
            if (MessageBox.Show($"License With ID: {LicenseIDToDetain} Deained!", "Detained Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ctrlLicenseInfoDetailsWithFilter1.ChangeDetainText("Yes");
                BtnDetainLicense.Enabled = false;
            }
        }
    }
}
