using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Presentation.Drivers
{
    public partial class FrmDrivers : Form
    {
        private DataTable _dtDrivers;
        public FrmDrivers()
        {
            InitializeComponent();
            LoadDriversData();
            ConfigureDataGridViewColumns();
        }
        private void LoadDriversData()
        {
            try
            {
                DataTable dtAllDrivers = BusinessLogic.ClsDriver.GetAllDriversInfo();
                _dtDrivers = dtAllDrivers.DefaultView.ToTable(false, "DriverID", "PersonID",
                                                            "NationalNo", "FullName", "CreatedDate", "ActiveLicenses");
                DataGridViewDrivers.DataSource = _dtDrivers;
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it and show a message to the user)
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
            DataGridViewDrivers.Columns["FullName"].Width = 250;

            DataGridViewDrivers.Columns["CreatedDate"].HeaderText = "Date";
            DataGridViewDrivers.Columns["CreatedDate"].Width = 120;

            DataGridViewDrivers.Columns["ActiveLicenses"].HeaderText = "Active Licenses";
            DataGridViewDrivers.Columns["ActiveLicenses"].Width = 50;
        }
        private void BtnCloseDriversForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
