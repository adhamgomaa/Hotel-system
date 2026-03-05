using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HMS_DataAccess
{
    public class clsUserData
    {
        public static bool FindUser(int userId, ref string username, ref string password)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_FindUserByUserId", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userId", userId);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                username = (string)reader["UserName"];
                                password = (string)reader["Password"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return isFound;
        }
        public static bool FindUser(ref int userId, string username, string password)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_FindUserByUsernameAndPass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                userId = (int)reader["UserID"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return isFound;
        }

        public static bool FindUser(string username)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_FindUserByUsername", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@username", username);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return isFound;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return dt;
        }

        public static int AddNewUser(string username, string password)
        {
            int UserId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddnewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        SqlParameter outputId = new SqlParameter("@userId", SqlDbType.Int);
                        outputId.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        UserId = (int)outputId.Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return UserId;
        }

        public static bool UpdateUser(int userId, string username, string password)
        {
            int rowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                    {
                        command.CommandType= CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@userId", userId);
                        connection.Open();
                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return rowAffected > 0;
        }

        public static bool DeleteUser(int userId)
        {
            int rowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userId", userId);
                        connection.Open();
                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return rowAffected > 0;
        }
    }
}
