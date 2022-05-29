using Microsoft.AspNetCore.Mvc;
using AdonetCoreMVC5.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdonetCoreMVC5.Controllers
{
    public class BilgiIslemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            var bilgiIslemAddViewModel = new BilgiIslemAddViewModel
            {
                BilgiIslem = new BilgiIslem(),
                Sehir = new List<SelectListItem>
                {
                    new SelectListItem {Text="Tekirdağ", Value="59"},
                    new SelectListItem {Text="İstanbul", Value="34"},
                    new SelectListItem {Text="Adana", Value="01"},
                    new SelectListItem {Text="Ankara", Value="06"}
                },
                BilgiIslemCalisan = new BilgiIslemCalisan()





            };
            return View(bilgiIslemAddViewModel);
        }
        [HttpPost]
        public IActionResult Add(BilgiIslem bilgiIslem)
        {
            return View();
        }
    }
}
