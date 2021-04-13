using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrate;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
