using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Spatial;
using System.Threading.Tasks;

namespace CarParkSample.Models.ORM
{
    public class Record : Base
    {
        public int _id { get; set; }
        public int ParkID { get; set; }
        public string Adres { get; set; }
        public string Enlem_Boylam { get; set; }

        public decimal? Boylam { get; set; }

        public decimal? Enlem { get; set; }
        public decimal? Polygon_Verisi { get; set; }

        public double? Aylik_Abonelik_Ucreti { get; set; }
        public int Ucretsiz_Parklanma_Suresi_dakika { get; set; }
        public string Tarifesi { get; set; }
        public int Park_Et_Devam_Et_Noktasi { get; set; }

    }

 
}
