using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.Models.ORM
{
    public class Lokasyon : Base


    {
        public int ID { get; set; }
        [DisplayName("Lokasyon Adi")]
        public string Lokasyon_Adi { get; set; }

        [DisplayName("Lokasyon Kodu")]
        public string Lokasyon_Kodu { get; set; }
    }
}
