using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DVLD.DataAccess
{
    internal class Settings
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DVLDConnectionString"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static SqlCommand GetCommand(string query)
        {
            return new SqlCommand(query, GetConnection());
        }
    }

}
