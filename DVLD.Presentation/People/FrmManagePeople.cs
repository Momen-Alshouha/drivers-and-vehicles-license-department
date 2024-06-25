using DVLD.BusinessLogic;
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
        private static DataTable _dtAllPeople = ClsPerson.GetPeople();

        //only select the columns that you want to show in the grid
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                         "FirstName", "SecondName", "ThirdName", "LastName",
                                                         "Gender", "BirthDate", "CountryName",
                                                         "Phone", "Email");


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
            _dtAllPeople = DVLD.BusinessLogic.People.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "BirthDate", "Gender", "Address",
                                                       "Phone", "Email", "CountryName");

            dgvPeople.DataSource = _dtPeople;
            LblNumberOfPeople.Text = dgvPeople.Rows.Count.ToString();

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
            ComboBoxFilterByManagePeopleForm.SelectedItem = "None";
            if (dgvPeople.Rows.Count > 0)
            {

                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;


                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Date Of Birth";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Gender";
                dgvPeople.Columns[7].Width = 120;

                dgvPeople.Columns[8].HeaderText = "Address";
                dgvPeople.Columns[8].Width = 120;


                dgvPeople.Columns[9].HeaderText = "Phone";
                dgvPeople.Columns[9].Width = 120;


                dgvPeople.Columns[10].HeaderText = "Email";
                dgvPeople.Columns[10].Width = 170;


                dgvPeople.Columns[11].HeaderText = "Country Name";
                dgvPeople.Columns[11].Width = 120;
            }

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
                int personId = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells[0].Value);
                FrmAddEditPerson frmAddEditPerson = new FrmAddEditPerson(personId);
                frmAddEditPerson.ShowDialog();
            }
            LoadPeopleInDataGridView();
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
            //frmAddEditPerson.PersonAdded += FrmAddEditPerson_PersonAdded;
            frmAddEditPerson.ShowDialog();
        }

        //private void FrmAddEditPerson_PersonAdded(object sender, EventArgs e)
        //{
        //    LoadPeopleInDataGridView();
        //    LoadNumberOfPeople();
        //}

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                int personId = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells[0].Value);
                FrmPersonDetails frmPersonDetails = new FrmPersonDetails(personId);
                frmPersonDetails.ShowDialog();
            }
        }
        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.SelectedRows.Count > 0)
            {
                int personId = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells[0].Value);
                StPerson? person = BusinessLogic.ClsPerson.Find(personId);

                if (person.HasValue)
                {
                    string fullName = $"{person.Value.FirstName} {person.Value.LastName}";
                    DialogResult result = MessageBox.Show("Are You Sure?", $"Delete {fullName}", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        if (BusinessLogic.ClsPerson.DeletePerson(personId))
                        {
                            MessageBox.Show("Person Deleted Successfully!", "Deleted!", MessageBoxButtons.OK);

                            LoadPeopleInDataGridView();
                            LoadNumberOfPeople();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Person not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a person to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxFilterManagePeopleForm_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (ComboBoxFilterByManagePeopleForm.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Country Name":
                    FilterColumn = "CountryName";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (TextBoxFilterManagePeopleForm.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                LblNumberOfPeople.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TextBoxFilterManagePeopleForm.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, TextBoxFilterManagePeopleForm.Text.Trim());

            LblNumberOfPeople.Text = dgvPeople.Rows.Count.ToString();
        }

        private void ComboBoxFilterByManagePeopleForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxFilterByManagePeopleForm.SelectedIndex != 0)
            {
                TextBoxFilterManagePeopleForm.Visible = true;
            } else
            {
                TextBoxFilterManagePeopleForm.Visible = false;
            }
        }
    }
}
