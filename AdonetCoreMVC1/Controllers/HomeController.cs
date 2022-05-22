using AdonetCoreMVC1.Entities;
using AdonetCoreMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdonetCoreMVC1.Controllers
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
        public string Merhaba()
        {
            return "Ferhat Kahya";
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult IlkHtmlSayfam()
        {
            return View();
        }

        

        public ViewResult Ornek()
        {
            List<Calisan> calisan = new List<Calisan>
            { 
            new Calisan{Id = 1 , Adi = "Samet" , Soyadi= "Erdem" , Maas= 2500},
            new Calisan{Id = 2 , Adi = "Ferhat" , Soyadi= "Kahya" , Maas= 2500},
            new Calisan{Id = 3 , Adi = "Gürkan" , Soyadi= "Kahya" , Maas= 5000},
            new Calisan{Id = 4 , Adi = "Zehra" , Soyadi= "Kahya" , Maas = 4250}
            };
            
            return View(calisan);
        }

        public ViewResult Ornek2()
        {
            List<Calisan> calisan = new List<Calisan>
            {
            new Calisan{Id = 1 , Adi = "Samet" , Soyadi= "Erdem" , Maas= 2500},
            new Calisan{Id = 2 , Adi = "Ferhat" , Soyadi= "Kahya" , Maas= 2500},
            new Calisan{Id = 3 , Adi = "Gürkan" , Soyadi= "Kahya" , Maas= 5000},
            new Calisan{Id = 4 , Adi = "Zehra" , Soyadi= "Kahya" , Maas = 4250}
            };
            string[] sehirler = new string[] { "Tekirdağ", "Rize", "Hatay" };

            var calisanGetirModel = new CalisanGetirModel
            {
                Calisan = calisan,
                Sehirler = sehirler
            };

            return View(calisanGetirModel);
        }

        public IActionResult Ornek3() // Bu türde nesneler döndürebiliriz. Yapılan istekde bir sıkıntı olmadığında 200 döndürürüz.
        {
            return StatusCode(200);
        }
        public IActionResult Ornek4() // Sayfa kaynağında hata olduğunda bu 400 hatası karşımıza çıkar.
        {
            return StatusCode(400);
        }
        public IActionResult Ornek5() // 404 hata kodu böyle bir sayfa bulunamadı anlamına gelir.
        {
            return StatusCode(404);
        }

        public StatusCodeResult Ornek6() // StatuscodeResult ile sadece hata kodlarını döndürmemize yarar.
        {
            return StatusCode(404);
        }

        public RedirectResult Ornek7() // Başka bir değer döndüremez. Sadece başka linke yönlendirme işlemleri yapılabilir.
        {
            return Redirect("/Home/Ornek");
        }

        public IActionResult Ornek8()
        {
            return RedirectToAction("default");
        }

        public JsonResult Ornek9() // Json formatına verilerimizi döndürüyor. Bu daha çok mobil taraf için lazım oluyor.
        {
            List<Calisan> calisan = new List<Calisan>
            {
            new Calisan{Id = 1 , Adi = "Samet" , Soyadi= "Erdem" , Maas= 2500},
            new Calisan{Id = 2 , Adi = "Ferhat" , Soyadi= "Kahya" , Maas= 2500},
            new Calisan{Id = 3 , Adi = "Gürkan" , Soyadi= "Kahya" , Maas= 5000},
            new Calisan{Id = 4 , Adi = "Zehra" , Soyadi= "Kahya" , Maas = 4250}
            };

            return Json(calisan);
        }

        public ViewResult RazorDemo() // Razor syntaxı ile html sayfasında kullanım örnekleri
        {
            return View();
        }

        public JsonResult AramaYap(string key)
        {
            List<Calisan> calisan = new List<Calisan>
            {
            new Calisan{Id = 1 , Adi = "Samet" , Soyadi= "Erdem" , Maas= 2500},
            new Calisan{Id = 2 , Adi = "Ferhat" , Soyadi= "Kahya" , Maas= 2500},
            new Calisan{Id = 3 , Adi = "Gürkan" , Soyadi= "Kahya" , Maas= 5000},
            new Calisan{Id = 4 , Adi = "Zehra" , Soyadi= "Kahya" , Maas = 4250}
            };

            if (String.IsNullOrEmpty(key))
            {
                return Json(calisan);
            }
            else
            {
                var icerik = calisan.Where(c => c.Adi.ToLower().Contains(key)).ToList();
                return Json(icerik);
            }
        }
        public ViewResult FormIleArama()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}