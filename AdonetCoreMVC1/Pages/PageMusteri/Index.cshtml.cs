using AdonetCoreMVC1.Entities;
using AdonetCoreMVC1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdonetCoreMVC1.Pages.PageMusteri
{
    public class IndexModel : PageModel
    {
        #region Veritaban� ba�lant�s�n� context'i tan�ml�yoruz.

        private readonly MusteriVtContext _context;

        public IndexModel(MusteriVtContext context)
        {
            _context = context;
        }

        #endregion

        #region Sayfa get edilirken �al��an method i�erisine olu�turdu�umuz field'� contextten ald���m�z veri ile dolduruyoruz.

        public List<Musteri> Musteriler { get; set; }
        #endregion
        //public void OnGet()
        //{
          //  Musteriler = _context.Musteris.ToList();
        //}

        public void OnGet(string arama)  // Parametreli pages kullan�m� 
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
        #region Ekleme i�lemini yap�p tekrar index'e y�nlendiriyoruz ki yeni ekledi�imiz kay�tlar� tekrar g�relim

        [BindProperty] // Ekrandaki Musteri. ile ba�layan de�erleri buraya post edecek
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
