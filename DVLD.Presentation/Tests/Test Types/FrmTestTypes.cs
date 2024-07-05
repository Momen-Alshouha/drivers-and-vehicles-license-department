using DVLD.Presentation.Application_Types;
using DVLD.Presentation.Tests.Test_Types;
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

namespace DVLD.Presentation
{
    public partial class FrmTestTypes : Form
    {
        DataTable _dtTestTypes;
        public FrmTestTypes()
        {
           
            InitializeComponent();
            DataGridViewTestTypes.ContextMenuStrip = ContextMenuTestTypes;
        }
        int _NumberOfRecords()
        {
            return _dtTestTypes.Rows.Count;
        }
        void _RefreshNumberOfRecords()
        {
            LblTestTypesRecordsValue.Text = _NumberOfRecords().ToString();
        }
        void _ModifyDataGridViewDesign()
        {
            DataGridViewTestTypes.Columns[0].HeaderText = "ID";
            DataGridViewTestTypes.Columns[1].HeaderText = "Title";
            DataGridViewTestTypes.Columns[2].HeaderText = "Description";
            DataGridViewTestTypes.Columns[2].Width = 242;
            DataGridViewTestTypes.Columns[3].HeaderText = "Fees";
        }
        void _LoadTestTypesInDataGridView()
        {
            this._dtTestTypes = BusinessLogic.ClsTestType.GetAllTestTypes();
            DataGridViewTestTypes.DataSource = _dtTestTypes;
        }
        private void FrmTestTypes_Load(object sender, EventArgs e)
        {
            _LoadTestTypesInDataGridView();
            _ModifyDataGridViewDesign();
            _RefreshNumberOfRecords();
        }

        private void ButtonCloseTestTypesForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripeMenuItemEditTestType_Click(object sender, EventArgs e)
        {
            

            if (DataGridViewTestTypes.SelectedRows.Count > 0)
            {
                int TestTypeId = Convert.ToInt32(DataGridViewTestTypes.SelectedRows[0].Cells[0].Value);
                StTestType TestType = BusinessLogic.ClsTestType.GetTestType(TestTypeId);

                FrmEditTestType editForm = new FrmEditTestType(TestType.id);
                editForm.ShowDialog();
            }
            _LoadTestTypesInDataGridView();
            _ModifyDataGridViewDesign();
            _RefreshNumberOfRecords();
        }
    }
}
