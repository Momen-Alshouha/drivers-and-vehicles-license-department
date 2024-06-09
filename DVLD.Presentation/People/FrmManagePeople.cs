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
using static ClsDataType.ClsDataType;

namespace DVLD.Presentation.People
{
     partial class FrmManagePeople : Form
    {
        public FrmManagePeople()
        {
            InitializeComponent();
            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            this.dgvPeople.ContextMenuStrip = contextMenuStripPeopleDataGridView;
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

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count>0)
            {
                int personId = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells["PersonID"].Value);
                FrmAddEditPerson frmAddEditPerson = new FrmAddEditPerson(personId);
                frmAddEditPerson.ShowDialog();
            }
        }

        private void dgvPeople_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvPeople.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvPeople.ClearSelection();
                    dgvPeople.Rows[hitTestInfo.RowIndex].Selected = true;
                }
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEditPerson frmAddEditPerson = new FrmAddEditPerson();
            frmAddEditPerson.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                int personId = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells["PersonID"].Value);
                FrmPersonDetails frmPersonDetails = new FrmPersonDetails(personId);
                frmPersonDetails.ShowDialog();
            }
        }
    }
}
