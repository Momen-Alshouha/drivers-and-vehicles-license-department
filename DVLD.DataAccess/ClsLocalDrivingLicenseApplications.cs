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
        public static int GetApplicationIDByLocalDrivingLicenseAppID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = 0;
            string query = "SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection connection = _GetConnection())
            {
                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            ApplicationID = Convert.ToInt32(result);
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
            }

            return ApplicationID;
        }
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
        public static bool DeleteLocalDrivingLicenseApplicationByApplicationID(int ApplicationID)
        {
            using (SqlConnection connection = _GetConnection())
            {
                string query = "DELETE FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        public static bool UpdateLocalDrivingLicenseApplicationByLocalID(int ApplicationID, int NewLicenseClassID)
        {
            using (SqlConnection connection = _GetConnection())
            {
                string query = @"UPDATE LocalDrivingLicenseApplications 
                         SET LicenseClassID = @LicenseClassID 
                         WHERE ApplicationID = @ApplicationID";
                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", NewLicenseClassID);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

    }
}
