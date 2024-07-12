using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static ClsDataType.ClsApplication;

namespace DVLD.BusinessLogic
{
    public class ClsLocalDrivingLicenseApplication : ClsApplications
    {
        public static DataTable GetAllLocalDrivingLicenseApplications_View()
        {
            return DataAccess.ClsLocalDrivingLicenseApplications.GetAllLocalDrivingLicenseApplications_View();
        }
        public static int AddNew(StApplicationData applicationData)
        {
            if (DataAccess.ClsLocalDrivingLicenseApplications.GetActiveApplicationIDForLicenseClassForSpcificPerson(applicationData, applicationData.LicenseClassID) == -1)
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
        public static bool Update(StApplicationData applicationData)
        {
            if (DataAccess.ClsApplications.UpdateApplication(applicationData))
            {
                return DataAccess.ClsLocalDrivingLicenseApplications.UpdateLocalDrivingLicenseApplicationByLocalID(applicationData.ApplicationID, applicationData.LicenseClassID);
            }
            return false;
        }
        public static int GetApplicationIDByLocalDrivingLicenseAppID(int LocalDrivingLicenseAppID)
        {
            return DataAccess.ClsLocalDrivingLicenseApplications.GetApplicationIDByLocalDrivingLicenseAppID(LocalDrivingLicenseAppID);
        }

    }
}
