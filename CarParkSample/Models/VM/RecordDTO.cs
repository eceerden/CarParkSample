using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.Models.VM
{
    public class RecordDTO
    {

        public int _id { get; set; }
        [JsonProperty("Park ID")]
        public int ParkID { get; set; }
        [JsonProperty("Park Adi")]
        public string ParkAdi { get; set; }
        [JsonProperty("Lokasyon ID")]
        public int LokasyonID { get; set; }
        [JsonProperty("Lokasyon Kodu")]
        public int LokasyonKodu { get; set; }
        [JsonProperty("Lokasyon Adi")]
        public string LokasyonAdi { get; set; }

        [JsonProperty("Park Tipi ID")]
        public int ParkTipiID { get; set; }
        [JsonProperty("Park Tipi")]
        public string ParkTipi { get; set; }

        [JsonProperty("Park Kapasitesi")]
        public string ParkKapasitesi { get; set; }

        [JsonProperty("Calisma Saatleri")]
        public string CalismaSaatleri { get; set; }
        [JsonProperty("Bolge ID")]
        public int BolgeID { get; set; }

        public string Bolge { get; set; }

        [JsonProperty("Alt Bolge ID")]
        public int AltBolgeID { get; set; }

        [JsonProperty("Alt Bolge")]
        public string AltBolge { get; set; }
        [JsonProperty("Ilce ID")]
        public int IlceID { get; set; }
        public string Ilce { get; set; }
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

        [JsonProperty("Polygon Verisi")]
        public string Polygon_Verisi { get; set; }
        public List<AltBolgeDTO> AltBolgeDTOs { get; set; }
        public List<BolgeDTO> BolgeDTOs { get; set; }
        public List<IlceDTO> IlceDTOs { get; set; }
        public List<ParkTipiDTO> ParkTipiDTOs { get; set; }

    }
}