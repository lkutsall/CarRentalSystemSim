using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;

        public CarManager(ICarDal carDal, IBrandDal brandDal)
        {
            _carDal = carDal;
            _brandDal = brandDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("The daily price should be greater then 0.");
            }
            else if (_brandDal.Get(b => b.Id == car.Id).BrandName.Length <= 2)
            {
                Console.WriteLine("Brand name should be longer then two letters.");
            }
            else
            {
                _carDal.Add(car);
                Console.WriteLine("Car added to database.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Brand deleted from database.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Brand updated.");
        }
    }
}
