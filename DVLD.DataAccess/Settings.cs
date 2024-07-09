using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess
{
    internal class Settings
    {
        public static readonly string ConnectionString = "Server=.;Database=dvld;Integrated security=true;TrustServerCertificate=True";

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
