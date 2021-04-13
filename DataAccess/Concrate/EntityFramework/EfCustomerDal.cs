using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerInfoDto> GetCustumerInfo()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from cstm in context.Customers
                             join us in context.Users
                                 on cstm.UserID equals us.Id

                             select new CustomerInfoDto
                             {
                                 CustomerId = cstm.CustomerId,
                                 CustomerName = us.FirstName,
                                 CustomerLastName = us.LastName,
                                 CustomerEmail = us.Email

                             };
                return result.ToList();
            }
        }
    }
}
