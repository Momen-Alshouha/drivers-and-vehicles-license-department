using System;
using System.Windows.Forms;

namespace DVLD.Presentation.Controls
{
    public partial class CtrlLicenseInfoDetailsWithFilter : UserControl
    {
        // Define custom event
        public event EventHandler<int> LicenseIDSelected;
        public CtrlLicenseInfoDetailsWithFilter()
        {
            InitializeComponent();
        }
        private void pictureBoxSearchFilterLicenseID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLicenseIDFilterValue.Text))
            {
                return;
            }
            else
            {
                int licenseID = Convert.ToInt32(textBoxLicenseIDFilterValue.Text);
                bool LicenseFound=true;
                if (licenseID <= 0)
                {
                    MessageBox.Show("Enter Valid License ID!", "Not Valid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                OnLicenseIDSelected(licenseID, LicenseFound);
                ctrlLicenseInfo1.SetLicenseDataInCTRLByLicenseID(licenseID);
            }
        }
        // Method to raise the custom event
        protected virtual void OnLicenseIDSelected(int licenseID, bool LicenseFound)
        {
            LicenseIDSelected?.Invoke(this, licenseID);
        }

        private void textBoxLicenseIDFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Prevent the character from being entered
                e.Handled = true;
            }

            // Enter pressed case
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                pictureBoxSearchFilterLicenseID_Click(sender, e);
            }
        }
        public void ChangeDetainTextToBeDetained()
        {
            ctrlLicenseInfo1.changedetainedTextToBeDetaind();
        }
    }
}
