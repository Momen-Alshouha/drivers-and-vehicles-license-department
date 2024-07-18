using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDriver;

namespace DVLD.DataAccess
{
    public class ClsDriver
    {
        public static int AddNewDriver(StDriver driver)
        {
            int NewDriverID = -1; // if returns -1 means driver not added

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                    VALUES (@PersonID, @CreatedByUserID, @CreatedDate);

                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", driver.PersonID);
                    command.Parameters.AddWithValue("@CreatedByUserID", driver.CreatedByUserID);
                    command.Parameters.AddWithValue("@CreatedDate", driver.CreatedDate);

                    connection.Open();
                    object result = command.ExecuteScalar();


                    if (result != null && int.TryParse(result.ToString(), out NewDriverID))
                    {
                        // set the DriverID in the StDriver struct
                        driver.DriverID= NewDriverID;
                    }
                }
            }

            return NewDriverID;
        }
    }
}
