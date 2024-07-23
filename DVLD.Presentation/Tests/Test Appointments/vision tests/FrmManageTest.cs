using DVLD.Presentation.Applications.LocalDrivingLicenseApplication;
using DVLD.Presentation.Tests.Test_Appointments.vision_tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsLocalDrivingLicenseApplications;
using static ClsDataType.ClsTestAppintment;
namespace DVLD.Presentation.Tests.Test_Appointments
{
    public partial class FrmManageTest : Form
    {
        bool DoesPasTest;
        int applicationID = 0;
        int LocalApplicationID;
        StTestAppointment StTestAppointment;
        DataTable dtTestAppintments;
        EnTestType enTestType;
        public FrmManageTest(int ApplicationID, int LocalApplicationID, EnTestType enTestType)
        {
            InitializeComponent();
            this.LocalApplicationID = LocalApplicationID;
            this.enTestType = enTestType;
            dtTestAppintments = BusinessLogic.ClsTests.GetTestAppointments(LocalApplicationID, enTestType);
            this.applicationID = ApplicationID;
            ctrlLocalDrivingLicenseApplication1.LoadApplicationInfoByLocalDrivingApplicationID(LocalApplicationID);
            _LoadTestAppintmentsInDataGridView();
            _FillFormTextAndTitleBasedOnTestType(enTestType);
            DataGridViewManageTestAppointments.ContextMenuStrip = ContextMenuStripTestAppintments;
        }
        private void _FillFormTextAndTitleBasedOnTestType(EnTestType enTestType)
        {
            switch (enTestType)
            {
                case EnTestType.VisionTest:
                    this.Text = "Manage Vision Test";
                    LblManageTestAppointmentsFrmTitle.Text = "Vision Test Appointments";
                    break;
                case EnTestType.WrittenTheoryTest:
                    this.Text = "Manage Written Test";
                    LblManageTestAppointmentsFrmTitle.Text = "Written Test Appointments";
                    break;
                case EnTestType.PracticalStreetTest:
                    this.Text = "Manage Street Test";
                    LblManageTestAppointmentsFrmTitle.Text = "Street Test Appointments";
                    break;
                default:
                    break;
            }
        }
        private DataTable _GetFilteredTestAppointments()
        {
            // Use the DataView to filter the columns
            DataView view = new DataView(dtTestAppintments);
            DataTable filteredTable = view.ToTable(false, "TestAppointmentID", "AppointmentDate", "PaidFees", "IsLocked");
            return filteredTable;
        }
        private void _LoadTestAppintmentsInDataGridView()
        {
            DataGridViewManageTestAppointments.DataSource = _GetFilteredTestAppointments();
        }
        private void BtnCloseManageVisionTestAppointmentForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PictureBoxAddTestAppointment_Click(object sender, EventArgs e)
        {
            if (BusinessLogic.ClsTests.HasActiveTestAppointment(LocalApplicationID,enTestType))
            {
                MessageBox.Show("Already Has Active Test Appointment!", "Not Allowed!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (BusinessLogic.ClsTests.DoesLocalAppPassedTestForSpecificTestType(LocalApplicationID, enTestType))
            {
                MessageBox.Show("Already Passed This Test!", "Not Allowed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int personId = BusinessLogic.ClsPerson.GetPersonId(applicationID); 
            FrmScheduleTest frmScheduleTest = new FrmScheduleTest(BusinessLogic.ClsPerson.GetApplicantFullName(personId),LocalApplicationID,enTestType);
                frmScheduleTest.ShowDialog();
            _LoadTestAppintmentsInDataGridView();
        }
    }
}
