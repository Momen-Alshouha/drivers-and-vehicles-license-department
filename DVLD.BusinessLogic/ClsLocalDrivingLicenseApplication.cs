using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsLocalDrivingLicenseApplications;


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
            if (DataAccess.ClsLocalDrivingLicenseApplications.GetActiveApplicationIDForLicenseClassForSpcificPerson(applicationData.stPerson.Id, applicationData.enLicenseClass) == -1)
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
        public static bool IsThereAnyTestAppointmentsForAnApplication(int ApplicationID)
        {
            return DataAccess.ClsLocalDrivingLicenseApplications.IsThereAnyTestAppointmentsForAnApplication(ApplicationID);
        }
        public static bool UpdateApplicationLicenseClass(int PersonId,int LocalApplicationID,EnLicenseClass licenseClass)
        {
            int AppId = DataAccess.ClsApplications.GetActiveApplicationIDForLicenseClassForSpcificPerson(PersonId, licenseClass);
            if (AppId>0)
            {
                return false;
            }
            return DataAccess.ClsLocalDrivingLicenseApplications.UpdateLocalApplicationLicenseClass(LocalApplicationID, licenseClass);
        }
        public static int GetLicenseClassId(int LocalApplicationID)
        {
            return DataAccess.ClsLocalDrivingLicenseApplications.GetLicenseClassId(LocalApplicationID);
        }
    }
}
