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
            //CarTest();
            //BrandTest();
            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { ColorName = "WHITE" });
            //colorManager.Add(new Color { ColorName = "RED" });
            //colorManager.Add(new Color { ColorName = "BLACK" });
            //colorManager.Add(new Color { ColorName = "YELLOW" });

            Console.WriteLine("GET ALL COLORS");

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Add(new Brand { BrandName = "BMW" });
            //brandManager.Add(new Brand { BrandName = "Citroen" });
            //brandManager.Add(new Brand { BrandName = "Mercedes-Benz" });
            //brandManager.Add(new Brand { BrandName = "FIAT" });
            //brandManager.Add(new Brand { BrandName = "Renault" });

            Console.WriteLine("GET ALL BRANDS");

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine("GET BRAND BY ID \n");

            Console.WriteLine(brandManager.GetById(3).Data);

            //Console.WriteLine("UPDATE BRAND");

            //var brandToUpdate = brandManager.GetById(3);
            //brandToUpdate.BrandName = "Ferrari";
            //brandManager.Update(brandToUpdate);

            //Console.WriteLine("DELETE BRAND");

            //var brandToDelete = brandManager.GetById(3);
            //brandManager.Delete(brandToDelete);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { Name = "3.20", BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 600, Description = "Coupe, automatic gear, leadless fuel" });
            //carManager.Add(new Car { Name = "C-Elysee", BrandId = 2, ColorId = 1, ModelYear = "2020", DailyPrice = 250, Description = "Sedan, manual gear, diesel" });
            //carManager.Add(new Car { Name = "E200", BrandId = 3, ColorId = 2, ModelYear = "2019", DailyPrice = 400, Description = "Sedan, 4-matic, leadless fuel" });
            //carManager.Add(new Car { Name = "5.20", BrandId = 1, ColorId = 3, ModelYear = "2010", DailyPrice = 350, Description = "Cabrio, automatic gear, diesel" });
            //carManager.Add(new Car { Name = "Megane", BrandId = 5, ColorId = 4, ModelYear = "2018", DailyPrice = 200, Description = "Sedan, manual gear, leadless fuel" });
            //carManager.Add(new Car { Name = "Aegea", BrandId = 4, ColorId = 2, ModelYear = "2020", DailyPrice = 200, Description = "Hatchback, automatic gear, diesel" });
            //carManager.Add(new Car { Name = "Cactus", BrandId = 2, ColorId = 3, ModelYear = "2021", DailyPrice = 600, Description = "SUV, automatic gear, diesel" });
            //carManager.Add(new Car { Name = "Vito", BrandId = 3, ColorId = 4, ModelYear = "2018", DailyPrice = 700, Description = "Minivan, automatic gear, leadless fuel" });

            Console.WriteLine("CAR DETAILS \n");

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Brand = {0} ,Model = {1}, Color = {2}, Daily Price = {3}", car.BrandName, car.CarName, car.Color, car.DailyPrice);
            }

            Console.WriteLine("GET BY ID \n");

            foreach (var car in carManager.GetCarsByBrandId(3).Data)
            {
                Console.WriteLine("{0} {1} {2} {3}", car.Id, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("GET BY COLOR ID \n");

            foreach (var car in carManager.GetCarsByColorId(2).Data)
            {
                Console.WriteLine("{0} {1} {2} {3}", car.Id, car.ModelYear, car.DailyPrice, car.Description);
            }

            //Console.WriteLine("UPDATE ON ... \n");

            //var carToUpdate = carManager.GetById(1006);
            //carToUpdate.ModelYear = "2021";
            //carManager.Update(carToUpdate);

            //Console.WriteLine("DELETE CAR \n");

            //var carToDelete = carManager.GetById(1006);
            //carManager.Delete(carToDelete);
        }
    }
}
