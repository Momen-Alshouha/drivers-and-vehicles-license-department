using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation
{
    public partial class FrmTestTypes : Form
    {
        DataTable _dtTestTypes;
        public FrmTestTypes()
        {
            this._dtTestTypes = BusinessLogic.ClsTestType.GetAllTestTypes();
            InitializeComponent();
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
    }
}
