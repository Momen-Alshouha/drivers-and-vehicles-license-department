using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;

namespace ClsDataType
{
    public class ClsLicense
    {
        public enum EnIssueReason
        {
            FirstTime = 1,
            Renew,
            ReplacementDamaged,
            ReplacementLost
        }

        public struct StLicense
        {
            public int LicenseID { get; set; }
            public int ApplicationID { get; set; }
            public int DriverID { get; set; }
            public EnLicenseClass EnLicenseClass { get; set; }
            public DateTime IssueDate { get; set; }
            public DateTime ExpirationDate { get; set; }
            public string Notes { get; set; }
            public decimal PaidFees { get; set; }
            public bool IsActive { get; set; }
            public EnIssueReason IssueReason { get; set; }
            public int CreatedByUserID { get; set; }
        }
    }
}
