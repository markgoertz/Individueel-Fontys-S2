using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    public interface IReservation
    {
        int Reservation_Number { get; set; }
         string AspNetUsers_ID { get; set; }
         int Car_ID { get; set; }
         DateTime StartDate { get; set; }
         DateTime EndDate { get; set; }
    }
}
