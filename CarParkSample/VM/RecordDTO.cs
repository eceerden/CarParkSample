using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.VM
{
    public class RecordDTO
    {

        public int _id { get; set; }
        [JsonProperty("Park ID")]
        public int ParkID { get; set; }
        public string Adres { get; set; }
        [JsonProperty("Enlem/Boylam")]
        public string Enlem_Boylam { get; set; }

        [JsonProperty("Aylik Abonelik Ucreti")]
        public double? Aylik_Abonelik_Ucreti { get; set; }

        [JsonProperty("Ucretsiz Parklanma Suresi (dakika)")]
        public int Ucretsiz_Parklanma_Suresi_dakika { get; set; }
        [JsonProperty("Tarifesi")]
        public string Tarifesi { get; set; }

        [JsonProperty("Park Et Devam Et Noktasi")]
        public int Park_Et_Devam_Et_Noktasi { get; set; }

        public decimal? Boylam { get; set; }

        public decimal? Enlem { get; set; }
        public decimal? Polygon_Verisi { get; set; }

    }
}
