using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_DataAccess
{
    public class clsReservationData
    {
        public static bool FindReservation(int ID, ref DateTime dateIn, ref DateTime dateOut, ref int roomID, ref int clientID,
            ref int createdByUserID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_FindReservation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@reservationId", ID);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                dateIn = (DateTime)reader["DateIn"];
                                dateOut = (DateTime)reader["DateOut"];
                                roomID = (int)reader["RoomNo"];
                                clientID = (int)reader["ClientID"];
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

        public static DataTable GetAllReservations()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllReservations", connection))
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

        public static int AddNewReservation(DateTime dateIn, DateTime dateOut, int roomID, int clientID, int createdByUserID)
        {
            int reservationId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddReservation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@dateIn", dateIn);
                        command.Parameters.AddWithValue("@dateOut", dateOut);
                        command.Parameters.AddWithValue("@roomId", roomID);
                        command.Parameters.AddWithValue("@clientId", clientID);
                        command.Parameters.AddWithValue("@userId", createdByUserID);
                        SqlParameter outputId = new SqlParameter("@reservationId", SqlDbType.Int);
                        outputId.Direction = ParameterDirection.Output;
                        command.Parameters.Add(outputId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        reservationId = (int)outputId.Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return reservationId;
        }

        public static bool UpdateReservation(int reservationId, DateTime dateIn, DateTime dateOut, int roomID, int clientID, int createdByUserID)
        {
            int rowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateReservtion", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@dateIn", dateIn);
                        command.Parameters.AddWithValue("@dateOut", dateOut);
                        command.Parameters.AddWithValue("@roomId", roomID);
                        command.Parameters.AddWithValue("@clientId", clientID);
                        command.Parameters.AddWithValue("@userId", createdByUserID);
                        command.Parameters.AddWithValue("@reservationId", reservationId);
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

        public static bool DeleteReservation(int reservationId)
        {
            int rowAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteReservation", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@reservationId", reservationId);
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
