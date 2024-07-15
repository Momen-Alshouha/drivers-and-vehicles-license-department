using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;
using static DVLD.DataAccess.ClsUser;

namespace DVLD.DataAccess
{
    public class ClsLocalDrivingLicenseApplications : ClsApplications
    {
        // TODO: implement method to perform transaction to delete from application and local application related
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
        public static bool DeleteLocalDrivingLicenseApplicationByLocalApplicationID(int LocalApplicationID)
        {
            using (SqlConnection connection = _GetConnection())
            {
                string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalApplicationID);

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
        public static bool IsThereAnyTestAppointmentsForAnApplication(int ApplicationID)
        {
            // This method checks if a local driving license application has any appointments regardless of the test result.
            // The application should not be deleted if it has any appointments.

            bool hasAppointments = false;
            string query = "SELECT 1 FROM TestAppointments WHERE LocalDrivingLicenseApplicationID = @ApplicationID";

            using (SqlConnection connection = _GetConnection())
            {
                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        hasAppointments = result != null;
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("Error checking for test appointments for the application.", ex);
                    }
                }
            }

            return hasAppointments;
        }
        public static bool UpdateLocalApplicationLicenseClass(int LocalDrivingLicenseApplicationID, EnLicenseClass licenseClass)
        {
            string query = "UPDATE LocalDrivingLicenseApplications SET LicenseClassID = @LicenseClassID WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection connection = _GetConnection())
            {
                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", (byte)licenseClass);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("Error updating the license class for the local application.", ex);
                    }
                }
            }
        }
        public static int GetLicenseClassId(int ApplicationID)
        {
            int licenseClassId = 0;
            string query = "SELECT LicenseClassID FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";

            using (SqlConnection connection = _GetConnection())
            {
                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            licenseClassId = (int)result;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("Error fetching LicenseClassID from the LocalDrivingLicenseApplications table.", ex);
                    }
                }
            }

            return licenseClassId;
        }


    }
}
