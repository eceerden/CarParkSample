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
        // Pop up input doldurarak ekleme işlemi
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
        // Seçilen Otoparklar Tablosu
        public IActionResult selectedrecords()
        {
           List<RecordDTO> records = _parkcontext.RecordSelects.Select(x => new RecordDTO()
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


        public IActionResult Secilen()
        {
            return View();
        }

        // Seçilen Verileri JSON olarak döndüren metod
        public JsonResult SelectedRecordsDB()
        {
            List<RecordSelected> selects = _parkcontext.RecordSelects.ToList();

            return Json(selects);
        }

        // Tablodan ekleme yöntemi
        [HttpPost]
        public IActionResult Ekle(int id)
        {
            Record selected = _parkcontext.Records.FirstOrDefault(x => x.ID == id);
            
            var control = _parkcontext.RecordSelects.FirstOrDefault(x => x.ID == id);
            if (control == null)
            {
RecordSelected model = new RecordSelected();

                model.ParkID = selected.ParkID;
                model.ParkAdi = selected.ParkAdi;
                model.LokasyonAdi = selected.LokasyonAdi;
                model.LokasyonID = selected.LokasyonID;
                model.LokasyonKodu = selected.LokasyonKodu;
                model.ParkTipi = selected.ParkTipi;
                model.ParkTipiID = selected.ParkTipiID;
                model.ParkKapasitesi = selected.ParkKapasitesi;
                model.CalismaSaatleri = selected.CalismaSaatleri;
                model.Bolge = selected.Bolge;
                model.BolgeID = selected.BolgeID;
                model.AltBolge = selected.AltBolge;
                model.AltBolgeID = selected.AltBolgeID;
                model.Ilce = selected.Ilce;
                model.Adres = selected.Adres;
                model.Enlem_Boylam = selected.Enlem_Boylam;
                model.Polygon_Verisi = selected.Polygon_Verisi;
                model.Boylam = selected.Boylam;
                model.Enlem = selected.Enlem;
                model.Aylik_Abonelik_Ucreti = selected.Aylik_Abonelik_Ucreti;
                model.Ucretsiz_Parklanma_Suresi_dakika = selected.Ucretsiz_Parklanma_Suresi_dakika;
                model.Tarifesi = selected.Tarifesi;
                model.Park_Et_Devam_Et_Noktasi = selected.Park_Et_Devam_Et_Noktasi;

                _parkcontext.RecordSelects.Add(model);
                _parkcontext.SaveChanges();
          
            return RedirectToAction("RecordList","Home");
            }
            return RedirectToAction("RecordList", "Home");
        }

        public IActionResult Edit(int id)
        {
           RecordSelected record = _parkcontext.RecordSelects.FirstOrDefault(x => x.ID == id);

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


            List<Record> selects = _parkcontext.Records.ToList();

            List<AltBolgeDTO> altBolgeDTOs = new List<AltBolgeDTO>();

            foreach (var item in selects)
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

            foreach (var item in selects)
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

            foreach (var item in selects)
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
            RecordSelected record = _parkcontext.RecordSelects.FirstOrDefault(q => q.ID == model._id);

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

            return Redirect("/RecordSelected/selectedrecords");

        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            RecordSelected select = _parkcontext.RecordSelects.FirstOrDefault(x => x.ID == id);

            _parkcontext.RecordSelects.Remove(select);

            _parkcontext.SaveChanges();

            return Redirect("/RecordSelected/selectedrecords");
        }
    }
}
