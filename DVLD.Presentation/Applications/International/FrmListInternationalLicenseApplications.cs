using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.Applications.International
{
    public partial class FrmListInternationalLicenseApplications : Form
    {
        DataTable DataTableInternationalLicense;
        DataTable _dtView;
        int RowsCounts=0;
        public FrmListInternationalLicenseApplications()
        {
            InitializeComponent();
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
    }
}
