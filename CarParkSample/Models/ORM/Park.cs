using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.Models.ORM
{
    public class Park : Base
    {
        public int ID { get; set; }
        [DisplayName("Park Adi")]
        public string Park_Adi{ get; set; }

        [DisplayName("Park Kapasitesi")]
        public string Park_Kapasitesi { get; set; }

        [DisplayName("Calisma Saatleri")]
        public string Calisma_Saatleri { get; set; }



    }
}
