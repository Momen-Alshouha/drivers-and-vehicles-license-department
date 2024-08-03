using System.Data;
using System.Windows.Forms;
using System;

namespace DVLD.Presentation.Applications.International
{
    public partial class FrmListInternationalLicenseApplications : Form
    {
        DataTable DataTableInternationalLicense;
        DataTable _dtView;
        int RowsCounts = 0;

        public FrmListInternationalLicenseApplications()
        {
            InitializeComponent();
            textBoxFilterInternationalLicenseIDValue.Visible = false;
            comboBoxFilterInternationalLicenses.Items.AddRange(new object[] { "Driver ID", "International License ID" });
            comboBoxFilterInternationalLicenses.SelectedIndex = 0;
            RefreshDataGridRecordsAndCount();
            ModifyDataGridViewDesign();
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
    }
}
