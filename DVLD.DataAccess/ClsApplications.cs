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
    public class ClsApplications
    {
        public static DataTable GetAllApplications()
        {
            DataTable dtApplications = new DataTable();
            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = "select * from Applications";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            
                            dtApplications.Load(reader);
                            reader.Close();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        conn.Close();
                        
                    }
                }
            }
            return dtApplications;
        }
        public static bool GetAppInfoByID(int id, ref StApplicationData applicationData)
        {
            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicationID", id);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                applicationData.ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                                applicationData.ApplicantPersonID = reader.GetInt32(reader.GetOrdinal("ApplicantPersonID"));
                                applicationData.ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                                applicationData.ApplicationTypeID = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID"));
                                applicationData.ApplicationStatus = reader.GetInt32(reader.GetOrdinal("ApplicationStatus"));
                                applicationData.LastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate"));
                                applicationData.PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                                applicationData.CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                                return true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while fetching application information.", ex);
                    }
                }
            }

            return false;
        }
        public static int AddNewApplication(StApplicationData applicationData)
        {
            int newApplicationID = 0;

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    INSERT INTO Applications 
                    (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) 
                    VALUES 
                    (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicationData.ApplicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationData.ApplicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationData.ApplicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationData.ApplicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", applicationData.LastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", applicationData.PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", applicationData.CreatedByUserID);

                    try
                    {
                        conn.Open();
                        newApplicationID = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while adding a new application.", ex);
                    }
                }
            }

            return newApplicationID;
        }
        public static bool UpdateApplication(StApplicationData applicationData)
        {
            bool isUpdated = false;

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    UPDATE Applications
                    SET ApplicantPersonID = @ApplicantPersonID,
                        ApplicationDate = @ApplicationDate,
                        ApplicationTypeID = @ApplicationTypeID,
                        ApplicationStatus = @ApplicationStatus,
                        LastStatusDate = @LastStatusDate,
                        PaidFees = @PaidFees,
                        CreatedByUserID = @CreatedByUserID
                    WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationData.ApplicationID);
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicationData.ApplicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationData.ApplicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationData.ApplicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationData.ApplicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", applicationData.LastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", applicationData.PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", applicationData.CreatedByUserID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        isUpdated = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while updating the application.", ex);
                    }
                }
            }

            return isUpdated;
        }
        public static bool DeleteApplication(int ApplicationID)
        {
            bool isDeleted = false;

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = "DELETE FROM Applications WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        isDeleted = rowsAffected > 0;
                    }
                    catch (Exception ex) { 
                        throw new DataAccessException("An error occurred while deleting the application.", ex);
                    }
                }
            }

            return isDeleted;
        }

        // checks if a person has an application with same app type and new status
        public static bool IsApplicationExistAndActive(StApplicationData applicationData)
        {
            bool isExist = false;

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    SELECT COUNT(1)
                    FROM Applications
                    WHERE ApplicantPersonID = @ApplicantPersonID 
                    AND ApplicationTypeID = @ApplicationTypeID 
                    AND ApplicationStatus = @ApplicationStatus";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicationData.ApplicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationData.ApplicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", 1); 

                    try
                    {
                        conn.Open();
                        int count = (int)command.ExecuteScalar();
                        isExist = count > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while checking if application exists.", ex);
                    }
                }
            }

            return isExist;
        }
        public static int GetActiveApplicationIDForLicenseClassForSpcificPerson(StApplicationData applicationData, int LicenseClassID)
        {
            int activeAppID = 0;

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    SELECT Applications.ApplicationID
                    FROM Applications 
                    INNER JOIN LocalDrivingLicenseApplications
                        ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                    WHERE LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                        AND Applications.ApplicationStatus = @ApplicationStatus
                        AND Applications.ApplicantPersonID = @ApplicantPersonID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                    command.Parameters.AddWithValue("@ApplicationStatus", 1);
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicationData.ApplicantPersonID);


                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                activeAppID = (int)reader["ApplicationID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while fetching the active application ID for license class.", ex);
                    }
                }
            }

            return activeAppID;
        }
        public static bool UpdateStatus(int ApplicationID, int StatusID)
        {
            bool isUpdated = false;

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    UPDATE Applications
                    SET ApplicationStatus = @ApplicationStatus,
                        LastStatusDate = @LastStatusDate
                    WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@ApplicationStatus", StatusID);
                    command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);

                    try
                    {
                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        isUpdated = rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while updating the application status.", ex);
                    }
                }
            }

            return isUpdated;
        
    }

}
}
