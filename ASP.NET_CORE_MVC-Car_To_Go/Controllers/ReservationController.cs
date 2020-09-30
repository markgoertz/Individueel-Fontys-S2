using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ASP.NET_CORE_MVC_Car_To_Go.Models;
using Interfaces.BLL.interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_MVC_Car_To_Go.Controllers
{
    public class ReservationController : Controller
    {

        private readonly IReservationBLL reservationbll;
        public ReservationController(IReservationBLL reservation)
        {
            reservationbll = reservation;
        }


        [HttpGet]
        [Authorize]
        public ActionResult PlaceReservation(int id)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var registrationViewModel = new ReservationViewModel()
            {
                Car_ID = id,
                AspNetUsers_ID = claim.Value
          
            };

            return View(registrationViewModel);
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult PlaceReservation(ReservationViewModel reservation)
        {
            reservationbll.PlaceReservation(reservation);
            return RedirectToAction("Succes","Reservation");

        }

        public ActionResult Succes()
        {
            return View();
        }
    }

   

}
