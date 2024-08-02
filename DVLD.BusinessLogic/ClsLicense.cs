using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsLicense;
namespace DVLD.BusinessLogic
{
    public class ClsLicense
    {
        public static int IssueLicense(StLicense license)
        {
            return DataAccess.ClsLicense.IssueLicense(license);
        }
        public static short GetDefaultValidityDateLength(int licenseClassId)
        {
            return DataAccess.ClsLicense.GetDefaultValidityDateLength(licenseClassId);
        }
        public static bool HasLicenseForApplication(int applicationID)
        {
            return DataAccess.ClsLicense.HasLicenseForApplication(applicationID);
        }
        public static decimal GetFees(EnLicenseClass licenseClass)
        {
            return DataAccess.ClsLicense.GetFees(licenseClass);
        }
        public static StLicense GetLicenseInfo(int ApplicationID)
        {
            return DataAccess.ClsLicense.GetLicenseInfo(ApplicationID);
        }
    }
}
