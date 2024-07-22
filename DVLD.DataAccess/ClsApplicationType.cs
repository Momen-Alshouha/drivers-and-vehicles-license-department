using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsApplication;
using static ClsDataType.ClsDataType;
namespace DVLD.DataAccess
{
    public class ClsApplicationType
    {
        public static StApplicationType GetAppType(int ApplicationTypeID)
        {
            StApplicationType applicationType = new StApplicationType();
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            applicationType.id = (int)reader["ApplicationTypeID"];
                            applicationType.title = reader["ApplicationTypeTitle"].ToString();
                            applicationType.fee = (decimal)reader["ApplicationFees"];
                            reader.Close();
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();

                    }
                }
            }
            return applicationType;
        }
        public static DataTable GetApplicationTypes()
        {
            DataTable appTypes = new DataTable();
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "select * from ApplicationTypes";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            appTypes.Load(reader);
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return appTypes;
        }
        public static bool UpdateApplicationType(StApplicationType appType)
        {
            int rowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    UPDATE ApplicationTypes SET
                        ApplicationTypeTitle = @AppTitle,
                        ApplicationFees = @AppFees
                    WHERE ApplicationTypeID = @AppID";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@AppID", appType.id);
                    command.Parameters.AddWithValue("@AppTitle", appType.title);
                    command.Parameters.AddWithValue("@AppFees", appType.fee);

                    try
                    {
                        connection.Open();
                        rowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return rowsEffected > 0;
        }
        public static bool AddNew(StApplicationType appType)
        {
            int rowsEffected = 0;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                INSERT INTO ApplicationTypes (ApplicationTypeTitle, ApplicationTypeFees)
                VALUES (@AppTitle, @AppFees)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AppTitle", appType.title);
                    command.Parameters.AddWithValue("@AppFees", appType.fee);

                    try
                    {
                        connection.Open();
                        rowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return rowsEffected > 0;
        }
        public static int GetApplicationTypeIDByApplicationID(int ApplicationID)
        {
            int ApplicationTypeID = 0;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT ApplicationTypeID FROM Applications WHERE ApplicationID = @ApplicationID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        ApplicationTypeID = Convert.ToInt32(result);
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
            return ApplicationTypeID;
        }

    }
}
