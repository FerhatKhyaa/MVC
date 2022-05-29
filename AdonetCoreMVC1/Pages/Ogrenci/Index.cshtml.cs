using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdonetCoreMVC1.Pages.Ogrenci
{
    public class IndexModel : PageModel
    {
        public string Mesaj { get; set; }
        public void OnGet()
        {
            Mesaj += "Tarih : " + DateTime.Now;
        }
    }
}
