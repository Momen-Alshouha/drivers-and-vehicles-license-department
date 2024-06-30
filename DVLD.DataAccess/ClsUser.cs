using System;
using System.Data;
using System.Data.SqlClient;
using static ClsDataType.ClsDataType;

namespace DVLD.DataAccess
{
    public class ClsUser
    {
        private static bool _GetUserInternal(string query, SqlParameter parameter, ref StUser user)
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

        private static bool _GetUserInternal(string query, SqlParameter param1, SqlParameter param2, ref StUser user)
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

        private static void _FillUserFromReader(SqlDataReader reader, ref StUser user)
        {
            user.UserID = (int)reader["UserID"];
            user.PersonID = (int)reader["PersonID"];
            user.UserName = (string)reader["UserName"];
            user.Password = reader["Password"] as string;

            var isActive = reader["IsActive"];
            if (isActive!=DBNull.Value)
            {
                user.IsActive= (bool)reader["IsActive"];
            } else
            {
                user.IsActive = false;
            }
        }

        public static bool GetUser(string UserName, string Password, ref StUser user)
        {
            return _GetUserInternal("select * from users where UserName = @UserName and Password = @Password",
                                   new SqlParameter("@UserName", UserName),
                                   new SqlParameter("@Password", Password),
                                   ref user);
        }

        public static bool GetUser(int UserID, ref StUser user)
        {
            return _GetUserInternal("select * from users where UserID = @UserID", new SqlParameter("@UserID", UserID), ref user);
        }

        public static bool GetUserByPersonID(int PersonID, ref StUser user)
        {
            return _GetUserInternal("select * from users where PersonID = @PersonID", new SqlParameter("@PersonID", PersonID), ref user);
        }

        public static bool AddNewUser(StUser user)
        {
            bool IsAdded = false;

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
                        IsAdded = true;
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while adding the new user.", ex);
                    }
                }
            }

            return IsAdded;
        }

        public static bool IsUserExist(int UserID)
        {
            StUser stUser = new StUser();
            return GetUser(UserID, ref stUser);
        }

        public static bool ChangePassword(int UserID,string NewPassword)
        {
            int RowEffected = 0;

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"update users set Password = @Password where UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Password", NewPassword);
                    try
                    {
                        connection.Open();
                        RowEffected = command.ExecuteNonQuery();

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

            return RowEffected > 0;
        }

        public static DataTable GetAllUsers()
        {
            DataTable usersTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"SELECT users.UserID,users.PersonID , 
                    FullName = people.FirstName + ' ' + people.SecondName + ' ' + people.ThirdName + ' ' + people.LastName , users.IsActive
                                FROM users inner join people 
                                on users.PersonID = people.PersonID
                                ";

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
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while retrieving all users.", ex);
                    }
                }
            }

            return usersTable;
        }

        public static bool UpdateUser(StUser user)
        {
            int RowsEffected=0; 
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
                        RowsEffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new DataAccessException("An error occurred while updating the user.", ex);
                    }
                }
            }
            return RowsEffected > 0;
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
