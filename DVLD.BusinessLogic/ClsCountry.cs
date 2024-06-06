using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.BusinessLogic
{
    public class ClsCountry
    {
        public static DataTable GetCountries()
        {
            return DataAccess.ClsCountry.GetAllCountries();
        }

        public static string GetCountryName(int id)
        {
            return new DataAccess.ClsCountry().GetCountryName(id);
        }
        public static int GetCountryID(string CountryName)
        {
            return new DataAccess.ClsCountry().GetCountryId(CountryName);
        }

    }
}
