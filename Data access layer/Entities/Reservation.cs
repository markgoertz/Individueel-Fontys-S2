using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_access_layer.Entities
{
    public class Reservation:IReservation
    {
        public int Reservation_Number { get; set; }
        public string AspNetUsers_ID { get; set; }
        public int Car_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
