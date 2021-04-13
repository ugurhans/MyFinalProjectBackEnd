using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {

            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                                 on c.BrandID equals b.BrandID
                             join co in context.Colors
                                 on c.ColorId equals co.ColorId
                             //join ci in context.CarImages
                             //on c.Id equals ci.CarId
                             select new CarDetailDto
                             {
                                 CarID = c.CarID,
                                 CarDescription = c.Desciription,
                                 BrandName = b.BrandName,
                                 BrandID = b.BrandID,
                                 ColorID = co.ColorId,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 ImagePath = (from a in context.CarImages where a.CarId == c.CarID select a.ImagePath).FirstOrDefault()

                             };



                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        //public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter)
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var result = from c in context.Cars
        //                     join b in context.Brands
        //                     on c.BrandID equals b.BrandID
        //                     join co in context.Colors
        //                     on c.ColorId equals co.ColorId
        //                     join im in context.CarImages
        //                     on c.CarID equals im.CarId
        //                     select new CarDetailDto
        //                     {
        //                         CarID = c.CarID,
        //                         BrandID = b.BrandID,
        //                         ColorID = co.ColorId,
        //                         CarName = c.CarName,
        //                         BrandName = b.BrandName,
        //                         ColorName = co.ColorName,
        //                         DailyPrice = c.DailyPrice,
        //                         ModelYear = c.ModelYear,
        //                         ImagePath = im.ImagePath
        //                     };
        //        return result.Where(filter).ToList();
        //    }
        //}



    }
}
