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
                if (licenseID <= 0)
                {
                    MessageBox.Show("Enter Valid License ID!", "Not Valid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                OnLicenseIDSelected(licenseID);
                ctrlLicenseInfo1.SetLicenseDataInCTRL(licenseID);
            }
        }
        // Method to raise the custom event
        protected virtual void OnLicenseIDSelected(int licenseID)
        {
            LicenseIDSelected?.Invoke(this, licenseID);
        }
    }
}
