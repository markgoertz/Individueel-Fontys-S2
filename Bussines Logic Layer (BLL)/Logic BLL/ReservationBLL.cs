using Interfaces.BLL.interfaces;
using Interfaces.Entities;
using Interfaces.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussines_Logic_Layer__BLL_.Logic_BLL
{
    public class ReservationBLL:IReservationBLL
    {
        private readonly IReservationHandler _reservationHandler;
        public ReservationBLL(IReservationHandler reservationHandler)
        {
            _reservationHandler = reservationHandler;
        }   

        public void PlaceReservation(IReservation reservation)
        {
            _reservationHandler.PlaceReservation(reservation);
        }
    }
}
