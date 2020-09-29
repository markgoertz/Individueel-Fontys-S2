using Data_access_layer.Entities;
using Interfaces.Entities;
using Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Data_access_layer.Handlers
{
    public class CarDatabaseHandler:ICarDatabaseHandler
    {


        private static string connectionString = "";

        public static void SetConnectionString(string constring)
        {
            connectionString = constring;
        }
        public List<ICar> GetCars()
        {
            var cars = new List<ICar>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [dbi434548].[dbo].[Car]";
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Car CarDTO = new Car
                        {
                            ID = reader.GetInt32(0),
                            Brandname = reader.GetString(1),
                            Modelname = reader.GetString(2),
                            Transmission = reader.GetString(3),
                            Enginepower = reader.GetInt32(4),
                            Weight = reader.GetInt32(5),
                            Acceleration = reader.GetDouble(6),
                            Cargospace = reader.GetInt32(7),
                            Seat = reader.GetInt32(8),
                            RentalPrice = reader.GetDouble(9),
                            Fueltype = reader.GetString(10),
                            ImageLink = reader.GetString(11)
                        };

                        cars.Add(CarDTO);
                    }
                }
            }
            return cars;
        }

        public void Createcars(ICar C1)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Car (Brandname, Modelname, Transmission, Enginepower, Weight, Acceleration, Cargospace, Seat, Rentalprice, Fueltype, ImageLink) VALUES (@Brandname, @Modelname, @Transmission, @Enginepower, @Weight, @Acceleration, @Cargospace, @Seat, @Rentalprice, @Fueltype, @ImageLink);";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", C1.ID);
                    command.Parameters.AddWithValue("@Brandname", C1.Brandname);
                    command.Parameters.AddWithValue("@Modelname", C1.Modelname);
                    command.Parameters.AddWithValue("@Transmission", C1.Transmission);
                    command.Parameters.AddWithValue("@Enginepower", C1.Enginepower);
                    command.Parameters.AddWithValue("@Weight", C1.Weight);
                    command.Parameters.AddWithValue("@Acceleration", C1.Acceleration);
                    command.Parameters.AddWithValue("@Cargospace", C1.Cargospace);
                    command.Parameters.AddWithValue("@Seat", C1.Seat);
                    command.Parameters.AddWithValue("@Rentalprice", C1.RentalPrice);
                    command.Parameters.AddWithValue("@Fueltype", C1.Fueltype);
                    command.Parameters.AddWithValue("@ImageLink", C1.ImageLink);

                    command.ExecuteNonQuery();
                }
            }
        }

        public ICar GetById(ICar _event)
        {
            ICar car = new Car();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Car WHERE ID = @ID; ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", _event.ID);

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        car.ID = reader.GetInt32(0);
                        car.Brandname = reader.GetString(1);
                        car.Modelname = reader.GetString(2);
                        car.Transmission = reader.GetString(3);
                        car.Enginepower = reader.GetInt32(4);
                        car.Weight = reader.GetInt32(5);
                        car.Acceleration = reader.GetDouble(6);
                        car.Cargospace = reader.GetInt32(7);
                        car.Seat = reader.GetInt32(8);
                        car.RentalPrice = reader.GetDouble(9);
                        car.Fueltype = reader.GetString(10);
                        car.ImageLink = reader.GetString(11);

                    }

                }
            }
            return car;
        }

        public void UpdateCar(ICar U1)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Car Set Brandname = @Brandname, Modelname = @Modelname, Transmission = @Transmission, Enginepower = @Enginepower, Weight = @Weight, Acceleration = @Acceleration, Cargospace = @Cargospace, Seat = @Seat, Rentalprice = @Rentalprice, Fueltype = @Fueltype, ImageLink = @ImageLink WHERE ID = @ID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", U1.ID);
                    command.Parameters.AddWithValue("@Brandname", U1.Brandname);
                    command.Parameters.AddWithValue("@Modelname", U1.Modelname);
                    command.Parameters.AddWithValue("@Transmission", U1.Transmission);
                    command.Parameters.AddWithValue("@Enginepower", U1.Enginepower);
                    command.Parameters.AddWithValue("@Weight", U1.Weight);
                    command.Parameters.AddWithValue("@Acceleration", U1.Acceleration);
                    command.Parameters.AddWithValue("@Cargospace", U1.Cargospace);
                    command.Parameters.AddWithValue("@Seat", U1.Seat);
                    command.Parameters.AddWithValue("@Rentalprice", U1.RentalPrice);
                    command.Parameters.AddWithValue("@Fueltype", U1.Fueltype);
                    command.Parameters.AddWithValue("@ImageLink", U1.ImageLink);

                    command.ExecuteNonQuery();
                }
            }
        }

        public ICar GetByIDcar (ICar ID)
        {
            ICar car = new Car();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM [dbi434548].[dbo].[Car] WHERE ID = @ID;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", ID.ID);

                    var reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        car.ID = reader.GetInt32(0);
                        car.Brandname = reader.GetString(1);
                        car.Modelname = reader.GetString(2);
                        car.Transmission = reader.GetString(3);
                        car.Enginepower = reader.GetInt32(4);
                        car.Weight = reader.GetInt32(5);
                        car.Acceleration = reader.GetDouble(6);
                        car.Cargospace = reader.GetInt32(7);
                        car.Seat = reader.GetInt32(8);
                        car.RentalPrice = reader.GetDouble(9);
                        car.Fueltype = reader.GetString(10);
                        car.ImageLink = reader.GetString(11);
                    }
                }

                return car;
            }
        }

        public void DeleteCar(int ID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Car WHERE ID=@ID";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

    }
}
        
