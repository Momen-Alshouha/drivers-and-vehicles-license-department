using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDetainedLicense;

namespace DVLD.BusinessLogic
{
    public class ClsDetainedLicenses
    {
        public static DataTable GetAllDetainedLicenses()
        {
            return DataAccess.ClsDetainedLicenses.GetAllDetainedLicenses();
        }
        public static StDetainLicense? GetDetainedLicenseByDetainID(int detainID)
        {
            return DataAccess.ClsDetainedLicenses.GetDetainedLicenseByDetainID(detainID);
        }
        public static StDetainLicense? GetDetainedLicenseByLicenseID(int licenseID)
        {
            return DataAccess.ClsDetainedLicenses.GetDetainedLicenseByLicenseID(licenseID);
        }
    }
}
