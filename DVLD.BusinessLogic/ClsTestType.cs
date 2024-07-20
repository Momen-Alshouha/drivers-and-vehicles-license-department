using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDataType;
using static ClsDataType.ClsTestAppintment;

namespace DVLD.BusinessLogic
{
    public class ClsTestType
    {
        public static StTestType GetTestType(int id)
        {
            return DataAccess.ClsTestType.GetTestType(id);
        }
        public static DataTable GetAllTestTypes()
        {
            return DataAccess.ClsTestType.GetTestTypes();
        }
        public static bool AddNew(StTestType testType)
        {
            return DataAccess.ClsTestType.AddTestType(testType);
        }
        public static bool Update(StTestType testType)
        {
            return DataAccess.ClsTestType.UpdateTestType(testType);
        }
        public static decimal GetTestFees(EnTestType testType)
        {
            return DataAccess.ClsTestType.GetTestFees(testType);
        }
    }
}
