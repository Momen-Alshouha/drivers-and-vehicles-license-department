using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static ClsDataType.ClsDetainedLicense;
namespace DVLD.DataAccess
{
    public class ClsDetainedLicenses
    {
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dtDetainedLicenses = new DataTable();

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT * FROM DetainedLicenses_View";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dtDetainedLicenses.Load(reader);
                        }
                    }
                }
            }

            return dtDetainedLicenses;
        }
        public static StDetainLicense? GetDetainedLicenseByDetainID(int detainID)
        {
            StDetainLicense? detainedLicense = null;

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DetainID", detainID);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            detainedLicense = MapReaderToDetainLicense(reader);
                        }
                    }
                }
            }

            return detainedLicense;
        }
        public static StDetainLicense? GetDetainedLicenseByLicenseID(int licenseID)
        {
            StDetainLicense? detainedLicense = null;

            using (SqlConnection conn = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", licenseID);

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            detainedLicense = MapReaderToDetainLicense(reader);
                        }
                    }
                }
            }

            return detainedLicense;
        }
        private static StDetainLicense MapReaderToDetainLicense(SqlDataReader reader)
        {
            return new StDetainLicense
            {
                DetainID = reader.GetInt32(reader.GetOrdinal("DetainID")),
                LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID")),
                DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate")),
                FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees")),
                CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID")),
                IsReleased = reader.GetBoolean(reader.GetOrdinal("IsReleased")),
                ReleaseDate = reader.IsDBNull(reader.GetOrdinal("ReleaseDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ReleaseDate")),
                ReleasedByUserID = reader.IsDBNull(reader.GetOrdinal("ReleasedByUserID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleasedByUserID")),
                ReleaseApplicationID = reader.IsDBNull(reader.GetOrdinal("ReleaseApplicationID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleaseApplicationID"))
            };
        }
    }
}
