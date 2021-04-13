using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;


namespace Entities.Concrate
{
    public class Car : IEntity
    {

        //{
        //    //public Car()
        //    //{
        //    //    Images = new List<CarImage>();
        //}

        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string CarName { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Desciription { get; set; }
        //public List<CarImage> Images { get; set; }
    }
}
