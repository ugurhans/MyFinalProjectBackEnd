using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrate;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);

        IDataResult<List<Rental>> GetAllRentals();
        IDataResult<List<RentalDto>> GetRentalDetails();
    }
}
