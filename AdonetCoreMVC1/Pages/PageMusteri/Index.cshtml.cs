using AdonetCoreMVC1.Entities;
using AdonetCoreMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdonetCoreMVC1.Pages.PageMusteri
{
    public class IndexModel : PageModel
    {
        #region Veritabaný baðlantýsýný context'i tanýmlýyoruz.

        private readonly MusteriVtContext _context;

        public IndexModel(MusteriVtContext context)
        {
            _context = context;
        }

        #endregion

        #region Sayfa get edilirken çalýþan method içerisine oluþturduðumuz field'ý contextten aldýðýmýz veri ile dolduruyoruz.

        public List<Musteri> Musteriler { get; set; }
        #endregion
        //public void OnGet()
        //{
          //  Musteriler = _context.Musteris.ToList();
        //}

        public void OnGet(string arama)  // Parametreli pages kullanýmý 
        {
            if (string.IsNullOrEmpty(arama))
            {
                Musteriler = _context.Musteris.ToList();
            }
            else
            {
                Musteriler = _context.Musteris.Where(m => m.Adi.ToLower().Contains(arama.ToLower())).ToList();
            }
        }
        #region Ekleme iþlemini yapýp tekrar index'e yönlendiriyoruz ki yeni eklediðimiz kayýtlarý tekrar görelim

        [BindProperty] // Ekrandaki Musteri. ile baþlayan deðerleri buraya post edecek
        public Musteri musteri { get; set; }
        public IActionResult OnPost()
        {
            _context.Musteris.Add(musteri);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
        #endregion
    }
}
