using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsDataType;
namespace DVLD.Presentation.Application_Types
{
    public partial class FrmEditAppType : Form
    {
        StApplicationType appType;
        public FrmEditAppType(StApplicationType applicationType)
        {
            this.appType = applicationType;
            InitializeComponent();
            _LoadDefaultAppTypeValues();
        }

        void _LoadDefaultAppTypeValues()
        {
            TxtAppTypeFeesEditForm.Text = appType.fee.ToString();
            TxtAppTypeTitleEditForm.Text = appType.title.ToString();
        }

        StApplicationType _UpdatedAppType(string title,decimal fees)
        {
            StApplicationType applicationType = new StApplicationType();
            applicationType.id = appType.id;
            applicationType.title = title;
            applicationType.fee = fees;
            return applicationType;
        }

        private void ButtonEditAppTypesSave_Click(object sender, EventArgs e)
        {
            StApplicationType applicationType = _UpdatedAppType(TxtAppTypeTitleEditForm.Text, Convert.ToDecimal(TxtAppTypeFeesEditForm.Text));
            if (BusinessLogic.ClsApplicationType.UpdateAppType(applicationType))
            {
                MessageBox.Show("Application Type Updated Successfully!", "Update Application Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Update Application Type", "Something Went Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     }
}
