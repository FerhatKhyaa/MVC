using AdonetCoreMVC1.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AdonetCoreMVC1.Controllers
{
    public class FilterController : Controller
    {
        // Filters'ları biz controlleerlarımızın aksiyonlarının başında ya da sonunda sürekli olarak çalışmasını istediğimiz kod blokları var ise filter olarak tanımlanır ve ilgili action(method) larımızı tanımlanır.

        [LoglamaYap] // Filters kullanımı yapıldığında tanımadık...
        public IActionResult Index()
        {
            return View();
        }
    }
}
