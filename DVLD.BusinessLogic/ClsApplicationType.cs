using System;
using System.Data;
using static ClsDataType.ClsDataType;
using static ClsDataType.ClsApplication;
using System.Data.SqlClient;
using System.Runtime;

namespace DVLD.BusinessLogic
{
    public class ClsApplicationType
    {
        public static DataTable GetAppsTypes()
        {
            return DataAccess.ClsApplicationType.GetApplicationTypes();
        }
        public static bool UpdateAppType(StApplicationType applicationType)
        {
            return DataAccess.ClsApplicationType.UpdateApplicationType(applicationType);
        }
        public static StApplicationType GetAppType(int id)
        {
            return DataAccess.ClsApplicationType.GetAppType(id);
        }
        public static bool AddNewAppType(StApplicationType applicationType)
        {
            return DataAccess.ClsApplicationType.AddNew(applicationType);
        }
        public static int GetApplicationTypeIDByApplicationID(int ApplicationID)
        {
            return DataAccess.ClsApplicationType.GetApplicationTypeIDByApplicationID(ApplicationID);
        }
        public static decimal GetApplicationFeesByApplicationTypeID(EnApplicationType applicationType)
        {
            return DataAccess.ClsApplicationType.GetApplicationFeesByApplicationTypeID(applicationType);
        }
        public static string GetApplicationTypeText(EnApplicationType applicationType)
        {
            return DataAccess.ClsApplicationType.GetApplicationTypeText(applicationType);
        }
    }
}
