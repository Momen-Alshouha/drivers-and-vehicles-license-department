using System;
using System.Data;
using static ClsDataType.ClsDataType;

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
    }
}
