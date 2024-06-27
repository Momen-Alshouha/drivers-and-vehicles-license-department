using System;
using System.Data;
using System.Data.SqlClient;
using ClsDataType;
using static ClsDataType.ClsDataType;

namespace DVLD.DataAccess
{
    public class ClsUser
    {

        private static bool _GetUserInternal(string query, SqlParameter parameter, ref ClsDataType.ClsDataType.StUser user)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(parameter);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                _FillUserFromReader(reader, ref user);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while retrieving the user.", ex);

                    }
                }
            }

            return isFound;
        }

        private static bool _GetUserInternal(string query, SqlParameter param1, SqlParameter param2, ref ClsDataType.ClsDataType.StUser user)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(param1);
                    command.Parameters.Add(param2);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                _FillUserFromReader(reader, ref user);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while retrieving the user.", ex);

                    }
                }
            }

            return isFound;
        }

        private static void _FillUserFromReader(SqlDataReader reader, ref ClsDataType.ClsDataType.StUser user)
        {
            user.UserID = (int)reader["UserID"];
            user.PersonID = (int)reader["PersonID"];
            user.UserName = (string)reader["UserName"];
            user.Password = reader["Password"] as string;

            var isActive = reader["IsActive"];
            user.IsActive = isActive != DBNull.Value ? (short)(byte)isActive : (short)0;
        }
        public static bool GetUser(string UserName, string Password, ref ClsDataType.ClsDataType.StUser user)
        {
            return _GetUserInternal("select * from users where UserName = @UserName and Password = @Password",
                                   new SqlParameter("@UserName", UserName),
                                   new SqlParameter("@Password", Password),
                                   ref user);
        }

        public static bool GetUser(int UserID, ref ClsDataType.ClsDataType.StUser user)
        {
            return _GetUserInternal("select * from users where UserID = @UserID", new SqlParameter("@UserID", UserID), ref user);
        }

        public static bool GetUserByPersonID(int PersonID, ref ClsDataType.ClsDataType.StUser user)
        {
            return _GetUserInternal("select * from users where PersonID = @PersonID", new SqlParameter("@PersonID", PersonID), ref user);
        }

        public static void AddNewUser(ClsDataType.ClsDataType.StUser user)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "INSERT INTO users (PersonID, UserName, Password, IsActive) VALUES (@PersonID, @UserName, @Password, @IsActive)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", user.PersonID);
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@IsActive", user.IsActive);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while adding the new user.", ex);
                    }
                }
            }
        }

        public bool IsUserExist(int UserID)
        {
            StUser stUser = new StUser();
            return GetUser(UserID, ref stUser);
        }

        public static DataTable GetAllUsers()
        {
            DataTable usersTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT * FROM users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                usersTable.Load(reader);
                            }
                            reader.Close();
                        }
                        connection.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while retrieving all users.", ex);
                    }
                }
            }

            return usersTable;
        }

        public static void UpdateUser(ClsDataType.ClsDataType.StUser user)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "UPDATE users SET PersonID = @PersonID, UserName = @UserName, Password = @Password, IsActive = @IsActive WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", user.PersonID);
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@IsActive", user.IsActive);
                    command.Parameters.AddWithValue("@UserID", user.UserID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while updating the user.", ex);
                    }
                }
            }
        }

        public static void DeleteUser(int UserID)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "DELETE FROM users WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while deleting the user.", ex);
                    }
                }
            }
        }


        public class DataAccessException : Exception
        {
            public DataAccessException(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        }

    }
}
