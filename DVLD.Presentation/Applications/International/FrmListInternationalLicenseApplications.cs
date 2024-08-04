using System.Data;
using System.Windows.Forms;
using System;
using DVLD.Presentation.Licenses;
using DVLD.Presentation.People;
using DVLD.Presentation.Licenses.International;

namespace DVLD.Presentation.Applications.International
{
    public partial class FrmListInternationalLicenseApplications : Form
    {
        DataTable DataTableInternationalLicense;
        DataTable _dtView;
        int RowsCounts = 0;
        int SelectedPersonID;
        int SelectedApplicationID;
        int SelectedDriverID;
        int SelectedInternationalLicenseID;
        public FrmListInternationalLicenseApplications()
        {
            InitializeComponent();
            textBoxFilterInternationalLicenseIDValue.Visible = false;
            comboBoxFilterInternationalLicenses.SelectedIndex = 0;
            RefreshDataGridRecordsAndCount();
            ModifyDataGridViewDesign();
            dataGridViewInternationalApplications.ContextMenuStrip = contextMenuStripListInternationalLicenseForm;
        }

        private void RefreshDataGridRecordsAndCount()
        {
            DataTableInternationalLicense = BusinessLogic.ClsInternationalLicenseApplication.GetInternationalLicenses(ref RowsCounts);
            dataGridViewInternationalApplications.DataSource = DataTableInternationalLicense;
            LblInternationalLicenseApplicationsRecordsCountValues.Text = RowsCounts.ToString();
        }

        private void ModifyDataGridViewDesign()
        {
            dataGridViewInternationalApplications.Columns[0].HeaderText = "I.L ID";
            dataGridViewInternationalApplications.Columns[0].Width = 70;
            dataGridViewInternationalApplications.Columns[1].HeaderText = "App ID";
            dataGridViewInternationalApplications.Columns[1].Width = 70;
            dataGridViewInternationalApplications.Columns[2].HeaderText = "Driver ID";
            dataGridViewInternationalApplications.Columns[2].Width = 70;
            dataGridViewInternationalApplications.Columns[3].HeaderText = "L.L ID";
            dataGridViewInternationalApplications.Columns[3].Width = 70;
            dataGridViewInternationalApplications.Columns[4].HeaderText = "Issue Date";
            dataGridViewInternationalApplications.Columns[5].HeaderText = "Ex. Date";
            dataGridViewInternationalApplications.Columns[6].HeaderText = "Is Active";
            dataGridViewInternationalApplications.Columns[6].Width = 70;
        }

        private void BtnInternationalApplicationsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxNewInternationalApplication_Click(object sender, EventArgs e)
        {
            // TODO: 
        }

        private void comboBoxFilterInternationalLicenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilterInternationalLicenseIDValue.Visible = true;
            textBoxFilterInternationalLicenseIDValue.Text = string.Empty;
            ApplyFilter();
        }

        private void textBoxFilterInternationalLicenseIDValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            LblValidateInputLicenseAppList.Visible = false;
            string filterText = textBoxFilterInternationalLicenseIDValue.Text;
            string filterColumn = comboBoxFilterInternationalLicenses.SelectedItem.ToString() == "Driver ID" ? "DriverID" : "InternationalLicenseID";

            if (string.IsNullOrEmpty(filterText))
            {
                dataGridViewInternationalApplications.DataSource = DataTableInternationalLicense;
            }
            else
            {
                if (int.TryParse(filterText, out int filterValue))
                {
                    DataView dv = new DataView(DataTableInternationalLicense);
                    dv.RowFilter = string.Format("{0} = {1}", filterColumn, filterValue);
                    dataGridViewInternationalApplications.DataSource = dv;
                }
                else
                {
                   LblValidateInputLicenseAppList.Visible = true;
                }
            }

            LblInternationalLicenseApplicationsRecordsCountValues.Text = dataGridViewInternationalApplications.Rows.Count.ToString();
        }
        private int _GetSelectedApplicationID()
        {
            int SelectedApplicationID = 0;
            if (dataGridViewInternationalApplications.SelectedRows.Count > 0)
            {
                SelectedApplicationID= Convert.ToInt32(dataGridViewInternationalApplications.SelectedRows[0].Cells[1].Value);
            }
            return SelectedApplicationID;
        }
        private int _GetSelectedInternationalLicenseID()
        {
            int SelectedApplicationID = 0;
            if (dataGridViewInternationalApplications.SelectedRows.Count > 0)
            {
                SelectedApplicationID = Convert.ToInt32(dataGridViewInternationalApplications.SelectedRows[0].Cells[0].Value);
            }
            return SelectedApplicationID;
        }

        private int _GetSelectedDriverID()
        {
            int SelectedApplicationID = 0;
            if (dataGridViewInternationalApplications.SelectedRows.Count > 0)
            {
                SelectedApplicationID = Convert.ToInt32(dataGridViewInternationalApplications.SelectedRows[0].Cells[2].Value);
            }
            return SelectedApplicationID;
        }
        private int _GetSelectedPersonID()
        {
            int PersonID = BusinessLogic.ClsPerson.GetPersonId(_GetSelectedApplicationID());
            return PersonID;
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInternationalLicenseInfo frmInternationalLicenseInfo = new FrmInternationalLicenseInfo(this.SelectedDriverID,this.SelectedInternationalLicenseID);
            frmInternationalLicenseInfo.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonDetails frmPersonDetails = new FrmPersonDetails(_GetSelectedPersonID());
            frmPersonDetails.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicensesHistory frmLicensesHistory = new FrmLicensesHistory(this.SelectedPersonID);
            frmLicensesHistory.ShowDialog();
        }

        private void dataGridViewInternationalApplications_SelectionChanged(object sender, EventArgs e)
        {
            this.SelectedApplicationID = _GetSelectedApplicationID();
            this.SelectedPersonID = _GetSelectedPersonID();
            this.SelectedDriverID = _GetSelectedDriverID();
            this.SelectedInternationalLicenseID = _GetSelectedInternationalLicenseID();
        }
    }
}
