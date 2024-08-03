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
        int PersonID;
        public FrmLicensesHistory(int PersonID)
        {
            this.PersonID = PersonID;
            InitializeComponent();
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
    }
}
