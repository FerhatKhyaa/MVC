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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}