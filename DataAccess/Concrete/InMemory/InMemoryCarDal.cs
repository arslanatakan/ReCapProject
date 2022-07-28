using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, BrandName="Opel Insignia", ColorId=1, ModelYear=2018, DailyPrice=300, Description="5 Seats - Manual - Sedan"},
                new Car{Id=2, BrandId=2, BrandName="Toyota Supra", ColorId=2, ModelYear=2022, DailyPrice=5000, Description="2 Seats - Automatic - Sport"},
                new Car{Id=3, BrandId=3, BrandName="Renault Megane", ColorId=3, ModelYear=2020, DailyPrice=400, Description="5 Seats - Manual - Station Wagon"},
                new Car{Id=4, BrandId=4, BrandName="Mercedes S400", ColorId=4, ModelYear=2021, DailyPrice=9000, Description="5 Seats - Automatic - Luxury"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandName = car.BrandName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
