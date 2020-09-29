using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    public interface ICar
    {
         int ID { get; set; }
         string Brandname { get; set; }
         string Modelname { get; set; }
         string Transmission { get; set; }
         int Enginepower { get; set; }
         int Weight { get; set; }
         double Acceleration { get; set; }
         int Cargospace { get; set; }
         int Seat { get; set; }
         double RentalPrice { get; set; }
         string Fueltype { get; set; }
         string ImageLink { get; set; }

    }
}
