
﻿using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines_Logic_Layer__BLL_.Model_BLL
{
    public class CarModel: ICar
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

        public CarModel(int id, string brandname, string modelname, int enginepower, int weight, double acceleration, int cargospace, int seat, double rentalprice, string fueltype, string imagelink)
        {
            ID = id;
            Brandname = brandname;
            Modelname = modelname;
            Enginepower = enginepower;
            Weight = weight;
            Acceleration = acceleration;
            Cargospace = cargospace;
            Seat = seat;
            RentalPrice = rentalprice;
            Fueltype = fueltype;
            ImageLink = imagelink;
        }

        public void CarCheck(int power, int weight, double acceleration, int seat)
        {
            if (power <= 0)
            {
                throw new ArgumentException("The enginepower cannot be negative or zero!");
            }
            if (weight <= 0)
            {
                throw new ArgumentException("Cannot be negative!");
            }
            if (acceleration <= 0)
            {
                throw new ArgumentException("Cannot be negative!");
            }
            if (seat < 1)
            {
                throw new ArgumentException("There cannot be lesse then one seat in a car!");
            }
           
            Enginepower = power;
            Weight = weight;
            Acceleration = acceleration;
            Seat = seat;
        }

    }
}
