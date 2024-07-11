using System;
using System.Data;
using System.Windows.Forms;
using static ClsDataType.ClsApplication;

namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    public partial class FrmManageLocalDrivingLicenseApplication : Form
    {
        DataTable LocalDrivingLicenseApplicationsData_View;

        public FrmManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            this.ContextMenuStrip = ContextMenuStripManageLocalDrivingLicenseApplicationForm;
            _LoadDataInDataGridViewAndLoadNumberOfRecords();
            InitializeDataGridView();
            TextBoxFilterByManageLocalDrivingLicenseForm.TextChanged += TextBoxFilterByManageLocalDrivingLicenseForm_TextChanged;
        }
        private int _GetSelectedLocalDrivingLicenseeApplicationID()
        {
            int selectedLocalDrivingLicenseeApplicationID = 0;
            if (DataGridViewLocalDrivingLicenseApplications_View.SelectedRows.Count>0)
            {
                selectedLocalDrivingLicenseeApplicationID = int.Parse(DataGridViewLocalDrivingLicenseApplications_View.SelectedRows[0].Cells[0].Value.ToString());
            }
            return selectedLocalDrivingLicenseeApplicationID;
        }
        private int _GetApplicationID()
        {
            return BusinessLogic.ClsLocalDrivingLicenseApplication.GetApplicationIDByLocalDrivingLicenseAppID(_GetSelectedLocalDrivingLicenseeApplicationID());
        }
        private void _LoadDataInDataGridViewAndLoadNumberOfRecords()
        {
            this.LocalDrivingLicenseApplicationsData_View = BusinessLogic.ClsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications_View();
            LblNumberOfApplications.Text = LocalDrivingLicenseApplicationsData_View.Rows.Count.ToString();
            DataGridViewLocalDrivingLicenseApplications_View.DataSource = LocalDrivingLicenseApplicationsData_View;
        }

        private void InitializeDataGridView()
        {
            DataGridViewLocalDrivingLicenseApplications_View.Columns[0].HeaderText = "L.D.L.AppID";
            DataGridViewLocalDrivingLicenseApplications_View.Columns[0].Width = 50;
        }

        private void PictureBoxAddNewLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {
            FrmAddEditLocalDrivingLicenseApplication frmLocalDrivingLicenseApplication = new FrmAddEditLocalDrivingLicenseApplication();
            frmLocalDrivingLicenseApplication.ShowDialog();
            _LoadDataInDataGridViewAndLoadNumberOfRecords();
            ApplyFilter(); 
        }

        private void ComboBoxFilterByManageLocalDrivingLicenseForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFilterByManageLocalDrivingLicenseForm.SelectedIndex != 0)
            {
                TextBoxFilterByManageLocalDrivingLicenseForm.Visible = true;
                ApplyFilter();
            }
            else
            {
                TextBoxFilterByManageLocalDrivingLicenseForm.Visible = false;
                TextBoxFilterByManageLocalDrivingLicenseForm.Clear();
                LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = string.Empty;
                LblNumberOfApplications.Text = LocalDrivingLicenseApplicationsData_View.Rows.Count.ToString();
            }
        }

        private void TextBoxFilterByManageLocalDrivingLicenseForm_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string filterColumn = string.Empty;
            switch (ComboBoxFilterByManageLocalDrivingLicenseForm.SelectedItem.ToString())
            {
                case "L.D.L App ID":
                    filterColumn = "LocalDrivingLicenseApplicationID"; 
                    break;
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName"; 
                    break;
                case "Status":
                    filterColumn = "Status"; 
                    break;
                default:
                    filterColumn = string.Empty;
                    break;
            }

            // Reset the filters in case nothing is selected or the filter value contains nothing.
            if (TextBoxFilterByManageLocalDrivingLicenseForm.Text.Trim() == "" || filterColumn == string.Empty)
            {
                LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = string.Empty;
                LblNumberOfApplications.Text = LocalDrivingLicenseApplicationsData_View.Rows.Count.ToString();
                return;
            }

            try
            {
                if (filterColumn == "LocalDrivingLicenseApplicationID")
                {
                    // In this case, we deal with integers
                    if (int.TryParse(TextBoxFilterByManageLocalDrivingLicenseForm.Text.Trim(), out int filterValue))
                    {
                        LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, filterValue);
                    }
                    else
                    {
                        LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = "1 = 0"; // Invalid number filter, no matches
                    }
                }
                else
                {
                    LocalDrivingLicenseApplicationsData_View.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, TextBoxFilterByManageLocalDrivingLicenseForm.Text.Trim());
                }

                LblNumberOfApplications.Text = LocalDrivingLicenseApplicationsData_View.DefaultView.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while applying the filter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure do you want to delete this application ? ","Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (BusinessLogic.ClsLocalDrivingLicenseApplication.DeleteApplication(_GetApplicationID()))
                {
                    MessageBox.Show("Application Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadDataInDataGridViewAndLoadNumberOfRecords();
                } else
                {
                    MessageBox.Show("Something wrong happened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewLocalDrivingLicenseApplications_View.SelectedRows.Count > 0)
            {
                int LDLappID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications_View.SelectedRows[0].Cells[0].Value);

                FrmLocalDrivingLicenseApplicationDetails frmLocalDrivingLicenseApplicationDetails = new FrmLocalDrivingLicenseApplicationDetails(LDLappID);
                frmLocalDrivingLicenseApplicationDetails.ShowDialog();
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Cancel This Application?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (BusinessLogic.ClsLocalDrivingLicenseApplication.UpdateApplicationStatus(_GetApplicationID(), (int)EnApplicationStatus.Canceled))
                {
                    MessageBox.Show("Application Canceled!", "Cancel", MessageBoxButtons.OK);
                    _LoadDataInDataGridViewAndLoadNumberOfRecords();
                }
            }
        }

    }
}
