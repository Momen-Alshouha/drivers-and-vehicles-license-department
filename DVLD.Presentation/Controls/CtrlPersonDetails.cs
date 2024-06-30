using DVLD.Presentation.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsDataType;

namespace DVLD.Presentation.People.Controls
{
    public partial class CtrlPersonDetails : UserControl
    {
        public StPerson? stPerson = new StPerson();

        public StPerson? Person
        {
            get { return stPerson; }
        }

        public CtrlPersonDetails()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonId)
        {
            this.stPerson = BusinessLogic.ClsPerson.Find(PersonId);
            if (stPerson.HasValue)
            {
                _FillPersonInfo(stPerson);
            }
        }

        public void LoadPersonInfo(string NationalNo)
        {
            this.stPerson = BusinessLogic.ClsPerson.Find(NationalNo);
            if (stPerson.HasValue)
            {
                _FillPersonInfo(stPerson);
            }
        }

        private void _LoadPersonImage()
        {

            string ImagePath = stPerson.Value.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    PictureBoxPersonInfo.ImageLocation = ImagePath;

        }

        private void _FillPersonInfo(StPerson? stPerson)
        {
            LinkLabelPersonInfo.Enabled = true;
            lblPersonID.Text = stPerson.Value.Id.ToString();
            lblNationalNo.Text = stPerson.Value.NationalNo;
            lblFullName.Text = stPerson.Value.FullName;
            lblGendor.Text = stPerson.Value.Gender== 0 ? "Male" : "Female";
            lblEmail.Text = stPerson.Value.Email;
            lblCountry.Text =stPerson.Value.CountryName;
            lblPhone.Text = stPerson.Value.Phone;
            lblDateOfBirth.Text = stPerson.Value.BirthDate.ToShortDateString();
            lblAddress.Text = stPerson.Value.Address;
            _LoadPersonImage();
        }

        //public void ResetPersonInfo()
        //{
        //    stPerson.Value.Id = -1;
        //    lblPersonID.Text = "[????]";
        //    lblNationalNo.Text = "[????]";
        //    lblFullName.Text = "[????]";
        //    pbGendor.Image = Resources.Man_32;
        //    lblGendor.Text = "[????]";
        //    lblEmail.Text = "[????]";
        //    lblPhone.Text = "[????]";
        //    lblDateOfBirth.Text = "[????]";
        //    lblCountry.Text = "[????]";
        //    lblAddress.Text = "[????]";
        //    pbPersonImage.Image = Resources.Male_512;

        //}

        private void LinkLabelPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddEditPerson frmAddEditPerson = new FrmAddEditPerson(stPerson.Value.Id);
            frmAddEditPerson.ShowDialog();

            LoadPersonInfo(stPerson.Value.Id);
        }
    }
}
