using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.BusinessLogic
{
    public class ClsInternationalLicenseApplication : ClsApplications
    {
        public static DataTable GetInternationalLicenses(ref int RecordsCount)
        {
            return DataAccess.ClsInternationalLicenseApplication.GetInternationalLicenses(ref RecordsCount);
        }
    }
}
