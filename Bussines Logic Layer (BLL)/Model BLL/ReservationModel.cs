using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines_Logic_Layer__BLL_.Model_BLL
{
    public class ReservationModel : IReservation
    {
        public int Reservation_Number { get; set; }
        public string AspNetUsers_ID { get; set; }
        public int Car_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
