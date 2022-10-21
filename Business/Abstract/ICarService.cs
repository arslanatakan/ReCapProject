using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);    
        IResult Insert(Car car);
        IDataResult<List<Car>> GetCarsByBrandId(int BrandId);
        IDataResult<List<Car>> GetCarsByColorId(int ColorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Delete(Car car);
        IResult Update(Car car);


    }
}
