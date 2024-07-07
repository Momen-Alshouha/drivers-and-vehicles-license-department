using System;
using System.Collections.Generic;
using System.Data;
using DVLD.DataAccess;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsDataType;

namespace DVLD.BusinessLogic
{
    public class ClsApplications
    {
        public static DataTable GetAllApplications()
        {
            return DataAccess.ClsApplications.GetAllApplications();
        }

        public static StApplicationData GetApplicationByID(int applicationID)
        {
            return DataAccess.ClsApplications.GetAppInfoByID(applicationID);
           
        }

        public static int CreateApplication(StApplicationData applicationData)
        {
            if (!DVLD.DataAccess.ClsApplications.IsApplicationExistAndActive(applicationData))
            {
                return DataAccess.ClsApplications.AddNewApplication(applicationData);
            }
            else
            {
                throw new Exception("An active application already exists for this person and application type.");
            }
        }

        public static bool UpdateApplication(StApplicationData applicationData)
        {
           
           return DataAccess.ClsApplications.UpdateApplication(applicationData);
            
        }

        public static bool DeleteApplication(int applicationID)
        {
            return DataAccess.ClsApplications.DeleteApplication(applicationID);
        }

        public static bool UpdateApplicationStatus(int applicationID, int statusID)
        {
            
            return DataAccess.ClsApplications.UpdateStatus(applicationID, statusID);
           
        }

        public static int GetActiveApplicationIDForLicenseClassForSpecificPerson(StApplicationData applicationData, int licenseClassID)
        {
            return DataAccess.ClsApplications.GetActiveApplicationIDForLicenseClassForSpcificPerson(applicationData, licenseClassID);
        }
    }
}
