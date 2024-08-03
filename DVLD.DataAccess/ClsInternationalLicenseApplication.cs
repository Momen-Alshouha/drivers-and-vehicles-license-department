using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess
{
    public class ClsInternationalLicenseApplication : ClsApplications
    {
        public static DataTable GetInternationalLicenses(ref int recordCount)
        {
            DataTable dataTable = new DataTable();

            string query = @"
        SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
        FROM InternationalLicenses";

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            recordCount = dataTable.Rows.Count;
            return dataTable;
        }

    }
}
