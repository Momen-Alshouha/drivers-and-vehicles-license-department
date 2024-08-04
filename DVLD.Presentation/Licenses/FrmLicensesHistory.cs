using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.Licenses
{
    public partial class FrmLicensesHistory : Form
    {
        int SelectedApplicationID = 0;
        int PersonID;
        public FrmLicensesHistory()
        {
            InitializeComponent();
           // default constructor in case we want to add filters in this form
           // filters on person CTRLpersonDetailsWithFilter
        }
        public FrmLicensesHistory(int PersonID)
        {
            this.PersonID = PersonID;
            InitializeComponent();
            dataGridViewInternationalLicensesHistory.ContextMenuStrip = contextMenuStripLicensesHistoryFormShowLicense;
            dataGridViewLocalLicensesHistory.ContextMenuStrip = contextMenuStripLicensesHistoryFormShowLicense;
            ctrlPersonDetails1.LoadPersonInfo(PersonID);
        }
        private void BtnLicenseHistoryCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmLicensesHistory_Load(object sender, EventArgs e)
        {
            dataGridViewInternationalLicensesHistory.DataSource = BusinessLogic.ClsLicense.GetInternationalLicenseHistoryForPerson(PersonID);
            dataGridViewLocalLicensesHistory.DataSource = BusinessLogic.ClsLicense.GetLocalLicenseHistoryForPerson(PersonID);
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmLicenseInfoDetails frmLicenseInfoDetails = new FrmLicenseInfoDetails(this.SelectedApplicationID);
            frmLicenseInfoDetails.ShowDialog();
        }
        private void dataGridViewLocalLicensesHistory_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLocalLicensesHistory.SelectedRows.Count > 0)
            {
                this.SelectedApplicationID = int.Parse(dataGridViewLocalLicensesHistory.SelectedRows[0].Cells[1].Value.ToString());
            }
            if (dataGridViewInternationalLicensesHistory.SelectedRows.Count > 0)
            {
                this.SelectedApplicationID= int.Parse(dataGridViewInternationalLicensesHistory.SelectedRows[1].Cells[0].Value.ToString());
            }
        }
    }
}
