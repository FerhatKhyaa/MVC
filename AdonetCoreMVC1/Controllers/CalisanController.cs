using AdonetCoreMVC1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering; // SelectListItem için bu kütüphane gerekli

namespace AdonetCoreMVC1.Controllers
{
    public class CalisanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var calisanAddViewModel = new CalisanAddViewModel
            {
                Calisan = new Calisan(), // 1.Tanım
                sehirler = new List<SelectListItem>
                {
                    new SelectListItem{Text="Tekirdağ",Value="59"},
                    new SelectListItem{Text="İstanbul",Value="34"},
                    new SelectListItem{Text="Ankara",Value="06"}
                }
            };
            return View(calisanAddViewModel);
        }

        [HttpPost] // Submit yapılırsa post işlemi ile çalışacak olan method
        public IActionResult Add(Calisan calisan)
        {
            return View();
        }
    }
}
