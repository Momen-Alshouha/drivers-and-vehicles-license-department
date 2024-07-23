using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsTakenTest;
using static ClsDataType.ClsTestAppintment;
namespace DVLD.BusinessLogic
{
    public class ClsTests
    {
        public static DataTable GetTestAppointments(int localDrivingLicenseApplication,EnTestType enTestType)
        {
            return DataAccess.ClsTest.GetTestAppointments(localDrivingLicenseApplication, enTestType);
        }
        public static DateTime GetTestAppintmentDateByID(int TestAppointmentID)
        {
            return DataAccess.ClsTest.GetTestAppointmentDateByID(TestAppointmentID);
        }
        public static bool HasActiveTestAppointment(int localDrivingLicenseApplication, EnTestType enTestType)
        {
            return DataAccess.ClsTest.HasUnlockedTest(localDrivingLicenseApplication, enTestType);
        }
        public static bool DoesLocalAppPassedTestForSpecificTestType(int LocalAppID,EnTestType enTestType)
        {
            return DataAccess.ClsTest.DoesLocalAppPassedTestForSpecificTestType(LocalAppID, enTestType);
        }
        public static bool AddNewTestAppointment(StTestAppointment stTestAppointment)
        {
            return DataAccess.ClsTest.AddTestAppointment(stTestAppointment);   
        }
        public static void TakeTest(StTakenTest stTakenTest)
        {
            DataAccess.ClsTest.TakeTest(stTakenTest);
        }
        public static bool UpdateTestAppointmentToBeLocked(int TestAppointmentID)
        {
            return DataAccess.ClsTest.UpdateTestAppointmentToBeLocked(TestAppointmentID);
        }
        public static int CheckTestResultForTestAppointment(int TestAppointmentID)
        {
            return DataAccess.ClsTest.CheckTestResultForTestAppointment(TestAppointmentID);
        }
        public static bool UpdateTestAppointmentDate(int TestAppointmentID, DateTime NewDate)
        {
            return DataAccess.ClsTest.UpdateTestAppointmentDate(TestAppointmentID, NewDate);
        }
    }
}
