using DVLD.BusinessLogic;
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

namespace DVLD.Presentation.People.Controls
{
    public partial class FrmAddEditPerson : Form
    {
        enum EnMode
        {
            Add=0,Update=1
        }

        private int _PersonId =-1;
        private EnMode _Mode;
        private ClsPerson _Person;
        private FrmManagePeople _ParentForm = new FrmManagePeople();

        public FrmAddEditPerson()
        {
            InitializeComponent();
            InitializePerson();
        }

        private void InitializePerson()
        {
            _Person = new ClsPerson();
            _Person.Person = new ClsDataType.ClsDataType.StPerson();
        }

        public FrmAddEditPerson(int PersonId)
        {
            InitializeComponent();
            _Mode = EnMode.Update;
            _PersonId = PersonId;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable GetCountries()
        {
            return BusinessLogic.ClsCountry.GetCountries();
        }
        private void _LoadCountriesInComboBox()
        {
            foreach (DataRow Row in GetCountries().Rows)
            {
                ComboBoxCountries.Items.Add(Row["CountryName"]);
            }
            ComboBoxCountries.SelectedItem = "Jordan";
        }
        private void _SetFormTitleMode()
        {
            if (_Mode==EnMode.Add)
            {
                LblAddNewPerson.Text = "Add New Person";
            } else if (_Mode==EnMode.Update)
            {
                LblAddNewPerson.Text = "Update Person";
            }
        }
        private void _ResetTexts()
        {
            TxtAddress.Text = "";
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtSecondName.Text = "";
            TxtThirdName.Text = "";
            TxtPhone.Text = "";
            TxtEmail.Text = "";
            TxtNationalNo.Text = "";
        }
        private void _ResetDefaultValues()
        {
            _LoadCountriesInComboBox();
            _SetFormTitleMode();
            if (PictureBoxPersonImage.ImageLocation==null)
            {
                LinkLabelRemoveImage.Visible = false;
            }
            DTPDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            DTPDateOfBirth.MinDate = DateTime.Now.AddYears(-100);
            DTPDateOfBirth.Value = DateTime.Now.AddYears(-18);

            _ResetTexts();
        }
        void _LoadPersonData()
        {
            StPerson? person = BusinessLogic.ClsPerson.Find(_PersonId);
            if (person.HasValue)
            {
                TxtNationalNo.Text = person.Value.NationalNo;
                TxtFirstName.Text = person.Value.FirstName;
                TxtSecondName.Text = person.Value.SecondName;
                TxtThirdName.Text = person.Value.ThirdName;
                TxtLastName.Text = person.Value.LastName;
                DTPDateOfBirth.Value = person.Value.BirthDate;

                if (person.Value.Gender == 0)
                {
                    RadioButtonMale.Checked = true;
                }
                else if (person.Value.Gender == 1)
                {
                    RadioButtonFemale.Checked = true;
                }

                TxtAddress.Text = person.Value.Address;
                TxtPhone.Text = person.Value.Phone;
                TxtEmail.Text = person.Value.Email;
                ComboBoxCountries.SelectedItem = BusinessLogic.ClsCountry.GetCountryName(person.Value.NationalityCountryId);

                
                if (!string.IsNullOrEmpty(person.Value.ImagePath))
                {
                    PictureBoxPersonImage.ImageLocation = person.Value.ImagePath;
                }

            }
        }
        private void FrmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode==EnMode.Update)
            {
                _LoadPersonData();
            }
        }

        private void LinkLabelRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureBoxPersonImage.ImageLocation = null;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _Person.Person.NationalityCountryId = BusinessLogic.ClsCountry.GetCountryID(ComboBoxCountries.SelectedItem.ToString());

            _Person.Person.FirstName = TxtFirstName.Text.Trim();
            _Person.Person.SecondName = TxtSecondName.Text.Trim();
            _Person.Person.ThirdName = TxtThirdName.Text.Trim();
            _Person.Person.LastName = TxtLastName.Text.Trim();
            _Person.Person.BirthDate = DTPDateOfBirth.Value;
            _Person.Person.Address = TxtAddress.Text.Trim();
            _Person.Person.Phone = TxtPhone.Text.Trim();
            _Person.Person.Email = TxtEmail.Text.Trim();
            _Person.Person.NationalNo = TxtNationalNo.Text.Trim();

            if (RadioButtonMale.Checked)
            {
                _Person.Person.Gender = 0;
            }
            else if (RadioButtonFemale.Checked)
            {
                _Person.Person.Gender = 1;
            }
            else
            {
                MessageBox.Show("Please select a gender.");
                return;
            }

            // Optionally handle the image path
            _Person.Person.ImagePath = PictureBoxPersonImage.Text.Trim();
            _Person.Person.ImagePath = "test";

            // Save the person data using the appropriate business logic method
            bool success = false;

            if (_Person.Save())
            {
                success = true;
                _ParentForm.LoadNumberOfPeople();
                _ParentForm.LoadPeopleInDataGridView();
            }

            if (success)
            {
                MessageBox.Show("Person data saved successfully.");
            }
            else
            {
                MessageBox.Show("An error occurred while saving the person data.");
            }
        }

      
    }
}
