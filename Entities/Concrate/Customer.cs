using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrate
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }
}
