using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrate;
using Core.Utilities.Results;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface IUserService
    {

        List<OperationClaim> GetClaims(User user);
        IResult Add(User user);
        User GetByMail(string email);

    }
}
