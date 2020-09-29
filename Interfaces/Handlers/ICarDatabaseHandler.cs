using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Handlers
{
    public interface ICarDatabaseHandler
    {
        void Createcars(ICar C1);
        List<ICar> GetCars();
        ICar GetByIDcar(ICar ID);
        void UpdateCar(ICar U1);
        void DeleteCar(int ID);
    }
}
