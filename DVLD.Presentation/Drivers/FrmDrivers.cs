using System.Data;
using System.Windows.Forms;
using System;
using DVLD.Presentation.People;
using DVLD.Presentation.Licenses;

namespace DVLD.Presentation.Drivers
{
    public partial class FrmDrivers : Form
    {
        private DataTable _dtDrivers;
        int PersonId;
        public FrmDrivers()
        {
            InitializeComponent();
            this.DataGridViewDrivers.ContextMenuStrip = contextMenuStripDrivers;
            LoadDriversData();
            ConfigureDataGridViewColumns();
            comboBoxDriversFilter.SelectedIndex = 0; 
            textBoxDriversFilterValue.Visible = false; 
        }
        private void LoadDriversData()
        {
            try
            {
                DataTable dtAllDrivers = BusinessLogic.ClsDriver.GetAllDriversInfo();
                LblDriversRowsCountValue.Text = dtAllDrivers.Rows.Count.ToString();
                _dtDrivers = dtAllDrivers.DefaultView.ToTable(false, "DriverID", "PersonID",
                                                            "NationalNo", "FullName", "CreatedDate", "ActiveLicenses");
                DataGridViewDrivers.DataSource = _dtDrivers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading driver data: " + ex.Message);
            }
        }
        private void ConfigureDataGridViewColumns()
        {
            if (DataGridViewDrivers.Columns.Count == 0) return;

            DataGridViewDrivers.Columns["DriverID"].HeaderText = "Driver ID";
            DataGridViewDrivers.Columns["DriverID"].Width = 50;

            DataGridViewDrivers.Columns["PersonID"].HeaderText = "Person ID";
            DataGridViewDrivers.Columns["PersonID"].Width = 50;

            DataGridViewDrivers.Columns["NationalNo"].HeaderText = "National No.";
            DataGridViewDrivers.Columns["NationalNo"].Width = 120;

            DataGridViewDrivers.Columns["FullName"].HeaderText = "Full Name";
            DataGridViewDrivers.Columns["FullName"].Width = 235;

            DataGridViewDrivers.Columns["CreatedDate"].HeaderText = "Date";
            DataGridViewDrivers.Columns["CreatedDate"].Width = 120;

            DataGridViewDrivers.Columns["ActiveLicenses"].HeaderText = "Active Licenses";
            DataGridViewDrivers.Columns["ActiveLicenses"].Width = 50;
        }
        private void BtnCloseDriversForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBoxDriversFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDriversFilterValue.Visible = comboBoxDriversFilter.SelectedIndex != 0;
            textBoxDriversFilterValue.Text = string.Empty;
            ApplyFilter();
        }
        private void ApplyFilter()
        {
            if (_dtDrivers == null) return;

            string filterText = textBoxDriversFilterValue.Text;
            string filterColumn = "";
            bool isNumericFilter = false;

            switch (comboBoxDriversFilter.SelectedItem.ToString())
            {
                case "Driver ID":
                    filterColumn = "DriverID";
                    isNumericFilter = true;
                    break;
                case "Person ID":
                    filterColumn = "PersonID";
                    isNumericFilter = true;
                    break;
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                default:
                    DataGridViewDrivers.DataSource = _dtDrivers;
                    return;
            }
            if (string.IsNullOrEmpty(filterText))
            {
                DataGridViewDrivers.DataSource = _dtDrivers;
            }
            else
            {
                DataView dv = new DataView(_dtDrivers);

                if (isNumericFilter)
                {
                    if (int.TryParse(filterText, out int filterValue))
                    {
                        dv.RowFilter = string.Format("{0} = {1}", filterColumn, filterValue);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxDriversFilterValue.Text = string.Empty;
                    }
                }
                else
                {
                    dv.RowFilter = string.Format("{0} LIKE '%{1}%'", filterColumn, filterText.Replace("'", "''"));
                }

                DataGridViewDrivers.DataSource = dv;
            }
        }
        private void textBoxDriversFilterValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonDetails frmPersonDetails = new FrmPersonDetails(PersonId);
            frmPersonDetails.ShowDialog();
        }
        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO : issue international license 
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicensesHistory frmLicensesHistory = new FrmLicensesHistory(PersonId);
            frmLicensesHistory.ShowDialog();
        }
        private void DataGridViewDrivers_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewDrivers.SelectedRows.Count > 0)
            {
                PersonId = int.Parse(DataGridViewDrivers.SelectedRows[0].Cells[1].Value.ToString());
            }
        }
    }
}
