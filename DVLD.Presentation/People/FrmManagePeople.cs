using DVLD.Presentation.People.Controls;
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
        
        public void LoadPeopleInDataGridView()
        {
            dgvPeople.DataSource = DVLD.BusinessLogic.People.GetAllPeople();
        }
        public void LoadNumberOfPeople()
        {
            int numOfPeople = DVLD.BusinessLogic.People.GetNumberOfPeople();
            LblNumberOfPeople.Text = numOfPeople.ToString();
        }
        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
            LoadPeopleInDataGridView();
            LoadNumberOfPeople();
        }

        private void pictureBoxAddPerson_Click(object sender, EventArgs e)
        {
            FrmAddEditPerson frmAddEditPerson = new FrmAddEditPerson();
            frmAddEditPerson.ShowDialog();
        }
    }
}
