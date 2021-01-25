using CarParkSample.Models.ORM;
using CarParkSample.Models.ORM.Context;
using CarParkSample.Models.VM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkSample.Controllers
{
    public class RecordSelectedController : Controller
    {
        private readonly CarParkContext _parkcontext;
        public RecordSelectedController(CarParkContext parkcontext)
        {
            _parkcontext = parkcontext;
        }

        public JsonResult AddRecord(RecordDTO recorddto)
        {
            if (ModelState.IsValid)
            {
                RecordSelected record = new RecordSelected();
                record.Adres = recorddto.Adres;
                record.AltBolge = recorddto.AltBolge;
                record.Enlem = recorddto.Enlem;
                record.Boylam = recorddto.Boylam;
                record.Aylik_Abonelik_Ucreti = recorddto.Aylik_Abonelik_Ucreti;
                record.Bolge = recorddto.Bolge;
                record.CalismaSaatleri = recorddto.CalismaSaatleri;
                record.Ilce = recorddto.Ilce;
                record.LokasyonAdi = recorddto.LokasyonAdi;
                record.Ucretsiz_Parklanma_Suresi_dakika = recorddto.Ucretsiz_Parklanma_Suresi_dakika;

                _parkcontext.RecordSelects.Add(record);
                _parkcontext.SaveChanges();

                return Json("");
            }
            else
            {
                return Json("Gerekli alanları doldurunuz!");

            }

        }


        public JsonResult selectedrecords()
        {
            List<RecordSelected> selects = _parkcontext.RecordSelects.ToList();


            return Json(selects);
        }
    }
}
