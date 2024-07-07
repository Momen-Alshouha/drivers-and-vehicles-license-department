using System;
using System.Collections.Generic;
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
        public static bool AddNewLocalDrivingLicenseApplication(StLocalDrivingLicenseApplication localDrivingLicenseApplication)
        {
            using (SqlConnection connection = _GetConnection())
            {
                string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID)";

                using (SqlCommand command = _CreateCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", localDrivingLicenseApplication.ApplicationData.ApplicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", localDrivingLicenseApplication.LicenseClassID);

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
