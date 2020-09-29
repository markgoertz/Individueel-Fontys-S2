using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.Entities;

namespace Data_access_layer.Entities
{
    public class Car : ICar
    {
        public int ID { get; set; }
        public string Brandname { get; set; }
        public string Modelname { get; set; }
        public string Transmission { get; set; }
        public int Enginepower { get; set; }
        public int Weight { get; set; }
        public double Acceleration { get; set; }
        public int Cargospace { get; set; }
        public int Seat { get; set; }
        public double RentalPrice { get; set; }
        public string Fueltype { get; set; }
        public string ImageLink { get; set; }

    }
}
