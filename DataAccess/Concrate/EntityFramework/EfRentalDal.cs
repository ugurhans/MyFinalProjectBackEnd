using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDto> getRentalDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from rt in context.Rentals
                             join c in context.Cars
                                 on rt.CarID equals c.CarID
                             join b in context.Brands
                                 on c.BrandID equals b.BrandID
                             join cus in context.Customers
                                 on rt.CustomerID equals cus.CustomerId
                             join us in context.Users
                                 on cus.UserID equals us.Id

                             select new RentalDto
                             {
                                 CarID = c.CarID,
                                 CarName = c.CarName,
                                 CarBrand = b.BrandName,
                                 CustomerFirstName = us.FirstName,
                                 CustomerLastName = us.LastName,
                                 CustomerCompanyName = cus.CompanyName,
                                 CustomerEmail = us.Email,
                                 RentDate = rt.RentDate,
                                 ReturnDate = rt.ReturnDate
                             };
                return result.ToList();



            }
        }
    }
}
