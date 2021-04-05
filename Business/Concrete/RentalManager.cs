using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate != null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentationSuccessMessage);
            }
            else
            {
                return new ErrorResult(Messages.RentationFailedMessage);
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.DeleteSuccessMessage);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetByCarId(int carId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CarId == carId));
        }

        public IDataResult<Rental> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.CustomerId == customerId));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdateSuccessMessage);
        }
    }
}
