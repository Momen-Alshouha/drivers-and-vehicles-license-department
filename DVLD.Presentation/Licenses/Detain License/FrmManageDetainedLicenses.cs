using DVLD.Presentation.Applications.Release_Detained_License;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Presentation.Licenses.Detain_License
{
    public partial class FrmManageDetainedLicenses : Form
    {
        // TODO: add content menu on detained licenses
        private DataTable dtDetainedLicenses;

        public FrmManageDetainedLicenses()
        {
            InitializeComponent();
            dtDetainedLicenses = BusinessLogic.ClsDetainedLicenses.GetAllDetainedLicenses();
            dataGridViewDetainedLicenses.DataSource = dtDetainedLicenses;
            textBoxFilterManageDetainedLicenses.TextChanged += ApplyFilter;
            comboBoxFilterManageDetainedLicenses.SelectedIndexChanged += ApplyFilter;
        }

        private void ApplyFilter(object sender, EventArgs e)
        {
            string filterColumn = string.Empty;
            string filterValue = textBoxFilterManageDetainedLicenses.Text.Trim();
            string rowFilter = string.Empty;

            // Determine which column to filter by based on the ComboBox selection
            switch (comboBoxFilterManageDetainedLicenses.SelectedItem.ToString())
            {
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "License ID":
                    filterColumn = "LicenseID";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "Detain ID":
                    filterColumn = "DetainID";
                    break;
                default:
                    filterColumn = string.Empty;
                    break;
            }

            // Check if filtering by a numeric column
            if (filterColumn == "LicenseID" || filterColumn == "DetainID")
            {
                // Validate that the input is a number
                if (int.TryParse(filterValue, out int numericFilterValue))
                {
                    // Apply exact match or partial match (e.g., starts with)
                    rowFilter = $"{filterColumn} = {numericFilterValue}";
                }
                else if (string.IsNullOrEmpty(filterValue))
                {
                    // Clear the filter if no value is entered
                    rowFilter = string.Empty;
                }
                else
                {
                    // Show a message if the input is not a valid number
                    MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (!string.IsNullOrEmpty(filterColumn))
            {
                // Apply a string-based filter for non-numeric columns
                rowFilter = $"{filterColumn} LIKE '%{filterValue}%'";
            }

            // Apply the constructed row filter
            dtDetainedLicenses.DefaultView.RowFilter = rowFilter;
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

        private void comboBoxFilterManageDetainedLicenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilterManageDetainedLicenses.SelectedIndex==0)
            {
                textBoxFilterManageDetainedLicenses.Visible = false;
            } else
            {
                textBoxFilterManageDetainedLicenses.Visible = true;
            }
        }

        private void buttonCloseFrm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
