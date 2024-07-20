﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsTestAppintment;
namespace DVLD.BusinessLogic
{
    public class ClsTests
    {
        public static DataTable GetTestAppointments(int localDrivingLicenseApplication,EnTestType enTestType)
        {
            return DataAccess.ClsTest.GetTestAppointments(localDrivingLicenseApplication, enTestType);
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
    }
}
