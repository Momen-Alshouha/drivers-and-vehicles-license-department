﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsTestAppintment;
using static ClsDataType.ClsLocalDrivingLicenseApplications;
using static ClsDataType.ClsApplication;    
namespace DVLD.Presentation.Tests.Test_Appointments.vision_tests
{
    public partial class FrmScheduleTest : Form
    {
        // TODO: test date must be date and time
        // TODO: Get Trails
        int LocalAppID = 0;
        int AppID = 0;
        bool isUpdateDate = false;
        EnApplicationStatus enApplicationStatus;
        StTestAppointment StTestAppointment;
        EnLicenseClass EnLicenseClass;
        string ApplicantFullName="";
        short trial=0;
        int TestAppointmentID = 0;
        StLocalDrivingLicenseApplication StLocalDrivingLicenseApplication;
        public FrmScheduleTest(string ApplicationFullName, int LocalDrivingLicenseApplicationID, EnTestType enTestType, int TestAppointmentID)
        {
            isUpdateDate = true;
            this.TestAppointmentID = TestAppointmentID;
            InitializeComponent();
            InitializeForm(ApplicationFullName, LocalDrivingLicenseApplicationID, enTestType);
            DatePickerScheduleTest.Value = BusinessLogic.ClsTests.GetTestAppintmentDateByID(TestAppointmentID);
        }
        public FrmScheduleTest(string ApplicationFullName, int LocalDrivingLicenseApplicationID, EnTestType enTestType)
        {
            isUpdateDate = false;
            InitializeComponent();
            InitializeForm(ApplicationFullName, LocalDrivingLicenseApplicationID, enTestType);
        }
        private void InitializeForm(string ApplicationFullName, int LocalDrivingLicenseApplicationID, EnTestType enTestType)
        {
            LocalAppID = LocalDrivingLicenseApplicationID;
            AppID = BusinessLogic.ClsApplications.GetApplicationIDByLocalDrivingLicenseAppID(LocalDrivingLicenseApplicationID);
            enApplicationStatus = BusinessLogic.ClsApplications.GetApplicationStatus(AppID);
            DatePickerScheduleTest.MinDate = DateTime.Today.AddDays(1); // only allows selecting future dates
            StTestAppointment.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            StTestAppointment.enTestType = enTestType;
            StTestAppointment.PaidFees = BusinessLogic.ClsTestType.GetTestFees(enTestType);
            this.EnLicenseClass = (EnLicenseClass)BusinessLogic.ClsLocalDrivingLicenseApplication.GetLicenseClassId(LocalDrivingLicenseApplicationID);
            this.ApplicantFullName = ApplicationFullName;
        }
        private string _GetLicenseClassText(EnLicenseClass licenseClass)
        {
            switch (licenseClass)
            {
                case EnLicenseClass.SmallMotorcycle:
                    return "Class 1 - Small Motorcycle";
                case EnLicenseClass.HeavyMotorcycle:
                    return "Class 2 - Heavy Motorcycle License";
                case EnLicenseClass.OrdinaryDriving:
                    return "Class 3 - Ordinary driving license";
                case EnLicenseClass.Commercial:
                    return "Class 4 - Commercial";
                case EnLicenseClass.Agricultural:
                    return "Class 5 - Agricultural";
                case EnLicenseClass.SmallMediumBus:
                    return "Class 6 - Small and medium bus";
                case EnLicenseClass.TruckHeavyVehicle:
                    return "Class 7 - Truck and heavy vehicle";
                default:
                    return "Unknown Class";
            }
        }
        private void _LoadDataInForm()
        {
            _LoadFormDataBasedOnTestType(StTestAppointment.enTestType);
            LblApplicantNameValue.Text = ApplicantFullName;
            LblLocalAppIDValue.Text = StTestAppointment.LocalDrivingLicenseApplicationID.ToString();
            LblClassAppValue.Text = _GetLicenseClassText(EnLicenseClass);
            LblScheduleTestFeesValue.Text = this.StTestAppointment.PaidFees.ToString();
        }
        private void _LoadFormDataBasedOnTestType(EnTestType enTestType)
        {
            switch (enTestType)
            {
                case EnTestType.VisionTest:
                    this.Text = "Schedule Vision Test Appointment";
                    LblScheduleTestTypeTitle.Text = "Vision";
                    GroupBoxScheduleTest.Text = "Vision Test";
                    break;
                case EnTestType.WrittenTheoryTest:
                    this.Text = "Schedule Written Test Appointment";
                    LblScheduleTestTypeTitle.Text = "Written";
                    GroupBoxScheduleTest.Text = "Written Test";
                    break;
                case EnTestType.PracticalStreetTest:
                    this.Text = "Schedule Practical Test Appointment";
                    LblScheduleTestTypeTitle.Text = "Street";
                    GroupBoxScheduleTest.Text = "Street Test";
                    break;
                default:
                    break;
            }
        }
        private void FrmScheduleTest_Load(object sender, EventArgs e)
        {
            _LoadDataInForm();
        }
        private void BtnScheduleTestFormSave_Click(object sender, EventArgs e)
        {
            if (enApplicationStatus == EnApplicationStatus.New)
            {
                BusinessLogic.ClsApplications.UpdateApplicationStatus(AppID, EnApplicationStatus.InProgress);
            }
            StTestAppointment.AppointmentDate = DatePickerScheduleTest.Value;
            StTestAppointment.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            if (isUpdateDate)
            {
                if (BusinessLogic.ClsTests.UpdateTestAppointmentDate(TestAppointmentID,StTestAppointment.AppointmentDate))
                {
                    MessageBox.Show("Test Appointment Updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                if (BusinessLogic.ClsTests.AddNewTestAppointment(StTestAppointment))
                {

                    MessageBox.Show("Test Appointment Added Successfully!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
