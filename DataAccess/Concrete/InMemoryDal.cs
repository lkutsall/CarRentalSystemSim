using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryDal()
        {
            _cars = new List<Car> {
                new Car{Id = 1, BrandId=1, ColorId = 3, ModelYear = new DateTime(2020), Description="Coupe, automatic gear, leadless fuel", DailyPrice = 200},
                new Car{Id = 2, BrandId=2, ColorId = 4, ModelYear = new DateTime(2019), Description="Roadster, manual gear, leadless fuel", DailyPrice = 450},
                new Car{Id = 3, BrandId=3, ColorId = 4, ModelYear = new DateTime(2021), Description="SUV, 4x4, manual gear, diesel", DailyPrice = 600},
                new Car{Id = 4, BrandId=3, ColorId = 3, ModelYear = new DateTime(2019), Description="Monster Truck, 4x4, manual gear, diesel", DailyPrice = 1200},
                new Car{Id = 5, BrandId=2, ColorId = 2, ModelYear = new DateTime(2020), Description="Safari Jeep, 4x4, manual gear, leadless fuel", DailyPrice = 1000},
                new Car{Id = 6, BrandId=1, ColorId = 1, ModelYear = new DateTime(2021), Description="Minibus, automatic gear, diesel", DailyPrice = 2000}
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

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = new Car();
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
