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
            //CarListTest();
            //BrandListTest();           
            //ColorListTest();
            //------------------------//
            //ColorCRUDTest();
            //BrandCRUDTest();
            //CarCRUDTest();


        }

        private static void ColorListTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetColor(5).ColorName);
        }

        private static void CarCRUDTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car6 = new Car
            {
                CarName = "Fiat Kartal",
                CarId = 1006,
                ColorId = 2,
                BrandId = 2,
                DailyPrice = 200,
                Description = "5 Seats and Manual",
                ModelYear = 1996
            };
            carManager.Insert(car6);
        }

        private static void BrandCRUDTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand6 = new Brand
            {
                BrandId = 1002,
                BrandName = "Volkswagen"
            };
            brandManager.Delete(brand6);
        }

        private static void ColorCRUDTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color6 = new Color
            {
                ColorId = 1002,
                ColorName = "Blue"
            };
            Color color7 = new Color
            {
                ColorId = 1003,
                ColorName = "Blue"
            };
            //colorManager.Insert(color7);
            colorManager.Update(color6);
        }

        private static void CarInsertDeleteUpdateTest(CarManager carManager)
        {
            
            Car car6 = new Car
            {
                CarName = "Fiat Kartal",
                CarId = 1006,
                ColorId = 2,
                BrandId = 2,
                DailyPrice = 200,
                Description = "5 Seats and Manual",
                ModelYear = 1996
            };
            //Insert yaparken CarId vermemeye dikkat et! Data kısmında oto. artan ayarladın.
            //carManager.Insert(car6);
            //carManager.Update(car6);
            //carManager.Delete(car6);
        }

        private static void BrandListTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarListTest()
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
