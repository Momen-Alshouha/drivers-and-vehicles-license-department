using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsDataType
{
    public class ClsDriver
    {
        public struct StDriver
        {
            public int DriverID { get; set; }
            public int PersonID { get; set; }
            public int CreatedByUserID { get; set; }
            public DateTime CreatedDate { get; set; }
        }
    }
}
