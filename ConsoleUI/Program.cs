using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAddTest();
            //GetCarByIdTest();
            //CarGetAllTest();
            //CarUpdateTest();
            //CarDeleteTest();
            //BrandAddTest();
            //BrandUpdateTest();
            //BrandDeleteTest();
            //ColorAddTest();
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Name);
            }
        }

        private static void BrandDeleteTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Delete(new Brand { Id = 1 });
        }

        private static void BrandUpdateTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Update(new Brand { Id = 1, BrandName = "Opel" });
        }

        private static void GetCarByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.GetById(1);
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 1 });
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { Id = 1, Name = "Polo", ModelYear = "2020", DailyPrice = 150, Description = "Cabrio, manual gear, diesel." });
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Color color1 = new Color
            {
                ColorName = "White"
            };
            colorManager.Add(color1);
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Brand brand1 = new Brand
            {
                BrandName = "VolksWagen"
            };
            brandManager.Add(brand1);
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car1 = new Car
            {
                Name = "Golf",
                ModelYear = "2017",
                DailyPrice = 200,
                Description = "Coupe, automatic gear, leadless fuel"
            };
            carManager.Add(car1);
        }
    }
}
