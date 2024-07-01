using System;
using System.Data;
using System.Windows.Forms;
using static ClsDataType.ClsDataType;

namespace DVLD.Presentation.Application_Types
{
    public partial class FrmManageAppTypes : Form
    {
        private DataTable dtAppTypes;
        private DataTable _dtAppTypesDefaultView;

        public FrmManageAppTypes()
        {
            InitializeComponent();
            DataGridViewAppTypes.ContextMenuStrip = ContextMenuAppTypesForm;
            _LoadApplicationTypes();
        }

        private void _LoadApplicationTypes()
        {
            dtAppTypes = BusinessLogic.ClsApplicationType.GetAppsTypes();
            _dtAppTypesDefaultView = dtAppTypes.DefaultView.ToTable(false, "ApplicationTypeID", "ApplicationTypeTitle", "ApplicationFees");
            _RefreshData();
        }

        private void _RefreshData()
        {
            ModifyDataGridViewDesignAndLoadData();
            RefreshNumberOfAppTypesRecords();
        }

        private void ModifyDataGridViewDesignAndLoadData()
        {
            DataGridViewAppTypes.DataSource = _dtAppTypesDefaultView;
            DataGridViewAppTypes.Columns[0].HeaderText = "ID";
            DataGridViewAppTypes.Columns[1].HeaderText = "Title";
            DataGridViewAppTypes.Columns[1].Width = 240;
            DataGridViewAppTypes.Columns[2].HeaderText = "Fees";
        }

        private void RefreshNumberOfAppTypesRecords()
        {
            LblAppTypesRecordsValue.Text = _dtAppTypesDefaultView.Rows.Count.ToString();
        }

        private void ButtonCloseAppTypesForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridViewAppTypes.SelectedRows.Count > 0)
            {
                int appTypeID = Convert.ToInt32(DataGridViewAppTypes.SelectedRows[0].Cells[0].Value);
                StApplicationType applicationType = BusinessLogic.ClsApplicationType.GetAppType(appTypeID);

                FrmEditAppType editForm = new FrmEditAppType(applicationType);
                editForm.ShowDialog();
            }
            _LoadApplicationTypes();
        }
    }
}
