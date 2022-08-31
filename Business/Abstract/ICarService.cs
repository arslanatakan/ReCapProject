using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        //-8.Hafta-Odev.1-Madde.6...
        void Insert(Car car);
        //------------------
        List<Car> GetCarsByBrandId(int BrandId);
        List<Car> GetCarsByColorId(int ColorId);
        List<CarDetailDto> GetCarDetails();
        void Delete(Car car);
        void Update(Car car);


    }
}
