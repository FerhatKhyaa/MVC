using AdonetCoreMVC5.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AdonetCoreMVC5.Controllers
{
    public class BilgiIslemCalisanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            var bilgiIslemCalisanAddViewModel = new BilgiIslemCalisanAddViewModel
            {
                BilgiIslemCalisan = new BilgiIslemCalisan(),
            };
            return View(bilgiIslemCalisanAddViewModel);
        }
    }
}
