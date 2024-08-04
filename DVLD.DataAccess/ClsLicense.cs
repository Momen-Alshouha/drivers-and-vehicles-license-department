using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsLicense;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsDataType;
using System.Data;
using static ClsDataType.ClsInternationaLicenseInfo;
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
        public static StLicense GetLicenseInfo(int ApplicationID)
        {
            StLicense license = new StLicense
            {
                DriverPersonDetails = new StPerson()
            };

            string query = @"
        SELECT Licenses.LicenseID, Licenses.ApplicationID, Licenses.DriverID, Licenses.IssueReason, Licenses.IsActive, Licenses.Notes, Licenses.ExpirationDate, Licenses.IssueDate, Licenses.LicenseClass,
               People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.BirthDate, People.Gender, People.ImagePath
        FROM Licenses
        INNER JOIN Drivers ON Drivers.DriverID = Licenses.DriverID
        INNER JOIN People ON Drivers.PersonID = People.PersonID
        WHERE Licenses.ApplicationID = @ApplicationID";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                license.LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                                license.ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                                license.DriverID = reader.GetInt32(reader.GetOrdinal("DriverID"));

                                // Handle tinyint as EnIssueReason
                                license.IssueReason = (EnIssueReason)reader.GetByte(reader.GetOrdinal("IssueReason"));

                                // Handle bit as boolean
                                license.IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));

                                license.Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes"));
                                license.ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                                license.IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));

                                license.EnLicenseClass = (EnLicenseClass)reader.GetInt32(reader.GetOrdinal("LicenseClass"));


                                license.DriverPersonDetails = new StPerson
                                {
                                    NationalNo = reader.IsDBNull(reader.GetOrdinal("NationalNo")) ? null : reader.GetString(reader.GetOrdinal("NationalNo")),
                                    FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName")),
                                    SecondName = reader.IsDBNull(reader.GetOrdinal("SecondName")) ? null : reader.GetString(reader.GetOrdinal("SecondName")),
                                    ThirdName = reader.IsDBNull(reader.GetOrdinal("ThirdName")) ? null : reader.GetString(reader.GetOrdinal("ThirdName")),
                                    LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName")),
                                    BirthDate = reader.IsDBNull(reader.GetOrdinal("BirthDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                    Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? (short)0 : reader.GetByte(reader.GetOrdinal("Gender")),
                                    ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath"))
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
                // Display SQL exception using a message box
                //MessageBox.Show($"SQL Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                throw ex;
                // Display general exception using a message box
                //MessageBox.Show($"General Exception: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return license;
        }
        public static StLicense GetLicenseInfoByLicenseID(int LicenseID)
        {
            StLicense license = new StLicense
            {
                DriverPersonDetails = new StPerson()
            };

            string query = @"
                SELECT Licenses.LicenseID, Licenses.ApplicationID, Licenses.DriverID, Licenses.IssueReason, Licenses.IsActive, Licenses.Notes, Licenses.ExpirationDate, Licenses.IssueDate, Licenses.LicenseClass,
                       People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.BirthDate, People.Gender, People.ImagePath
                FROM Licenses
                INNER JOIN Drivers ON Drivers.DriverID = Licenses.DriverID
                INNER JOIN People ON Drivers.PersonID = People.PersonID
                WHERE Licenses.LicenseID = @LicenseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                license.LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                                license.ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                                license.DriverID = reader.GetInt32(reader.GetOrdinal("DriverID"));

                                // Handle tinyint as EnIssueReason
                                license.IssueReason = (EnIssueReason)reader.GetByte(reader.GetOrdinal("IssueReason"));

                                // Handle bit as boolean
                                license.IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));

                                license.Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes"));
                                license.ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                                license.IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));

                                license.EnLicenseClass = (EnLicenseClass)reader.GetInt32(reader.GetOrdinal("LicenseClass"));

                                license.DriverPersonDetails = new StPerson
                                {
                                    NationalNo = reader.IsDBNull(reader.GetOrdinal("NationalNo")) ? null : reader.GetString(reader.GetOrdinal("NationalNo")),
                                    FirstName = reader.IsDBNull(reader.GetOrdinal("FirstName")) ? null : reader.GetString(reader.GetOrdinal("FirstName")),
                                    SecondName = reader.IsDBNull(reader.GetOrdinal("SecondName")) ? null : reader.GetString(reader.GetOrdinal("SecondName")),
                                    ThirdName = reader.IsDBNull(reader.GetOrdinal("ThirdName")) ? null : reader.GetString(reader.GetOrdinal("ThirdName")),
                                    LastName = reader.IsDBNull(reader.GetOrdinal("LastName")) ? null : reader.GetString(reader.GetOrdinal("LastName")),
                                    BirthDate = reader.IsDBNull(reader.GetOrdinal("BirthDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                    Gender = reader.IsDBNull(reader.GetOrdinal("Gender")) ? (short)0 : reader.GetByte(reader.GetOrdinal("Gender")),
                                    ImagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? null : reader.GetString(reader.GetOrdinal("ImagePath"))
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("SQL Exception: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("General Exception: " + ex.Message, ex);
            }

            return license;
        }
        public static DataTable GetLocalLicenseHistoryForPerson(int personID)
        {
            DataTable dataTable = new DataTable();

            string query = @"
                SELECT L.LicenseID, L.ApplicationID, L.LicenseClass, L.IssueDate, L.ExpirationDate, L.IsActive
                FROM Licenses L
                INNER JOIN Drivers D ON L.DriverID = D.DriverID
                INNER JOIN People P ON P.PersonID = D.PersonID
                WHERE P.PersonID = @PersonID";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("An error occurred while retrieving license history.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An unexpected error occurred.", ex);
            }

            return dataTable;
        }
        public static DataTable GetInternationalLicenseHistoryForPerson(int personID)
        {
            DataTable dataTable = new DataTable();

            string query = @"
        SELECT L.InternationalLicenseID, L.ApplicationID, L.IssueDate, L.ExpirationDate, L.IsActive
        FROM InternationalLicenses L
        INNER JOIN Drivers D ON L.DriverID = D.DriverID
        INNER JOIN People P ON P.PersonID = D.PersonID
        WHERE P.PersonID = @PersonID";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("An error occurred while retrieving international license history.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An unexpected error occurred.", ex);
            }

            return dataTable;
        }
        public static bool HasAnyLicense(int personID)
        {
            bool hasLicense = false;

            string query = @"
        SELECT CASE 
                   WHEN EXISTS (
                       SELECT 1 
                       FROM Licenses L
                       INNER JOIN Drivers D ON L.DriverID = D.DriverID
                       INNER JOIN People P ON P.PersonID = D.PersonID
                       WHERE P.PersonID = @PersonID
                   ) THEN 1
                   WHEN EXISTS (
                       SELECT 1 
                       FROM InternationalLicenses IL
                       INNER JOIN Drivers D ON IL.DriverID = D.DriverID
                       INNER JOIN People P ON P.PersonID = D.PersonID
                       WHERE P.PersonID = @PersonID
                   ) THEN 1
                   ELSE 0
               END AS HasLicense";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", personID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int hasLicenseValue))
                        {
                            hasLicense = hasLicenseValue == 1;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("An error occurred while checking for licenses.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An unexpected error occurred.", ex);
            }

            return hasLicense;
        }
        public static void DeactivateLicense(int LicenseID)
        {
            string query = "UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            throw new ApplicationException("No license found with the specified LicenseID.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("An error occurred while deactivating the license.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An unexpected error occurred.", ex);
            }
        }
        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isDetained = false;
            string query = @"
                SELECT COUNT(*)
                FROM DetainedLicenses
                WHERE LicenseID = @LicenseID AND IsReleased = 0";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        isDetained = count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("An error occurred while checking if the license is detained.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An unexpected error occurred.", ex);
            }

            return isDetained;
        }
        public static bool IsLicenseExpired(int LicenseID)
        {
            bool isExpired = false;
            string query = @"
        SELECT ExpirationDate
        FROM Licenses
        WHERE LicenseID = @LicenseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && DateTime.TryParse(result.ToString(), out DateTime expirationDate))
                        {
                            isExpired = DateTime.Now > expirationDate;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("An error occurred while checking if the license is expired.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An unexpected error occurred.", ex);
            }

            return isExpired;
        }
        //TODO RenewLicense , DetainLicense, ReleaseLicense , Replace methods.
        public static bool HasInternationalLicense(int LicenseID)
        {
            bool hasInternationalLicense = false;

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT 1 FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LicenseID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            hasInternationalLicense = true;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new ApplicationException("SQL Exception: " + ex.Message, ex);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("General Exception: " + ex.Message, ex);
                }
            }

            return hasInternationalLicense;
        }
        public static StInternationalLicense GetInternationalLicenseInfo(int internationalLicenseID)
        {
            StInternationalLicense licenseInfo = new StInternationalLicense();

            string query = @"
                SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, 
                       IssueDate, ExpirationDate, IsActive, CreatedByUserID 
                FROM InternationalLicenses 
                WHERE InternationalLicenseID = @InternationalLicenseID";

            try
            {
                using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                licenseInfo = new StInternationalLicense
                                {
                                    InternationalLicenseID = reader.GetInt32(reader.GetOrdinal("InternationalLicenseID")),
                                    ApplicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID")),
                                    DriverID = reader.GetInt32(reader.GetOrdinal("DriverID")),
                                    LocalLicenseID = reader.GetInt32(reader.GetOrdinal("IssuedUsingLocalLicenseID")),
                                    IssueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate")),
                                    ExpirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate")),
                                    IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log it, rethrow it, or show a message to the user)
                throw new Exception("An error occurred while fetching the international license info", ex);
            }

            return licenseInfo;
        }

    }
}
