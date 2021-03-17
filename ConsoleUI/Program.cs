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
            CarManager carManager = new CarManager(new EfCarDal(), new EfBrandDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Brand brand = new Brand { BrandName = "VolksWagen" };
            brandManager.Add(brand);
            Car car = new Car { BrandId = brand.Id , ModelYear = new DateTime(2021), DailyPrice = 400, Description = "Coupe, automatic gear, leadless fuel" };
            carManager.Add(car);
        }
    }
}
