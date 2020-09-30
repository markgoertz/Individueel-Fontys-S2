using Interfaces.Entities;
using Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data_access_layer.Handlers
{
    public class ReservationHandler:IReservationHandler
    {
        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }

        public void PlaceReservation(IReservation PR1)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Reservation (ASPNetUsers_ID, Car_ID, StartDate, EndDate) VALUES (@ASPNetUsers_ID, @Car_ID, @StartDate, @EndDate); ";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Reservation_Number", PR1.Reservation_Number);
                    command.Parameters.AddWithValue("@AspNetUsers_ID", PR1.AspNetUsers_ID);
                    command.Parameters.AddWithValue("@Car_ID", PR1.Car_ID);
                    command.Parameters.AddWithValue("@StartDate", PR1.StartDate);
                    command.Parameters.AddWithValue("@EndDate", PR1.EndDate);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
