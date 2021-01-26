using CarParkSample.Models.ORM;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using CarParkSample.Models.ORM.Context;
using System.Net;
using Microsoft.AspNetCore.Cors;
using CarParkSample.Models.VM;

namespace CarParkSample.Controllers
{
    public class HomeController : Controller
    {
        //static string data = System.IO.File.ReadAllText(@"C:\Users\Ece\source\repos\CarParkSample\CarParkSample\wwwroot\datastore_search.json");

        //static List<Record> records = JsonConvert.DeserializeObject<List<Record>>(data);

        private readonly CarParkContext _parkcontext;
        public HomeController(CarParkContext parkcontext)
        {
            _parkcontext = parkcontext;
        }
      
        //[EnableCors("ApiCorsPolicy")]
        public IActionResult Index()
        {

            return View();
        }

        // DataBase Verilerini JSON olarak gösteren route
        public JsonResult RecordsDB()
        {
            List<Record> records = _parkcontext.Records.ToList();

            return Json(records);
        }
        // Veri API den database imize aktarmak için kullandığımız Route (front tarafı çalışmadığı için) Bir kere kullanımlık 
        public IActionResult Veriler()
        {
            string data = new WebClient().DownloadString("https://data.ibb.gov.tr/en/datastore/odata3.0/c3eb0d72-1ce4-4983-a3a8-6b0b4b19fcb9?&$format=json");
            
            var list  = JsonConvert.DeserializeObject<RecordListDTO>(data);

            //List<Record> record = new List<Record>();


            foreach (var item in list.recordlist)
            {
                var recordControl = _parkcontext.Records.FirstOrDefault(x => x.ID == item._id );
                if (recordControl == null)
                {
                    Record record = new Record();
                    record.ID = item._id;
                    record.ParkID = item.ParkID;
                    record.ParkAdi = item.ParkAdi;
                    record.LokasyonAdi = item.LokasyonAdi;
                    record.LokasyonID = item.LokasyonID;
                    record.LokasyonKodu = item.LokasyonKodu;
                    record.ParkTipiID = item.ParkTipiID;
                    record.ParkTipi = item.ParkTipi;
                    record.ParkKapasitesi = item.ParkKapasitesi;
                    record.CalismaSaatleri = item.CalismaSaatleri;
                    record.BolgeID = item.BolgeID;
                    record.Bolge = item.Bolge;
                    record.AltBolgeID = item.AltBolgeID;
                    record.AltBolge = item.AltBolge;
                    record.IlceID = item.IlceID;
                    record.Ilce = item.Ilce;
                    record.Adres = item.Adres;
                    record.Enlem_Boylam = item.Enlem_Boylam;
                    record.Polygon_Verisi = item.Polygon_Verisi;
                    record.Boylam = item.Boylam;
                    record.Enlem = item.Enlem;                                
                    record.Aylik_Abonelik_Ucreti=item.Aylik_Abonelik_Ucreti;
                    record.Ucretsiz_Parklanma_Suresi_dakika = item.Ucretsiz_Parklanma_Suresi_dakika;
                    record.Tarifesi = item.Tarifesi;
                    record.Park_Et_Devam_Et_Noktasi = item.Park_Et_Devam_Et_Noktasi;
                       record.IsDeleted = false;
                                    
                    _parkcontext.Records.Add(record);
                    _parkcontext.SaveChanges();

                }

            }               
            return Json(list);
        }
       
        // Harita ve üzerinde Konumlar
        public IActionResult Harita_Veriler()
        {
            return View();
        }
        
        // Harita ve üzerinde otopark işaretleri ve pop-up
        public IActionResult Mevcut()
        {
           

            return View();
        }

        public IActionResult RecordList()
        {


            List<RecordDTO> records = _parkcontext.Records.Select(x => new RecordDTO()
            {
                _id = x.ID,
                ParkID = x.ParkID,
                ParkAdi = x.ParkAdi,
                LokasyonAdi = x.LokasyonAdi,
                LokasyonID = x.LokasyonID,
                LokasyonKodu = x.LokasyonKodu,
                ParkTipiID = x.ParkTipiID,
                ParkTipi = x.ParkTipi,
                ParkKapasitesi = x.ParkKapasitesi,
                CalismaSaatleri = x.CalismaSaatleri,
                BolgeID = x.BolgeID,
                Bolge = x.Bolge,
                AltBolgeID = x.AltBolgeID,
                AltBolge = x.AltBolge,
                IlceID = x.IlceID,
                Ilce = x.Ilce,
                Adres = x.Adres,
                Enlem_Boylam = x.Enlem_Boylam,
                Polygon_Verisi = x.Polygon_Verisi,
                Boylam = x.Boylam,
                Enlem = x.Enlem,
                Aylik_Abonelik_Ucreti = x.Aylik_Abonelik_Ucreti,
                Ucretsiz_Parklanma_Suresi_dakika = x.Ucretsiz_Parklanma_Suresi_dakika,
                Tarifesi = x.Tarifesi,
                Park_Et_Devam_Et_Noktasi = x.Park_Et_Devam_Et_Noktasi

            }).ToList();
            return View(records);

                       
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Record record = _parkcontext.Records.FirstOrDefault(x => x.ID == id);

            _parkcontext.Records.Remove(record);

            _parkcontext.SaveChanges();

           return Redirect("/Home/RecordList");
        }

   

        public IActionResult Edit(int id)
        {
            Record record = _parkcontext.Records.FirstOrDefault(x => x.ID == id);

            RecordDTO model = new RecordDTO();
            model._id = record.ID;
            model.ParkID = record.ParkID;
            model.ParkAdi = record.ParkAdi;
            model.LokasyonAdi = record.LokasyonAdi;
            model.LokasyonKodu = record.LokasyonKodu;
            model.ParkTipi = record.ParkTipi;
            model.ParkKapasitesi = record.ParkKapasitesi;
            model.CalismaSaatleri = record.CalismaSaatleri;
            model.Bolge = record.Bolge;
            model.AltBolge = record.AltBolge;
            model.Ilce = record.Ilce;
            model.Adres = record.Adres;
            model.Enlem_Boylam = record.Enlem_Boylam;
            model.Polygon_Verisi = record.Polygon_Verisi;
            model.Boylam = record.Boylam;
            model.Enlem = record.Enlem;
            model.Aylik_Abonelik_Ucreti = record.Aylik_Abonelik_Ucreti;
            model.Ucretsiz_Parklanma_Suresi_dakika = record.Ucretsiz_Parklanma_Suresi_dakika;
            model.Tarifesi = record.Tarifesi;
            model.Park_Et_Devam_Et_Noktasi = record.Park_Et_Devam_Et_Noktasi;


            List<Record> records = _parkcontext.Records.ToList();

            List<AltBolgeDTO> altBolgeDTOs = new List<AltBolgeDTO>();

            foreach (var item in records)
            {
                var recordControl = altBolgeDTOs.FirstOrDefault(x => x.AltBolgeAd == item.AltBolge);

                if (recordControl == null)
                {
                    AltBolgeDTO modelaltbolge = new AltBolgeDTO();

                    modelaltbolge.AltBolgeAd = item.AltBolge;
                    altBolgeDTOs.Add(modelaltbolge);

                }

            }

            model.AltBolgeDTOs = altBolgeDTOs;



            List<IlceDTO> IlceDTOs = new List<IlceDTO>();

            foreach (var item in records)
            {
                var recordControl = IlceDTOs.FirstOrDefault(x => x.IlceAd == item.Ilce);

                if (recordControl == null)
                {
                    IlceDTO modelılce = new IlceDTO();

                    modelılce.IlceAd = item.Ilce;
                    IlceDTOs.Add(modelılce);
                }

            }

            model.IlceDTOs = IlceDTOs;


            List<ParkTipiDTO> parkTipiDTOs = new List<ParkTipiDTO>();

            foreach (var item in records)
            {
                var recordControl = parkTipiDTOs.FirstOrDefault(x => x.ParkTipiAd == item.ParkTipi);

                if (recordControl == null)
                {
                    ParkTipiDTO modelparktipi = new ParkTipiDTO();

                    modelparktipi.ParkTipiAd = item.ParkTipi;
                    parkTipiDTOs.Add(modelparktipi);
                }


            }

            model.ParkTipiDTOs = parkTipiDTOs;


            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(RecordDTO model, string ParkTipi, string Bolge, string Altbolge, string Ilce)
        {
            Record record = _parkcontext.Records.FirstOrDefault(q => q.ID == model._id);

            record.ParkAdi = model.ParkAdi;
            record.LokasyonAdi = model.LokasyonAdi;
            record.ParkKapasitesi = model.ParkKapasitesi;
            record.CalismaSaatleri = model.CalismaSaatleri;
            record.Aylik_Abonelik_Ucreti = model.Aylik_Abonelik_Ucreti;
            record.Ucretsiz_Parklanma_Suresi_dakika = model.Ucretsiz_Parklanma_Suresi_dakika;
            record.Tarifesi = model.Tarifesi;
            record.Adres = model.Adres;

            record.ParkTipi = ParkTipi;
            record.Bolge = Bolge;
            record.AltBolge = Altbolge;
            record.Ilce = Ilce;

            _parkcontext.SaveChanges();

            return RedirectToAction("RecordList", "Home");

        }

        // Pop up denemeleri
        public IActionResult deneme()
        {
            return View();
        }

    }
}
