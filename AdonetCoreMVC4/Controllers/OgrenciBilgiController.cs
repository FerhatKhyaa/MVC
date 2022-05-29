using AdonetCoreMVC4.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdonetCoreMVC4.Controllers
{
    public class OgrenciBilgiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult Getir()
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>
            {
                new Ogrenci {OgrId = 1 , OgrAd= "Ferhat" , OgrSoyad="Kahya"},
                new Ogrenci {OgrId = 2 , OgrAd= "Samet" , OgrSoyad="Erdem"},
                new Ogrenci {OgrId = 3 , OgrAd= "Halide" , OgrSoyad="Adıvar"},
                new Ogrenci {OgrId = 4 , OgrAd= "Gülden" , OgrSoyad="Mutlu"},
                new Ogrenci {OgrId = 5 , OgrAd= "Hayriye" , OgrSoyad="Korkmaz"}
            };
            return View(ogrencis);
        }
        public IActionResult Add()
        {
            var ogrenciBilgiAddViewModel = new OgrenciBilgiAddViewModel
            {
                Ogrenci = new List<SelectListItem>(),
                Bolum = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Düz", Value = "1" },
                    new SelectListItem { Text = "Sözel", Value = "2" },
                    new SelectListItem { Text = "Eşit Ağırlık", Value = "3" },
                    new SelectListItem { Text = "Sayısal", Value = "4" }
                },
                Dersler = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Matematik", Value = "1" },
                    new SelectListItem { Text = "Türk Dili ve Edebiyatı", Value = "2" },
                    new SelectListItem { Text = "Fizik", Value = "3" },
                    new SelectListItem { Text = "Beden Eğitimi", Value = "4" },
                    new SelectListItem { Text = "Kimya", Value = "5" },
                    new SelectListItem { Text = "Biyoloji", Value = "6" },
                    new SelectListItem { Text = "Görsel Sanatlar / Müzik", Value = "7" },
                    new SelectListItem { Text = "İngilizce", Value = "8" },
                    new SelectListItem { Text = "Tarih", Value = "9" },
                    new SelectListItem { Text = "Din Kültürü ve Ahlak Bilgisi", Value = "10" },
                    new SelectListItem { Text = "Almanca", Value = "11" },
                    new SelectListItem { Text = "Coğrafya", Value = "12" },
                    new SelectListItem { Text = "Felsefe", Value = "13" },
                    new SelectListItem { Text = "Seçmeli Matematik", Value = "14" },
                    new SelectListItem { Text = "Seçmeli Fizik", Value = "15" },
                    new SelectListItem { Text = "Seçmeli Kimya", Value = "16" },
                    new SelectListItem { Text = "Seçmeli Biyoloji", Value = "17" },
                    new SelectListItem { Text = "Seçmeli Türk Dili ve Edebiyatı", Value = "18" },
                    new SelectListItem { Text = "Sosyoloji", Value = "19" },
                    new SelectListItem { Text = "T.C. İNKILAP TARİHİ VE ATATÜRKÇÜLÜK", Value = "20" }
                },
                Derslik = new List<SelectListItem>
                {
                    new SelectListItem { Text = "A", Value = "1" },
                    new SelectListItem { Text = "B", Value = "2" },
                    new SelectListItem { Text = "C", Value = "3" },
                    new SelectListItem { Text = "D", Value = "4" },
                    new SelectListItem { Text = "E", Value = "5" },
                    new SelectListItem { Text = "F", Value = "6" },
                },
                Sinif = new List<SelectListItem>
                {
                    new SelectListItem { Text = "9", Value = "1" },
                    new SelectListItem { Text = "10", Value = "2" },
                    new SelectListItem { Text = "11", Value = "3" },
                    new SelectListItem { Text = "12", Value = "4" }
                },

            };
            return View(ogrenciBilgiAddViewModel);
        } 
        public IActionResult Add(OgrenciBilgiAddViewModel ogrenciBilgiAddViewModel)
        {
            return View();
        }
    }
}
