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
                    connection.Open();
                    string query = "Select * from Reservation Where ReservationID = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", ID);
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
            catch (Exception ex)
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
                    connection.Open();
                    string query = "Select * from Reservation_view order by ReservationID desc";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
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
                    connection.Open();
                    string query = "Insert into Reservation Values (@dateIn, @dateOut, @roomId, @clientId, @userId); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dateIn", dateIn);
                        command.Parameters.AddWithValue("@dateOut", dateOut);
                        command.Parameters.AddWithValue("@roomId", roomID);
                        command.Parameters.AddWithValue("@clientId", clientID);
                        command.Parameters.AddWithValue("@userId", createdByUserID);
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                            reservationId = insertedId;
                    }
                }
            }
            catch (Exception ex)
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
                    connection.Open();
                    string query = "Update Reservation Set DateIn = @dateIn, DateOut = @dateOut, RoomNo = @roomId, ClientID = @clientId, CreatedByUserID = @userId where ReservationID = @reservationId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@dateIn", dateIn);
                        command.Parameters.AddWithValue("@dateOut", dateOut);
                        command.Parameters.AddWithValue("@roomId", roomID);
                        command.Parameters.AddWithValue("@clientId", clientID);
                        command.Parameters.AddWithValue("@userId", createdByUserID);
                        command.Parameters.AddWithValue("@reservationId", reservationId);
                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
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
                    connection.Open();
                    string query = "Delete from Reservation Where ReservationID = @reservationId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@reservationId", reservationId);
                        rowAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clsLogger.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return rowAffected > 0;
        }
    }
}
