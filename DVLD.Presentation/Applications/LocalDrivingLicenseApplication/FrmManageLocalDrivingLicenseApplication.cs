using DVLD.Presentation.Licenses.IssueLicense;
using DVLD.Presentation.Tests.Test_Appointments;
using System;
using System.Data;
using System.Windows.Forms;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsTestAppintment;
using static ClsDataType.ClsLicense;
using ClsDataType;
using DVLD.Presentation.Licenses;
using DVLD.BusinessLogic;

namespace DVLD.Presentation.Applications.LocalDrivingLicenseApplication
{
    public partial class FrmManageLocalDrivingLicenseApplication : Form
    {
        DataTable LocalDrivingLicenseApplicationsData_View;
        int ApplicationId;
        int LocalApplicationID;
        EnApplicationStatus applicationStatus; 
        // TODO: use this to enable and disable menu items based on application status
        private void _EnableDisableScheduleTestsToolStripsMenu(EnApplicationStatus ApplicationStatus)
        {
            scheduleToolStripMenuItem.Enabled = true;
            visionTestToolStripMenuItem.Enabled = false;
            practicalStreetTestToolStripMenuItem.Enabled = false;
            writtenTheoryTestToolStripMenuItem.Enabled = false;

            switch (ApplicationStatus)
            {
                case EnApplicationStatus.New:
                    visionTestToolStripMenuItem.Enabled = true;
                    break;
                case EnApplicationStatus.InProgress:
                    // TODO : Will enable and disable Tool Menu Stipes based on scheduled tests
                    visionTestToolStripMenuItem.Enabled = true;
                    if (BusinessLogic.ClsTests.DoesLocalAppPassedTestForSpecificTestType(LocalApplicationID,EnTestType.VisionTest))
                    {
                        visionTestToolStripMenuItem.Enabled = false;
                        writtenTheoryTestToolStripMenuItem.Enabled= true;
                        if (BusinessLogic.ClsTests.DoesLocalAppPassedTestForSpecificTestType(LocalApplicationID, EnTestType.WrittenTheoryTest))
                        {
                            writtenTheoryTestToolStripMenuItem.Enabled = false;
                            practicalStreetTestToolStripMenuItem.Enabled = true;
                            if (BusinessLogic.ClsTests.DoesLocalAppPassedTestForSpecificTestType(LocalApplicationID, EnTestType.PracticalStreetTest))
                            {
                               scheduleToolStripMenuItem.Enabled = false;
                            }
                        }
                    }
                    break;
                case EnApplicationStatus.Canceled:
                case EnApplicationStatus.Completed:
                    scheduleToolStripMenuItem.Enabled= false;
                    break;
                default:
                    break;
            }
        }
        private void _EnableDisableContextMenuToolsStripe(EnApplicationStatus ApplicationStatus)
        {
            showLicensesToolStripMenuItem.Enabled= false;
            showPersonLicenesHistoryToolStripMenuItem.Enabled= false;

            bool HasLocalDrivingLicense=BusinessLogic.ClsLicense.HasLicenseForApplication(ApplicationId);
            bool HasAnyLicense = BusinessLogic.ClsLicense.HasAnyLicense(BusinessLogic.ClsPerson.GetPersonId(ApplicationId));
            _EnableDisableScheduleTestsToolStripsMenu(ApplicationStatus);
            if (BusinessLogic.ClsTests.DoesLocalAppPassedAllTests(_GetSelectedLocalDrivingLicenseeApplicationID()))
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
            }
            if (ApplicationStatus == EnApplicationStatus.New)
            {
                cancelApplicationToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
            }
            if (HasLocalDrivingLicense)
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicensesToolStripMenuItem.Enabled = true;
            }
            if (HasAnyLicense)
            {
                showPersonLicenesHistoryToolStripMenuItem.Enabled = true;
            }
            //if (EnApplicationStatus.Canceled==ApplicationStatus)
            //{
            //    cancelApplicationToolStripMenuItem.Enabled = false;
            //}
        }
        public FrmManageLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;
            editApplicationToolStripMenuItem.Enabled = false;
            deleteApplicationToolStripMenuItem.Enabled = false;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
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
            DataGridViewLocalDrivingLicenseApplications_View.Columns[2].Width = 100;
            DataGridViewLocalDrivingLicenseApplications_View.Columns[1].Width = 200;
            DataGridViewLocalDrivingLicenseApplications_View.Columns[3].Width = 250;
            DataGridViewLocalDrivingLicenseApplications_View.Columns[5].HeaderText= "Passed Tests";
            DataGridViewLocalDrivingLicenseApplications_View.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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

            if (ComboBoxFilterByManageLocalDrivingLicenseForm.SelectedItem == null) // to avoid NullReferenceException
            {
                return;
            }
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
                if (BusinessLogic.ClsLocalDrivingLicenseApplication.DeleteApplication(_GetSelectedLocalDrivingLicenseeApplicationID()))
                {
                    MessageBox.Show("Application Deleted Successfully!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadDataInDataGridViewAndLoadNumberOfRecords();
                } else
                {
                    MessageBox.Show("You can't delete an application if has any tests or test appointmenets!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (BusinessLogic.ClsLocalDrivingLicenseApplication.UpdateApplicationStatus(_GetApplicationID(), EnApplicationStatus.Canceled))
                {
                    MessageBox.Show("Application Canceled!", "Cancel", MessageBoxButtons.OK);
                    _LoadDataInDataGridViewAndLoadNumberOfRecords();
                }
            }
        }
        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EnApplicationStatus enApplicationStatus = BusinessLogic.ClsApplications.GetApplicationStatus(this._GetApplicationID());

            switch (enApplicationStatus)
            {
                case EnApplicationStatus.New:
                    FrmAddEditLocalDrivingLicenseApplication frmAddEditLocalDrivingLicenseApplication = new FrmAddEditLocalDrivingLicenseApplication(ApplicationId,this._GetSelectedLocalDrivingLicenseeApplicationID());
                    frmAddEditLocalDrivingLicenseApplication.ShowDialog();
                    _LoadDataInDataGridViewAndLoadNumberOfRecords();
                        break;

                default:
                    MessageBox.Show("Can't Edit This Application , Not A New Application!","",MessageBoxButtons.OK,MessageBoxIcon.Stop,MessageBoxDefaultButton.Button1);
                     break;
                }
        }
        private void DataGridViewLocalDrivingLicenseApplications_View_SelectionChanged(object sender, EventArgs e)
        {
            ApplicationId = _GetApplicationID();
            LocalApplicationID = _GetSelectedLocalDrivingLicenseeApplicationID();
            EnApplicationStatus applicationStatus = BusinessLogic.ClsApplications.GetApplicationStatus(ApplicationId);
            _EnableDisableContextMenuToolsStripe(applicationStatus);
        }
        private void addNewApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditLocalDrivingLicenseApplication frmAddEditLocalDrivingLicenseApplication = new FrmAddEditLocalDrivingLicenseApplication();
            frmAddEditLocalDrivingLicenseApplication.ShowDialog();
        }
        private void writtenTheoryTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTestAndRefreshData(EnTestType.WrittenTheoryTest);
        }
        private void practicalStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTestAndRefreshData(EnTestType.PracticalStreetTest);
        }
        private void BtnCloseManageLocalApplicationsForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _ScheduleTestAndRefreshData(EnTestType enTestType)
        {
            FrmManageTest frmManageTest = new FrmManageTest(ApplicationId,LocalApplicationID,enTestType);
            frmManageTest.ShowDialog();
            _LoadDataInDataGridViewAndLoadNumberOfRecords();
        }
        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTestAndRefreshData(EnTestType.VisionTest);
        }
        private void showLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicenseInfoDetails frmLicense = new FrmLicenseInfoDetails(ApplicationId);
            frmLicense.ShowDialog();
        }
        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnIssueReason enIssueReason= EnIssueReason.FirstTime;
            FrmIssueDrivingLicense license = new FrmIssueDrivingLicense(LocalApplicationID, enIssueReason);
            license.ShowDialog();
            _LoadDataInDataGridViewAndLoadNumberOfRecords();
        }
        private void showPersonLicenesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonId = ClsPerson.GetPersonId(ApplicationId);
            FrmLicensesHistory frmLicensesHistory = new FrmLicensesHistory(PersonId);
            frmLicensesHistory.ShowDialog();
        }
    }   
}
