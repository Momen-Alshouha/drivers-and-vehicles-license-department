using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DataAccess
{
    public class ClsCountry
    {
        public static string GetCountryName(int CountryID)
        {
            string CountryName = null;

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        connection.Open();
                        CountryName = (string)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while retrieving the country name.", ex);
                    }
                }
            }

            return CountryName;
        }
        public static DataTable GetAllCountries()
        {
            DataTable CountriesTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT CountryName FROM Countries";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            CountriesTable.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while retrieving all countries.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return CountriesTable;
        }
        public int GetCountryId(string CountryName)
        {
            int CountryId = -1;

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT CountryID FROM Countries WHERE CountryName = @CountryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            CountryId = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while retrieving the country ID.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return CountryId;
        }
}
}
