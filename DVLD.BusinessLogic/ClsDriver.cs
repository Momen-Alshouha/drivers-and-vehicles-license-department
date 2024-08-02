using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDriver;

namespace DVLD.BusinessLogic
{
    public class ClsDriver
    {
        public static int AddNewDriver(StDriver driver)
        {
            return DataAccess.ClsDriver.AddNewDriver(driver);
        }
        public static DataTable GetAllDriversInfo()
        {
            return DataAccess.ClsDriver.GetAllDriversInfo();
        }
    }
}
