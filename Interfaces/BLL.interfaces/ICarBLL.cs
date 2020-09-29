using Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.BLL.interfaces
{
    public interface ICarBLL
    {
        List<ICar> GetCars();
        void Createcar(ICar car);
        ICar GetByID(ICar car);
        void DeleteCar(int ID);
        ICar UpdateCar(ICar car);

    }
}
