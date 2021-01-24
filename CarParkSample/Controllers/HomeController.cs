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


        public JsonResult Records()
        {
            List<Record> records = _parkcontext.Records.ToList();

            return Json(records);
        }
        
        public IActionResult Index2()
        {
            string data = new WebClient().DownloadString("https://data.ibb.gov.tr/en/datastore/odata3.0/c3eb0d72-1ce4-4983-a3a8-6b0b4b19fcb9?&$format=json");
            
            var list  = JsonConvert.DeserializeObject<RecordListDTO>(data);

            //List<Record> record = new List<Record>();


            foreach (var item in list.recordlist)
            {
                var recordControl = _parkcontext.Records.FirstOrDefault(x => x._id == item._id );
                if (recordControl == null)
                {
                    Record record = new Record();
                    record._id = item._id;
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
       

        public IActionResult Index3()
        {
            return View();
        }

        public IActionResult Index4()
        {
            return View();
        }

        public IActionResult RecordList()
        {


            List<RecordDTO> records = _parkcontext.Records.Select(x => new RecordDTO()
            {
                _id = x._id,
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
            Record record = _parkcontext.Records.FirstOrDefault(x => x._id == id);

            _parkcontext.Records.Remove(record);

            _parkcontext.SaveChanges();

           return Redirect("/Home/RecordList");
        }

        public  IActionResult Edit(int id) 
        {
            Record record = _parkcontext.Records.FirstOrDefault(x => x._id == id);

            RecordDTO model = new RecordDTO();
            model._id = record._id;
            model.ParkID = record.ParkID;
            model.ParkAdi = record.ParkAdi;
            model.LokasyonAdi = record.LokasyonAdi;
            model.LokasyonID = record.LokasyonID;
            model.LokasyonKodu = record.LokasyonKodu;
            model.ParkTipiID = record.ParkTipiID;
            model.ParkTipi = record.ParkTipi;
           model.ParkKapasitesi = record.ParkKapasitesi;
            model.CalismaSaatleri = record.CalismaSaatleri;
            model.BolgeID = record.BolgeID;
            model.Bolge = record.Bolge;
            model.AltBolgeID = record.AltBolgeID;
            model.AltBolge = record.AltBolge;
            model.IlceID = record.IlceID;
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

            return View(model);


        }





    }
}
