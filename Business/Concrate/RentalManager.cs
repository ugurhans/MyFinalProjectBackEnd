using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;

namespace Business.Concrate
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rentAl)
        {
            IResult result = BusinessRules.Run(CheckDataIsNull(rentAl.ReturnDate));

            if (result != null)
            {
                return result;
            }
            _rentalDal.Add(rentAl);
            return new SuccessResult(Messages.RentalAdded);

        }

        private IResult CheckDataIsNull(DateTime? returnDate)
        {
            if (returnDate == null)
            {
                return new ErrorResult(Messages.RentalNotAvaible);
            }
            else
            {
                return new SuccessResult(Messages.RentalAdded);
            }
        }

        public IDataResult<List<RentalDto>> GetRentalDto()
        {
            return new SuccessDataResult<List<RentalDto>>(_rentalDal.getRentalDetails(), Messages.RentalListed);
        }


        public IDataResult<List<Rental>> GetAllRentals()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<RentalDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDto>>(_rentalDal.getRentalDetails(), Messages.RentalListed);
        }

    }
}
