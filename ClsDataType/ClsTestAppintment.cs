using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsDataType
{
    public class ClsTestAppintment
    {
        public enum EnTestType
        {
            VisionTest=1,
            WrittenTheoryTest,
            PracticalStreetTest
        }

        public struct StTestAppointment
        {
            public int TestAppointmentID { get; set; }
            public EnTestType enTestType { get; set; }
            public int LocalDrivingLicenseApplicationID { get; set; }
            public DateTime AppointmentDate { get; set; }
            public decimal PaidFees { get; set; }
            public int CreatedByUserID { get; set; }
            public bool IsLocked { get; set; }
            public int RetakeTestApplicationID { get; set; }
        }
    }
}
