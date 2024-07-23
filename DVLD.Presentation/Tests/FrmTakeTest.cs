using DVLD.Presentation.Tests.Test_Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsTakenTest;
namespace DVLD.Presentation.Tests
{
    public partial class FrmTakeTest : Form
    {
        // TODO: present application data in this form
        public Action OnTestTaken; // event-like delegate   

        StTakenTest StTakenTest;
        int TestAppintmentID = 0;
        public FrmTakeTest(int TestAppintmentID, int LocalAppID)
        {
            this.TestAppintmentID = TestAppintmentID;
            InitializeComponent();
            this.FormClosed += FrmTakeTest_FormClosed;
        }
        private void BtnSaveTakeTestFrm_Click(object sender, EventArgs e)
        {
            if (!RadioButtonPassTest.Checked && !RadioButtonFailTest.Checked)
            {
                MessageBox.Show("Please Select Pass Or Fail!", "Pass Or Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.StTakenTest.TestAppointmentID = this.TestAppintmentID;
            this.StTakenTest.CreatedByUserID = ClsGlobal.CurrentUser.UserID;
            this.StTakenTest.TestResult = (RadioButtonPassTest.Enabled == true);
            this.StTakenTest.Notes = RichTextBoxNoteOnResultTest.Text;
            BusinessLogic.ClsTests.TakeTest(StTakenTest);
            BusinessLogic.ClsTests.UpdateTestAppointmentToBeLocked(TestAppintmentID);
            MessageBox.Show("Test Result Added Successfully!!", "Test Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void FrmTakeTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnTestTaken.Invoke();
        }
    }
}
