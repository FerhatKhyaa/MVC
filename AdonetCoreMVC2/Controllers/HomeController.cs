using AdonetCoreMVC2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdonetCoreMVC2.Controllers
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
            List<Ogrenciler> ogrenci = new List<Ogrenciler> { 
            new Ogrenciler{OgrId = 1 , OgrAdSoyad = "Ferhat Kahya" , OgrNotOrtalamasi = 70 , OgrDurum="Geçti" , OgrKulup = "Satranç" , OgrSehir = "Tekirdağ"},
            new Ogrenciler{OgrId = 2 , OgrAdSoyad = "Ayşe Solmaz" , OgrNotOrtalamasi = 45 , OgrDurum="Kaldı" , OgrKulup = "Bilgisayar" , OgrSehir = "İzmir"},
            new Ogrenciler{OgrId = 3 , OgrAdSoyad = "Kerem Kahya" , OgrNotOrtalamasi = 50 , OgrDurum="Kaldı" , OgrKulup = "Futbol" , OgrSehir = "Tekirdağ"},
            new Ogrenciler{OgrId = 4 , OgrAdSoyad = "Gürkan Kahya" , OgrNotOrtalamasi = 65 , OgrDurum="Geçti" , OgrKulup = "Masa Tenisi" , OgrSehir = "Tekirdağ"},
            new Ogrenciler{OgrId = 5 , OgrAdSoyad = "Hande Çakıllı" , OgrNotOrtalamasi = 38 , OgrDurum="Kaldı" , OgrKulup = "Bilgisayar" , OgrSehir = "İstanbul"},
            new Ogrenciler{OgrId = 6 , OgrAdSoyad = "Yasin Dertop" , OgrNotOrtalamasi = 89 , OgrDurum="Geçti" , OgrKulup = "Bilişim" , OgrSehir = "Denizli"},
            new Ogrenciler{OgrId = 7 , OgrAdSoyad = "Ali Güneş" , OgrNotOrtalamasi = 76 , OgrDurum="Geçti" , OgrKulup = "Dama" , OgrSehir = "Balıkesir"},
            new Ogrenciler{OgrId = 8 , OgrAdSoyad = "Hatice Kılınç" , OgrNotOrtalamasi = 44 , OgrDurum="Kaldı" , OgrKulup = "Kütüphane" , OgrSehir = "Bitlis"},
            new Ogrenciler{OgrId = 9 , OgrAdSoyad = "Songül Varol" , OgrNotOrtalamasi = 21 , OgrDurum="Kaldı" , OgrKulup = "Bilişim" , OgrSehir = "Muş"},
            new Ogrenciler{OgrId = 10 , OgrAdSoyad = "Ahmet Aktaş" , OgrNotOrtalamasi = 90 , OgrDurum="Geçti" , OgrKulup = "Futbol" , OgrSehir = "Hakkari"}
            };
            return View(ogrenci);
        }

        public ViewResult Ders()
        {
            List<Dersler> dersler = new List<Dersler> {
            new Dersler {DersId = 1 , DersAdi = "Matematik" , DersOgretmeni = ""},
            new Dersler {DersId = 2 , DersAdi = "Fizik" , DersOgretmeni = ""},
            new Dersler {DersId = 3 , DersAdi = "Kimya" , DersOgretmeni = ""},
            new Dersler {DersId = 4 , DersAdi = "Biyoloji" , DersOgretmeni = ""},
            new Dersler {DersId = 5 , DersAdi = "Türk Dili ve Edebiyat" , DersOgretmeni = ""},
            new Dersler {DersId = 6 , DersAdi = "Din Kültürü ve Ahlak Bilgisi" , DersOgretmeni = ""},
            new Dersler {DersId = 7 , DersAdi = "Müzik" , DersOgretmeni = ""}
            };
            return View(dersler);
        }

        public ViewResult Ogretmen()
        {
            List<Ogretmenler> ogretmen = new List<Ogretmenler> {
            new Ogretmenler {OgrtId = 1 , OgrtAdSoyad= "Mesut Tekgöz" , OgrtBrans = "Müzik"},
            new Ogretmenler {OgrtId = 2 , OgrtAdSoyad= "Kutsal Demir" , OgrtBrans = "Din Kültürü ve Ahlak Bilgisi"},
            new Ogretmenler {OgrtId = 3 , OgrtAdSoyad= "Alpin Ateş" , OgrtBrans = "Matematik"},
            new Ogretmenler {OgrtId = 4 , OgrtAdSoyad= "Selina Öztürk" , OgrtBrans = "Biyoloji"},
            new Ogretmenler {OgrtId = 5 , OgrtAdSoyad= "Gökçen Soysal" , OgrtBrans = "Türk Dili ve Edebiyatı"},
            new Ogretmenler {OgrtId = 6 , OgrtAdSoyad= "Gülten Kurt" , OgrtBrans = "Kimya"},
            new Ogretmenler {OgrtId = 7 , OgrtAdSoyad= "Aylin Atılgan" , OgrtBrans = "Fizik"},

            };
            return View(ogretmen);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}