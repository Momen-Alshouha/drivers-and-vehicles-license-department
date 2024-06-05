using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.BusinessLogic
{
    public class People
    {
        public static DataTable GetAllPeople()
        {
            return DVLD.DataAccess.ClsPerson.GetAllPeople();
        }

        public static int GetNumberOfPeople() { 
            return DVLD.DataAccess.ClsPerson.GetNumberOfPeople(); 
        }
    }
}
