using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrate;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalDto> getRentalDetails();
    }
}
