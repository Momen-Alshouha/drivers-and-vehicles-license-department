using DVLD.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            _Person.mode = ClsPerson.EnMode.AddNew;
            _Person.Person = new ClsDataType.ClsDataType.StPerson();
        }

        private void InitializePerson(int PersonId)
        {
            _Mode = EnMode.Add;
            _Person = new ClsPerson();
            _Person.mode = ClsPerson.EnMode.Update;
            StPerson? foundPerson = BusinessLogic.ClsPerson.Find(PersonId);
            _Person.Person = foundPerson.Value;
        }


        public FrmAddEditPerson(int PersonId)
        {
            InitializeComponent();
            InitializePerson(PersonId);
            _Mode = EnMode.Update;
            _PersonId = PersonId;
            _LoadPersonData();
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
                _Mode = EnMode.Update;
            } else if (_Mode==EnMode.Update)
            {
                LblAddNewPerson.Text = "Update Person";
                _Mode = EnMode.Add;
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
                LblPersonId.Text = person.Value.Id.ToString();
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
                else
                {
                    PictureBoxPersonImage.Image = null;
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
            PictureBoxPersonImage.Image = null;
            PictureBoxPersonImage.ImageLocation = null;
        }
        private bool _HandlePersonImage()
        {
            
            if (PictureBoxPersonImage.ImageLocation!=null)
            {
                string SourceImageFile = PictureBoxPersonImage.ImageLocation.ToString();
                if (ClsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                {
                    PictureBoxPersonImage.ImageLocation = SourceImageFile;
                    return true;
                } else
                {
                    return false;
                }
            }
            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (PictureBoxPersonImage.ImageLocation != null)
                _Person.Person.ImagePath = PictureBoxPersonImage.ImageLocation;
            else
                _Person.Person.ImagePath = "";

            // To Do:Valiation
            if (!_HandlePersonImage())
                return;

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

            if (PictureBoxPersonImage.ImageLocation != null)
                _Person.Person.ImagePath = PictureBoxPersonImage.ImageLocation;
            else
                _Person.Person.ImagePath = "";

            bool success = false;

            if (_Person.Save())
            {
                success = true;
                LblPersonId.Text = _Person.Person.Id.ToString();
                _SetFormTitleMode();
                // To Do:trigger event to sent data back to the caller form
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

        private void LinkLabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                PictureBoxPersonImage.Load(selectedFilePath);
                LinkLabelRemoveImage.Visible = true;
                // ...
            }
        }

    }
}
