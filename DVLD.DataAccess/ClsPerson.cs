using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClsDataType.ClsDataType;

namespace DVLD.DataAccess
{
    public class ClsPerson
    {
        public static DataTable GetAllPeople()
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
            SELECT 
                PersonID,
                NationalNo,
                FirstName,
                SecondName,
                ThirdName,
                LastName,
                BirthDate,
                CASE 
                    WHEN Gender = 0 THEN 'Male'
                    WHEN Gender = 1 THEN 'Female'
                    ELSE 'Unknown'
                END AS Gender,
                Address,
                Phone,
                Email,
                NationalityCountryId,
                ImagePath
            FROM 
                People";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            result.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while retrieving the people data.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return result;
        }
        public static int GetNumberOfPeople()
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "Select COUNT(PersonID) From People";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result!=null)
                        {
                            count = int.Parse(result.ToString());
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
            return count;
        }
        public static bool GetPerson(int id, ref StPerson person)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT * FROM People WHERE PersonID = @PersonId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonId", id);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                person.Id = id;
                                person.NationalNo = (string)reader["NationalNo"];
                                person.FirstName = (string)reader["FirstName"];
                                person.SecondName = (string)reader["SecondName"] as string ?? string.Empty;
                                person.ThirdName = (string)reader["ThirdName"];
                                person.LastName = (string)reader["LastName"];
                                person.BirthDate = (DateTime)reader["BirthDate"];
                                person.NationalityCountryId = (int)reader["NationalityCountryId"];
                                person.FullName= person.FirstName+" "+ person.SecondName+" "+ person.ThirdName+" "+person.LastName;
                                person.CountryName = ClsCountry.GetCountryName(person.NationalityCountryId);
                                
                                try
                                {
                                    var genderValue = reader["Gender"];
                                    if (genderValue != DBNull.Value)
                                    {
                                        person.Gender = (short)(byte)reader["Gender"]; 
                                    }
                                    else
                                    {
                                        person.Gender = 0; 
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error casting Gender: {ex.Message}");
                                    throw;
                                }

                                person.Address = reader["Address"] as string ?? string.Empty;
                                person.Phone = reader["Phone"] as string ?? string.Empty;
                                person.Email = reader["Email"] as string ?? string.Empty;
                                person.NationalityCountryId = reader["NationalityCountryId"] != DBNull.Value ? (int)reader["NationalityCountryId"] : 0;
                                person.ImagePath = reader["ImagePath"] as string ?? string.Empty;

                                isFound = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while retrieving the person data.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return isFound;
        }

        public static bool GetPerson(string NationalNo, ref StPerson person)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            person.Id = reader["PersonId"] != DBNull.Value ? (int)reader["PersonId"] : 0;
                            person.NationalNo = NationalNo;
                            person.FirstName = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : string.Empty;
                            person.SecondName = reader["SecondName"] != DBNull.Value ? (string)reader["SecondName"] : string.Empty;
                            person.ThirdName = reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : string.Empty;
                            person.LastName = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : string.Empty;
                            person.BirthDate = reader["BirthDate"] != DBNull.Value ? (DateTime)reader["BirthDate"] : DateTime.MinValue;
                            person.FullName = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                            person.NationalityCountryId = reader["NationalityCountryId"] != DBNull.Value ? (int)reader["NationalityCountryId"] : 0;
                            person.CountryName = ClsCountry.GetCountryName(person.NationalityCountryId);
                            try
                            {
                                var genderValue = reader["Gender"];
                                if (genderValue != DBNull.Value)
                                {
                                    person.Gender = (short)(byte)reader["Gender"];
                                }
                                else
                                {
                                    person.Gender = 0;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error casting Gender: {ex.Message}");
                                throw;
                            }

                            person.Address = reader["Address"] != DBNull.Value ? (string)reader["Address"] : string.Empty;
                            person.Phone = reader["Phone"] != DBNull.Value ? (string)reader["Phone"] : string.Empty;
                            person.Email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty;
                            person.ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;

                            isFound = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while retrieving the person data.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return isFound;
        }
        public static bool DeletePerson(int Id)
        {
            bool IsDeleted =false;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "Delete From People Where PersonId=@PersonId";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@PersonId", Id);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteNonQuery();
                        if (result!=null)
                        {
                            IsDeleted=true;
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
            return IsDeleted;
        }
        public static int AddNewPerson(StPerson person)
        {
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    INSERT INTO People (
                        NationalNo, FirstName, SecondName, ThirdName, LastName, 
                        BirthDate, Gender, Address, Phone, Email, 
                        NationalityCountryId, ImagePath
                    ) VALUES (
                        @NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, 
                        @BirthDate, @Gender, @Address, @Phone, @Email, 
                        @NationalityCountryId, @ImagePath
                    )
                    Select SCOPE_IDENTITY()";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
                    command.Parameters.AddWithValue("@FirstName", person.FirstName);
                    command.Parameters.AddWithValue("@SecondName", person.SecondName);
                    command.Parameters.AddWithValue("@ThirdName", person.ThirdName);
                    command.Parameters.AddWithValue("@LastName", person.LastName);
                    command.Parameters.AddWithValue("@BirthDate", person.BirthDate);
                    command.Parameters.AddWithValue("@Gender", person.Gender);
                    command.Parameters.AddWithValue("@Address", person.Address);
                    command.Parameters.AddWithValue("@Phone", person.Phone);
                    command.Parameters.AddWithValue("@Email", person.Email);
                    command.Parameters.AddWithValue("@NationalityCountryId", person.NationalityCountryId);
                    command.Parameters.AddWithValue("@ImagePath", person.ImagePath);

                    try
                    {
                        connection.Open();
                        object ID = command.ExecuteScalar();

                        if (ID!=null)
                        {
                            return int.Parse(ID.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while adding the new person.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return -1;
        }
        public static bool UpdatePerson(StPerson person)
        {
            bool IsUpdated = false;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = @"
                    UPDATE People SET
                        NationalNo = @NationalNo,
                        FirstName = @FirstName,
                        SecondName = @SecondName,
                        ThirdName = @ThirdName,
                        LastName = @LastName,
                        BirthDate = @BirthDate,
                        Gender = @Gender,
                        Address = @Address,
                        Phone = @Phone,
                        Email = @Email,
                        NationalityCountryId = @NationalityCountryId,
                        ImagePath = @ImagePath
                    WHERE PersonId = @PersonId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonId", person.Id);
                    command.Parameters.AddWithValue("@NationalNo", person.NationalNo);
                    command.Parameters.AddWithValue("@FirstName", person.FirstName);
                    command.Parameters.AddWithValue("@SecondName", person.SecondName);
                    command.Parameters.AddWithValue("@ThirdName", person.ThirdName);
                    command.Parameters.AddWithValue("@LastName", person.LastName);
                    command.Parameters.AddWithValue("@BirthDate", person.BirthDate);
                    command.Parameters.AddWithValue("@Gender", person.Gender);
                    command.Parameters.AddWithValue("@Address", person.Address);
                    command.Parameters.AddWithValue("@Phone", person.Phone);
                    command.Parameters.AddWithValue("@Email", person.Email);
                    command.Parameters.AddWithValue("@NationalityCountryId", person.NationalityCountryId);
                    command.Parameters.AddWithValue("@ImagePath", person.ImagePath);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected>0)
                        {
                            IsUpdated = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while updating the person.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return IsUpdated;
        }
        public static bool DeletePerson(string NationalNo)
        {
            bool IsDeleted = false;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "Delete From People Where NationalNo=@NationalNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    try
                    {
                        connection.Open();
                        object result = command.ExecuteNonQuery();
                        if (result != null)
                        {
                            IsDeleted = true;
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
            return IsDeleted;
        }
        public static bool IsPersonExist(string NationalNo)
        {
            bool IsExisit = false;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT COUNT(1) FROM People WHERE NationalNo = @NationalNo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count>0)
                        {
                            IsExisit = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while checking if the person exists.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return IsExisit;
        }
        public static bool IsPersonExist(int PersonId)
        {
            bool IsExisit = false;
            using (SqlConnection connection = new SqlConnection(Settings.ConnectionString))
            {
                string query = "SELECT COUNT(1) FROM People WHERE PersonId = @PersonId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonId", PersonId);
                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count>0)
                        {
                            IsExisit = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while checking if the person exists.", ex);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return IsExisit;
        }
    }
}
