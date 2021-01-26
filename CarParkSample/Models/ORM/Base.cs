using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.Models.ORM
{
    public class Base
    {
        
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
    }
}
