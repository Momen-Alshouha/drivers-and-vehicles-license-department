using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using static ClsDataType.ClsDataType;

namespace DVLD.DataAccess
{
    public class ClsUser
    {
        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

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
        private static bool _GetUserInternal(string query, SqlParameter param1, ref StUser user, string inputPassword)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(param1);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _FillUserFromReader(reader, ref user);

                                string storedHashedPassword = reader["Password"].ToString();
                                string hashedInputPassword = HashPassword(inputPassword);

                                if (hashedInputPassword == storedHashedPassword)
                                {
                                    isFound = true;  // Password matches
                                }
                                else
                                {
                                    isFound = false;  // Password does not match
                                }
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
            return _GetUserInternal("SELECT * FROM users WHERE UserName = @UserName",
                                    new SqlParameter("@UserName", UserName),
                                    ref user,
                                    Password);  
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

        public static bool ChangePassword(int userID, string oldPassword, string newPassword)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string retrieveQuery = "SELECT Password FROM users WHERE UserID = @UserID";
                using (SqlCommand retrieveCommand = new SqlCommand(retrieveQuery, connection))
                {
                    retrieveCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;

                    try
                    {
                        connection.Open();
                        string currentPassword = (string)retrieveCommand.ExecuteScalar();

                        if (currentPassword == null)
                        {
                            throw new ApplicationException("User not found.");
                        }

                        if (currentPassword != oldPassword)
                        {
                            throw new ApplicationException("The old password is incorrect.");
                        }

                        string updateQuery = "UPDATE users SET Password = @Password WHERE UserID = @UserID";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = userID;
                            updateCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = newPassword;

                            rowsAffected = updateCommand.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException ex)
                    {
                        throw new ApplicationException("An error occurred while updating the password.", ex);
                    }
                    catch (Exception ex)
                    {
                        throw new ApplicationException("An unexpected error occurred.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return rowsAffected > 0;
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
