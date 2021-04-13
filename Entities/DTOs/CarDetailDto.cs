using Core;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public string CarDescription { get; set; }
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string CarName { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public int ColorID { get; set; }
        public string ImagePath { get; set; }
    }
}
