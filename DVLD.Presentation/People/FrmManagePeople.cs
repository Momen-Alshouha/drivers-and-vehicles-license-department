using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Presentation.People
{
     partial class FrmManagePeople : Form
    {
        public FrmManagePeople()
        {
            InitializeComponent();
        }
        
        void _LoadPeopleInDataGridView()
        {
            dgvPeople.DataSource = DVLD.BusinessLogic.People.GetAllPeople();
        }
        void _LoadNumberOfPeople()
        {
            int numOfPeople = DVLD.BusinessLogic.People.GetNumberOfPeople();
            LblNumberOfPeople.Text = numOfPeople.ToString();
        }
        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
            _LoadPeopleInDataGridView();
            _LoadNumberOfPeople();
        }
    }
}
