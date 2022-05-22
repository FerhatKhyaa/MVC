using AdonetCoreMVC3.Entities;
using AdonetCoreMVC3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace AdonetCoreMVC3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult Ogrenci()
        {
            List<Ogrenci> ogrenci = new List<Ogrenci> 
            {
                new Ogrenci {OgrId=1 , OgrName="Ahmet",OgrKulup="Bilgisayar",OgrSehir="İstanbul"},
                new Ogrenci {OgrId=2 , OgrName="Veli",OgrKulup="Satranç",OgrSehir="Tekirdağ"},
                new Ogrenci {OgrId=3 , OgrName="Ayşe",OgrKulup="Kitaplık",OgrSehir="Çanakkale"},
                new Ogrenci {OgrId=4 , OgrName="Seçil",OgrKulup="Gezi",OgrSehir="Edirne"},
                new Ogrenci {OgrId=5 , OgrName="Elif",OgrKulup="Bilgisayar",OgrSehir="Çanakkale"},
                new Ogrenci {OgrId=6 , OgrName="Orkun",OgrKulup="Satranç",OgrSehir="Edirne"},
                new Ogrenci {OgrId=7 , OgrName="Baran",OgrKulup="Gezi",OgrSehir="İstanbul"}
            };
            return View(ogrenci);
        }

        public ViewResult Ders()
        {
            List<Dersler> derslerList = new List<Dersler>
            {
                new Dersler {DersId=1 , DersName="Matematik"},
                new Dersler {DersId=2 , DersName="Türkçe"},
                new Dersler {DersId=3 , DersName="Tarih"},
                new Dersler {DersId=4 , DersName="İngilizce"}
            };
            return View(derslerList);
        }

        public ViewResult Sinavlar()
        {
            List<Sinavlar> sinavlar = new List<Sinavlar>
            {
                new Sinavlar {SinavId=1 , SinavDersId=2 , Sinav1=67 , Sinav2=70 , Sinav3=55 , SinavOrt=64 , SinavDurum="Geçti"},
                new Sinavlar {SinavId=2 , SinavDersId=3 , Sinav1=85 , Sinav2=90 , Sinav3=85 , SinavOrt=86 , SinavDurum="Geçti"},
                new Sinavlar {SinavId=3 , SinavDersId=1 , Sinav1=45 , Sinav2=40 , Sinav3=75 , SinavOrt=53 , SinavDurum="Kaldı"},
                new Sinavlar {SinavId=4 , SinavDersId=4 , Sinav1=65 , Sinav2=78 , Sinav3=68 , SinavOrt=70 , SinavDurum="Geçti"},
                new Sinavlar {SinavId=5 , SinavDersId=2 , Sinav1=35 , Sinav2=32 , Sinav3=20 , SinavOrt=29 , SinavDurum="Kaldı"},
                new Sinavlar {SinavId=6 , SinavDersId=3 , Sinav1=72 , Sinav2=63 , Sinav3=53 , SinavOrt=62 , SinavDurum="Geçti"},
                new Sinavlar {SinavId=7 , SinavDersId=4 , Sinav1=67 , Sinav2=90 , Sinav3=95 , SinavOrt=84 , SinavDurum="Geçti"},
            };
            return View(sinavlar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}