using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.Models.ORM
{
    public class ParkTipi : Base
    {
        public int ID { get; set; }
        [DisplayName("Park Tipi")]
        public string Park_Tipi { get; set; }

        [DisplayName("Park Kapasitesi")]
        public string Park_Kapasitesi { get; set; }
    }
}
