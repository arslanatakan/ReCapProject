using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID 
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("Cars:\n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("  " + car.CarName);
            }
            Console.WriteLine();

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("  " + car.CarName);
            }
            Console.WriteLine();
            //CarInsertDeleteUpdateTest(carManager);



        }

        private static void CarInsertDeleteUpdateTest(CarManager carManager)
        {
            Car car6 = new Car
            {
                CarName = "Fiat Kartal",
                CarId = 9,
                ColorId = 2,
                BrandId = 2,
                DailyPrice = 200,
                Description = "Ideal for 2 people",
                ModelYear = 2006
            };
            //carManager.Insert(car6);
            carManager.Update(car6);
            
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " /" + car.BrandName + "/" 
                    + car.ColorName + " /" + car.DailyPrice);
            }
        }
    }
}
