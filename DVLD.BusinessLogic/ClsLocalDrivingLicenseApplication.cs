using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;

namespace DVLD.BusinessLogic
{
    public class ClsLocalDrivingLicenseApplication
    {
        public static DataTable GetAllLocalDrivingLicenseApplications_View()
        {
            return DataAccess.ClsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications_View();
        }
        public static int AddNew(StApplicationData applicationData)
        {
            if (DataAccess.ClsLocalDrivingLicenseApplications.GetActiveApplicationIDForLicenseClassForSpcificPerson(applicationData, applicationData.LicenseClassID) == 0)
            {
                int applicationID = DataAccess.ClsApplications.AddNewApplication(applicationData);

                if (applicationID > 0)
                {
                    if (DataAccess.ClsLocalDrivingLicenseApplications.AddNewLocalDrivingLicenseApplication(applicationID, applicationData.LicenseClassID))
                    {
                        return applicationID; 
                    }
                }
            }
            return -1;
        }

    }
}
