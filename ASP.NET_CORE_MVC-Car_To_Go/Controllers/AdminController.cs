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
    public class AdminController : Controller
    {
        private readonly ICarBLL _carBLL;
        public AdminController(ICarBLL carBLL)
        {
            _carBLL = carBLL;
        }

        [HttpGet]
        public ActionResult Create()
        {
            var carviewmodel = new CarViewModel();
            return View(carviewmodel);
        }

        [HttpPost]
        public ActionResult Create(CarViewModel car)
        {
            _carBLL.Createcar(car);
            return RedirectToAction("Index");

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

        [HttpGet]
        public ActionResult Update(int ID)
        {
            var carviewmodel = new CarViewModel()
            {
                ID = ID,
            };

            var car = _carBLL.GetByID(carviewmodel);

            var viewModel = new CarViewModel()
            {
                ID = car.ID,
                Seat = car.Seat,
                Acceleration = car.Acceleration,
                Brandname = car.Brandname,
                Cargospace = car.Cargospace,
                Enginepower = car.Enginepower,
                Fueltype = car.Fueltype,
                ImageLink = car.ImageLink,
                Modelname = car.Modelname,
                RentalPrice = car.RentalPrice,
                Transmission = car.Transmission,
                Weight = car.Weight

            };

            return View(viewModel);

        }

        [HttpPost]
        public ActionResult Update(CarViewModel car)
        {
            _carBLL.UpdateCar(car);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int ID)
        {
            _carBLL.DeleteCar(ID);
            return RedirectToAction("Index");
        }
    }
}
