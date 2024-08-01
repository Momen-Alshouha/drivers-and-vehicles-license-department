using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsLicense;
using static ClsDataType.ClsApplication;
namespace DVLD.DataAccess
{
    public class ClsLicense
    {
        public static int IssueLicense(StLicense license)
        {
            int NewLicenseID = -1; // if -1 returns means that license has not been issued

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                    VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);

                    SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", license.ApplicationID);
                    command.Parameters.AddWithValue("@DriverID", license.DriverID);
                    command.Parameters.AddWithValue("@LicenseClass", (int)license.EnLicenseClass);
                    command.Parameters.AddWithValue("@IssueDate", license.IssueDate);
                    command.Parameters.AddWithValue("@ExpirationDate", license.ExpirationDate);
                    command.Parameters.AddWithValue("@Notes", (object)license.Notes ?? DBNull.Value);
                    command.Parameters.AddWithValue("@PaidFees", license.PaidFees);
                    command.Parameters.AddWithValue("@IsActive", license.IsActive);
                    command.Parameters.AddWithValue("@IssueReason", (int)license.IssueReason);
                    command.Parameters.AddWithValue("@CreatedByUserID", license.CreatedByUserID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out NewLicenseID))
                    {
                        // set the LicenseID in the StLicense struct
                        license.LicenseID = NewLicenseID;
                    }
                }
            }

            return NewLicenseID;
        }
        public static short GetDefaultValidityDateLength(int licenseClassId)
        {
            short defaultLength = 0;
            string query = "SELECT DefaultValidityLength FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", licenseClassId);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && short.TryParse(result.ToString(), out defaultLength))
                    {
                        return defaultLength;
                    }
                }
            }

            return defaultLength; // return 0 if not found or in case of error
        }
        public static bool HasLicenseForApplication(int applicationID)
        {
            bool hasLicense = false;
            string query = @"
                SELECT COUNT(*) 
                FROM Licenses 
                WHERE ApplicationID = @ApplicationID AND LicenseClass = 1";

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int count))
                    {
                        hasLicense = count > 0;
                    }
                }
            }

            return hasLicense;
        }
        public static decimal GetFees(EnLicenseClass licenseClass)
        {
            decimal fees = 0;
            string query = "SELECT ClassFees FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseClassID", (int)licenseClass);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out fees))
                    {
                        return fees;
                    }
                }
            }

            return fees; // return 0 if not found or in case of error
        }
    }
}
