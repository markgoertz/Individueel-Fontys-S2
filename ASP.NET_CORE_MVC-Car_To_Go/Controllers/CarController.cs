using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_CORE_MVC_Car_To_Go.Models;
using Car_To_Go.Models;
using Interfaces.BLL.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_CORE_MVC_Car_To_Go.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarBLL _carBLL;
        public CarController(ICarBLL carBLL)
        {
            _carBLL = carBLL;
        }
        public ActionResult Index()
        {
            var allcars = _carBLL.GetCars();
            var cars = new List<CarViewModel>();

            foreach (var car in allcars)
            {
                cars.Add(new CarViewModel
                {
                    ID = car.ID,
                    Seat = car.Seat,
                    Enginepower = car.Enginepower,
                    Acceleration = car.Acceleration,
                    Brandname = car.Brandname,
                    Cargospace = car.Cargospace,
                    Modelname = car.Modelname,
                    RentalPrice = car.RentalPrice,
                    Transmission = car.Transmission,
                    Weight = car.Weight,
                    Fueltype = car.Fueltype,
                    ImageLink = car.ImageLink


                });
            }
            return View(cars);
        }

        public ViewResult Details(int ID)
        {
            var carviewmodel = new CarViewModel()
            {
                ID = ID,
            };
            var cardetails = _carBLL.GetByID(carviewmodel);
            var viewmodel = new CarViewModel()
            {
                ID = cardetails.ID,
                Brandname = cardetails.Brandname,
                Modelname = cardetails.Modelname,
                Acceleration = cardetails.Acceleration,
                Enginepower = cardetails.Enginepower,
                Cargospace = cardetails.Cargospace,
                Fueltype = cardetails.Fueltype,
                RentalPrice = cardetails.RentalPrice,
                Seat = cardetails.Seat,
                Transmission = cardetails.Transmission,
                Weight = cardetails.Weight,
                ImageLink = cardetails.ImageLink
            };


            return View(viewmodel);
        }


    }
}