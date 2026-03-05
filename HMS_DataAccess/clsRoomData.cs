using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class clsRoomData
    {
        public static bool FindRoom(int roomId, ref string roomType, ref string phone, ref bool isFree, ref int createdByUserID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_FindRoomByRoomId", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@roomId", roomId);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                roomType = (string)reader["Type"];
                                phone = (string)reader["Phone"];
                                isFree = (bool)reader["IsFree"];
                                createdByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                isFound = false;
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return isFound;
        }

        public static DataTable FindRoom(string roomType)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_FindRoomByType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@type", roomType);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
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

        public static DataTable GetAllRooms()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllRooms", connection))
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

        public static int AddNewRoom(string roomType, string phone, bool isFree, int createdByUserID)
        {
            int roomId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddRoom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@type", roomType);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@isFree", isFree);
                        command.Parameters.AddWithValue("@userId", createdByUserID);
                        SqlParameter outputId = new SqlParameter("@roomId", SqlDbType.Int);
                        outputId.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        roomId = (int)outputId.Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return roomId;
        }

        public static bool UpdateRoom(int roomId, string roomType, string phone, bool isFree, int createdByUserID)
        {
            int rowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateRoom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@type", roomType);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@isFree", isFree);
                        command.Parameters.AddWithValue("@userId", createdByUserID);
                        command.Parameters.AddWithValue("@roomId", roomId);
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

        public static bool DeleteRoom(int roomId)
        {
            int rowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteRoom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@roomId", roomId);
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
