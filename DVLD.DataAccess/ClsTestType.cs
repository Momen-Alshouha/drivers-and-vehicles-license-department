﻿using System;
using System.Data;
using System.Data.SqlClient;
using static ClsDataType.ClsDataType;

namespace DVLD.DataAccess
{
    public class ClsTestType
    {
        private readonly string connectionString;
        public ClsTestType()
        {
            this.connectionString = Settings.ConnectionString;
        }
        public DataTable GetTestTypes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TestTypes";
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dt.Load(reader);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {

                    connection.Close();
                }
            }

            return dt;
        }
        public bool UpdateTestType(StTestType testType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE TestTypes SET TestTypeTitle = @title, TestTypeDescription = @description, TestTypeFees = @fee WHERE TestTypeID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", testType.title);
                cmd.Parameters.AddWithValue("@description", testType.description);
                cmd.Parameters.AddWithValue("@fee", testType.fee);
                cmd.Parameters.AddWithValue("@id", testType.id);

                try
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                   throw ex;
                }
                finally
                {
                 conn.Close();
                }
            }
        }
        public StTestType GetTestType(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM TestTypes WHERE TestTypeID = @id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                StTestType testType = new StTestType();

                if (reader.Read())
                {
                    testType.id = (int)reader["TestTypeID"];
                    testType.title = reader["TestTypeTitle"].ToString();
                    testType.description = reader["TestTypeDescription"].ToString();
                    testType.fee = (decimal)reader["TestTypeFees"];
                }

                return testType;
            }
        }
        public bool AddTestType(StTestType testType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TestTypes (TestTypeTitle, TestTypeDescription, TestTypeFees) VALUES (@title, @description, @fee)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", testType.title);
                cmd.Parameters.AddWithValue("@description", testType.description);
                cmd.Parameters.AddWithValue("@fee", testType.fee);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
