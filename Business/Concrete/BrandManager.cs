using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length <= 2)
            {
                Console.WriteLine("Brand name muct be longer then two letters.");
            }
            else
            {
                _brandDal.Add(brand);
                Console.WriteLine("Brand added to database.");
            }
        }

        public void Delete(Brand brand)
        {
            Console.WriteLine("Brand deleted from database.");
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetBrandByCarId(int id)
        {
            return _brandDal.GetAll(b=>b.Id == id);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine("Brand updated.");
        }
    }
}
