using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDataType;
using static ClsDataType.ClsTestAppintment;
using static ClsDataType.ClsTakenTest;

namespace DVLD.DataAccess
{
    public class ClsTest
    {
        public static bool AddTestAppointment(StTestAppointment stTestAppointment)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                    VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", (int)stTestAppointment.enTestType);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", stTestAppointment.LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", stTestAppointment.AppointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", stTestAppointment.PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", stTestAppointment.CreatedByUserID);
                    command.Parameters.AddWithValue("@IsLocked", 0);

                    // Handle RetakeTestApplicationID which is null in add test appointment case
                    SqlParameter retakeParam = new SqlParameter("@RetakeTestApplicationID", DBNull.Value);
                    command.Parameters.Add(retakeParam);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public static bool HasUnlockedTest(int localDrivingLicenseApplicationID, EnTestType enTestType)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM TestAppointments
                    WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                    AND TestTypeID = @TestType
                    AND IsLocked = 0";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestType", (int)enTestType);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static DataTable GetTestAppointments(int localDrivingLicenseApplicationID,EnTestType enTestType)
        {
            DataTable dtVisionTestAppointments = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    SELECT *
                    FROM TestAppointments
                    WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                    AND TestTypeID = @TestType";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@TestType", (int)enTestType);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dtVisionTestAppointments.Load(reader);
                    }
                }
            }

            return dtVisionTestAppointments;
        }
        public static bool HasUnlockedActiveVisionTest(int localDrivingLicenseApplicationID)
        {
            return HasUnlockedTest(localDrivingLicenseApplicationID, EnTestType.VisionTest);
        }
        public static bool HasUnlockedActiveWrittenTest(int localDrivingLicenseApplicationID)
        {
            return HasUnlockedTest(localDrivingLicenseApplicationID, EnTestType.WrittenTheoryTest);
        }
        public static bool HasUnlockedActiveStreetTest(int localDrivingLicenseApplicationID)
        {
            return HasUnlockedTest(localDrivingLicenseApplicationID, EnTestType.PracticalStreetTest);
        }
        public static bool UpdateRetakeTestApplicationIDForTestAppointment(int TestAppointmentID, int RetakeTestApplicationID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    UPDATE TestAppointments
                    SET RetakeTestApplicationID = @RetakeTestApplicationID
                    WHERE TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public static bool UpdateDateOfTestAppointment(int TestAppointmentID, DateTime NewDateTimeAppointment)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    UPDATE TestAppointments
                    SET AppointmentDate = @NewDateTimeAppointment
                    WHERE TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewDateTimeAppointment", NewDateTimeAppointment);
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public static void TakeTest(StTakenTest stTakenTest)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                    VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", stTakenTest.TestAppointmentID);
                    command.Parameters.AddWithValue("@TestResult", stTakenTest.TestResult ? 1 : 0); // mapping from bool to bit
                    command.Parameters.AddWithValue("@Notes", stTakenTest.Notes ?? (object)DBNull.Value); // handle null case
                    command.Parameters.AddWithValue("@CreatedByUserID", stTakenTest.CreatedByUserID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }
        public static bool UpdateTestAppointmentToBeLocked(int TestAppointmentID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    UPDATE TestAppointments
                    SET IsLocked = 1
                    WHERE TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        public static bool IsTestTaken_SpecificTestAppointmentAndTestType(int TestAppointmentID, EnTestType enTestType)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    SELECT COUNT(1)
                    FROM Tests
                    WHERE TestAppointmentID = @TestAppointmentID
                    AND TestTypeID = @TestTypeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    command.Parameters.AddWithValue("@TestTypeID", (int)enTestType);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        public static bool DoesLocalAppPassedTestForSpecificTestType(int LocalAppID, EnTestType enTestType)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    SELECT COUNT(1)
                    FROM TestAppointments
                    JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                    WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalAppID
                    AND TestAppointments.TestTypeID = @TestTypeID
                    AND Tests.TestResult = 1"; // 1 represents 'Passed'

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                    command.Parameters.AddWithValue("@TestTypeID", (int)enTestType);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        public static int GetNumberOfPassedTests(int TestAppointmentID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM Tests
                    WHERE TestAppointmentID = @TestAppointmentID
                    AND TestResult = 1"; // 1 represents 'Passed'

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count;
                }
            }
        }
        public static int CheckTestResultForTestAppointment(int TestAppointmentID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
            SELECT TOP 1 TestResult
            FROM Tests
            WHERE TestAppointmentID = @TestAppointmentID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    // Check if result is null
                    if (result == null || result == DBNull.Value)
                    {
                        return -1; // No record found
                    }

                    // Convert result to integer and interpret the test result
                    int testResult = Convert.ToInt32(result);

                    return testResult; // Returns 0 or 1 based on the test result
                }
            }
        }
        public static DateTime GetTestAppointmentDateByID(int TestAppointmentID)
        {
            DateTime appointmentDate = DateTime.MinValue;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT AppointmentDate FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        appointmentDate = Convert.ToDateTime(result);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (e.g., log error)
                    Console.WriteLine(ex.Message);
                }
            }
            return appointmentDate;
        }
        public static bool UpdateTestAppointmentDate(int TestAppointmentID, DateTime newDate)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "UPDATE TestAppointments SET AppointmentDate = @NewDate WHERE TestAppointmentID = @TestAppointmentID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewDate", newDate);
                command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception (e.g., log error)
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        public static bool DoesLocalAppPassedAllTests(int LocalAppID)
        {

            if (DoesLocalAppPassedTestForSpecificTestType(LocalAppID, EnTestType.PracticalStreetTest))
            {
                if (DoesLocalAppPassedTestForSpecificTestType(LocalAppID, EnTestType.VisionTest))
                {
                    if (DoesLocalAppPassedTestForSpecificTestType(LocalAppID, EnTestType.WrittenTheoryTest))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
