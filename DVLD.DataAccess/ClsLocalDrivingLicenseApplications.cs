using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsLocalDrivingLicenseApplications;
using static DVLD.DataAccess.ClsUser;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.DataAccess
{
    public class ClsLocalDrivingLicenseApplications : ClsApplications
    {
        public static DataTable GetAllLocalDrivingLicenseApplications_View()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = _GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM LocalDrivingLicenseApplications_View";

                    using (SqlCommand command = _CreateCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                reader.Close();
                                connection.Close();
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
              
                throw new Exception("An error occurred while retrieving the local driving license applications.", sqlEx);
            }
            catch (Exception ex)
            {
               
                throw new Exception("An unexpected error occurred.", ex);
            }
            

            return dt;
        }
        public static bool AddNewLocalDrivingLicenseApplication(int ApplicationID,int LicenseClassID)
        {
            using (SqlConnection connection = _GetConnection())
            {
                string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID)";

                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; 
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("Error inserting into LocalDrivingLicenseApplications table.", ex);
                    }
                }
            }
        }

        public static bool DeleteLocalDrivingLicenseApplication(int localDrivingLicenseApplicationID)
        {
            using (SqlConnection connection = _GetConnection())
            {
                string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("Error deleting from LocalDrivingLicenseApplications table.", ex);
                    }
                }
            }
        }

    }
}
