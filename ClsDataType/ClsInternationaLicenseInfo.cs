using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsDataType;

namespace ClsDataType
{
    public class ClsInternationaLicenseInfo
    {
        public struct StInternationalLicense
        {

            public int InternationalLicenseID { get; set; }
            public int ApplicationID { get; set; }
            public int DriverID { get; set; }
            public int LocalLicenseID { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public decimal PaidFees { get; set; }
            public bool IsActive { get; set; }
            public int CreatedByUserID { get; set; }
            public StPerson DriverPersonDetails { get; set; }
        }
    }
}
