using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Castle.Components.DictionaryAdapter;
using Core.Entities;

namespace Entities.Concrate
{
    public class CarImage : IEntity
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ImageId { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime ImageDate { get; set; }
    }
}
