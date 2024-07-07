using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;

namespace ClsDataType
{
    public class ClsLocalDrivingLicenseApplications
    {
        public struct StLocalDrivingLicenseApplication
        {
            public int LocalDrivingLicenseApplicationID { get; set; }
            public int ApplicationID { get; set; }
            public int LicenseClassID { get; set; }
            public StApplicationData ApplicationData { get; set; }

            public StLocalDrivingLicenseApplication(
                int localDrivingLicenseApplicationID,
                int applicationID,
                int licenseClassID,
                StApplicationData applicationData)
            {
                LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
                ApplicationID = applicationID;
                LicenseClassID = licenseClassID;
                ApplicationData = applicationData;
            }
        }
    }
}
