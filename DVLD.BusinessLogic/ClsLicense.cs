using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsLicense;
using static ClsDataType.ClsInternationaLicenseInfo;
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
        public static StLicense GetLicenseInfoByLicenseID(int LicenseID)
        {
            return DataAccess.ClsLicense.GetLicenseInfoByLicenseID(LicenseID);
        }
        public static DataTable GetLocalLicenseHistoryForPerson(int PersonID)
        {
            return DataAccess.ClsLicense.GetLocalLicenseHistoryForPerson(PersonID);
        }
        public static DataTable GetInternationalLicenseHistoryForPerson(int PersonID)
        {
            return DataAccess.ClsLicense.GetInternationalLicenseHistoryForPerson(PersonID);
        }
        public static bool HasAnyLicense(int PersonID)
        {
            return DataAccess.ClsLicense.HasAnyLicense(PersonID);
        }
        public static void DeactivateLicense(int LicenseID)
        {
            DataAccess.ClsLicense.DeactivateLicense(LicenseID);
        }
        public static bool IsLicenseDetained(int LicenseID)
        {
            return DataAccess.ClsLicense.IsLicenseDetained(LicenseID);
        }
        public static bool IsLicenseExpired(int LicenseID)
        {
            return DataAccess.ClsLicense.IsLicenseExpired(LicenseID);
        }
        public static bool HasInternationalLicense(int LicenseID)
        {
            return DataAccess.ClsLicense.HasInternationalLicense(LicenseID);
        }
        public static StInternationalLicense GetInternationalLicense(int InternationalLicenseID)
        {
            return DataAccess.ClsLicense.GetInternationalLicenseInfo(InternationalLicenseID);
        }
        public static string GetLicenseClassText(EnLicenseClass enLicenseClass)
        {
            return DataAccess.ClsLicense.GetLicenseClassText(enLicenseClass);
        }
    }
}
