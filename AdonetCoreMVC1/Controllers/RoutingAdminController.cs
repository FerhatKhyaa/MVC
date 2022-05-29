using Microsoft.AspNetCore.Mvc;

namespace AdonetCoreMVC1.Controllers
{
    [Route("Ferhat")]
    public class RoutingAdminController : Controller
    {
        [Route("")]
        [Route("save")]
        [Route("save2")]
        [Route("~/save")] // önündeki herşeyi iptal et ve bunu çalıştır.

        public string Save()
        {
            return "Kayıt Edildi";
        }

        [Route("delete/{id?}")]

        public string Delete(int id = 0)
        {
            return String.Format("Kayıt silindi {0}", id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
