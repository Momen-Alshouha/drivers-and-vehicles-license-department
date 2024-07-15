using System;   
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;
using static DVLD.DataAccess.ClsUser;
using static ClsDataType.ClsDataType;
using System.ComponentModel.Design;

namespace DVLD.DataAccess
{
    public class ClsApplications
    {
        protected static SqlConnection _GetConnection()
        {
            return new SqlConnection(Settings.ConnectionString);
        }
        protected static SqlCommand _CreateCommand(string query, SqlConnection connection, SqlTransaction transaction = null)
        {
            SqlCommand command = new SqlCommand(query, connection);
            if (transaction != null)
            {
                command.Transaction = transaction;
            }
            return command;
        }
        public static DataTable GetAllApplications()
        {
            DataTable dtApplications = new DataTable();
            using (SqlConnection conn = _GetConnection())
            {
                string query = "select * from Applications";
                using (SqlCommand command = _CreateCommand(query,conn))
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
        public static StApplicationData GetAppInfoByID(int id)
        {
            StApplicationData applicationData= new StApplicationData();
            using (SqlConnection conn = _GetConnection())
            {
                string query = @"SELECT Applications.* , LocalDrivingLicenseApplications.LicenseClassID,
                        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID FROM Applications
                                INNER JOIN LocalDrivingLicenseApplications 
                                ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                                   WHERE Applications.ApplicationID = @ApplicationID";
                using (SqlCommand command = _CreateCommand(query,conn))
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
                                applicationData.ApplicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                                applicationData.ApplicationStatus = reader.GetByte(reader.GetOrdinal("ApplicationStatus"));
                                applicationData.LastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate"));
                                applicationData.PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                                StUser user = new StUser();
                                if (ClsUser.GetUser((int)reader.GetInt32(reader.GetOrdinal("CreatedByUserID")),ref user))
                                {
                                    applicationData.CreatedByUser = user;
                                }

                                applicationData.LicenseClassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID"));
                                applicationData.StApplicationTypeInfo = ClsApplicationType.GetAppType(applicationData.StApplicationTypeInfo.id);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while fetching application information.", ex);
                    }
                }
              
            }

            return new StApplicationData(applicationData);
        }
        public static int AddNewApplication(StApplicationData applicationData)
        {
            int newApplicationID = 0;

            using (SqlConnection conn = _GetConnection())
            {
                string query = @"
                    INSERT INTO Applications 
                    (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) 
                    VALUES 
                    (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = _CreateCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicationData.stPerson.Id);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationData.ApplicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationData.StApplicationTypeInfo.id);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationData.ApplicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", applicationData.LastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", applicationData.PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", applicationData.CreatedByUser.UserID);

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

            using (SqlConnection conn = _GetConnection())
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

                using (SqlCommand command = _CreateCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationData.ApplicationID);
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicationData.stPerson.Id);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationData.ApplicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationData.StApplicationTypeInfo.id);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationData.ApplicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", applicationData.LastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", applicationData.PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", applicationData.CreatedByUser.UserID);

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

            using (SqlConnection conn = _GetConnection())
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
        public static bool IsApplicationExistAndActive(StApplicationData applicationData)
        {
            // this method is to checks if a person has an application with same app type and "new" status

            bool isExist = false;

            using (SqlConnection conn = _GetConnection())
            {
                string query = @"
                    SELECT COUNT(1)
                    FROM Applications
                    WHERE ApplicantPersonID = @ApplicantPersonID 
                    AND ApplicationTypeID = @ApplicationTypeID 
                    AND ApplicationStatus = @ApplicationStatus";

                using (SqlCommand command = _CreateCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicationData.stPerson.Id);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationData.StApplicationTypeInfo.id);
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

            int activeAppID = -1;

            using (SqlConnection conn = _GetConnection())
            {
                string query = @"
            SELECT Applications.ApplicationID
            FROM Applications 
            INNER JOIN LocalDrivingLicenseApplications
                ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
            WHERE LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                AND (Applications.ApplicationStatus = @NewStatus OR Applications.ApplicationStatus = @CompletedStatus)
                AND Applications.ApplicantPersonID = @ApplicantPersonID";

                using (SqlCommand command = _CreateCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                    command.Parameters.AddWithValue("@NewStatus", (int)EnApplicationStatus.New);
                    command.Parameters.AddWithValue("@CompletedStatus", (int)EnApplicationStatus.Completed);
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicationData.stPerson.Id);

                    try
                    {
                        conn.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            activeAppID = (int)result;
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

            using (SqlConnection conn = _GetConnection())
            {
                string query = @"
                    UPDATE Applications
                    SET ApplicationStatus = @ApplicationStatus,
                        LastStatusDate = @LastStatusDate
                    WHERE ApplicationID = @ApplicationID";

                using (SqlCommand command = _CreateCommand(query, conn))
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
        public static EnApplicationStatus CheckApplicationStatus(int ApplicationID)
        {
            int ApplicationStatus = 0;
            string query = "SELECT ApplicationStatus FROM Applications WHERE ApplicationID = @ApplicationID";

            using (SqlConnection conn = _GetConnection())
            {
                using (SqlCommand command = _CreateCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        conn.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            ApplicationStatus = (byte)result;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("Error checking application status.", ex);
                    }
                }
            }

            return (EnApplicationStatus)ApplicationStatus;
        }

    }
}
