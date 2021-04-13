using Business.Concrate;
using System;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        private static void CustomerTest()
        {
            //CustomerManager manager = new CustomerManager(new EfCustomerDal());

            //foreach (var item in manager.GetAll())
            //{
            //    Console.WriteLine(item.CompanyName);
            //}
        }

        private static void CarTest()
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            ////var result = carManager.GetCarDetails();
            //if (result.Success == true)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.CarName + "/" + item.BrandName + "/" + item.ColorName);
            //    }
            //}

            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
        }
    }
}
