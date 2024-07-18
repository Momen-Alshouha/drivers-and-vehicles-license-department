﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDataType;
using static ClsDataType.ClsTestAppintment;

namespace DVLD.DataAccess
{
    public class ClsTestAppointment
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
                    command.Parameters.AddWithValue("@TestTypeID", stTestAppointment.enTestType);
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", stTestAppointment.LocalDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@AppointmentDate", stTestAppointment.AppointmentDate);
                    command.Parameters.AddWithValue("@PaidFees", stTestAppointment.PaidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", stTestAppointment.CreatedByUserID);
                    command.Parameters.AddWithValue("@IsLocked", stTestAppointment.IsLocked ? 1 : 0); 

                    // Handle RetakeTestApplicationID which is null in add test appointment case
                    SqlParameter retakeParam = new SqlParameter("@RetakeTestApplicationID",DBNull.Value);
                    command.Parameters.Add(retakeParam);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }
        private static bool HasUnlockedTest(int localDrivingLicenseApplicationID, EnTestType enTestType)
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
        public static DataTable GetVisionTestAppointments(int localDrivingLicenseApplicationID)
        {
            DataTable dtVisionTestAppointments = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    SELECT *
                    FROM TestAppointments
                    WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                    AND TestTypeID = @VisionTest";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
                    command.Parameters.AddWithValue("@VisionTest", (int)EnTestType.VisionTest);

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
    }
}
