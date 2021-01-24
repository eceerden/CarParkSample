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
                    record.Adres = item.Adres;
                    record.Aylik_Abonelik_Ucreti = item.Aylik_Abonelik_Ucreti;
                    record.Enlem_Boylam = item.Enlem_Boylam;
                    record.IsDeleted = false;
                    record.Park_Et_Devam_Et_Noktasi = item.Park_Et_Devam_Et_Noktasi;
                    record.ParkID = item.ParkID;
                    record.Tarifesi = item.Tarifesi;
                    record.Ucretsiz_Parklanma_Suresi_dakika = item.Ucretsiz_Parklanma_Suresi_dakika;
                    record._id = item._id;
                    record.Enlem = item.Enlem;
                    record.Boylam = item.Boylam;
                    record.Polygon_Verisi = item.Polygon_Verisi;

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
       
    }
}
