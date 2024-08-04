using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDriver;

namespace DVLD.DataAccess
{
    public class ClsDriver
    {
        public static DataTable GetAllDriversInfo()
        {
            DataTable dtDrivers = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);

            try
            {
                string query = @"
                    SELECT 
                        D.DriverID,
                        D.PersonID, 
                        P.NationalNo,
                        P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                        D.CreatedDate,
                        COUNT(L.DriverID) AS ActiveLicenses
                    FROM 
                        Licenses L
                    INNER JOIN 
                        Drivers D ON D.DriverID = L.DriverID
                    INNER JOIN 
                        People P ON P.PersonID = D.PersonID
                    WHERE 
                        L.IsActive = 1
                    GROUP BY 
                        D.DriverID, 
                        D.PersonID, 
                        P.NationalNo, 
                        P.FirstName, 
                        P.SecondName, 
                        P.ThirdName, 
                        P.LastName, 
                        D.CreatedDate;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dtDrivers.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return dtDrivers;
        }
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
