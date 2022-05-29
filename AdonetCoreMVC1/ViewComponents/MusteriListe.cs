using AdonetCoreMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdonetCoreMVC1.ViewComponents
{
    public class MusteriListe : ViewComponent // ViewComponent olduğu tanımlanır! Default olarak "Views > Shared > Components > 'MusteriListe' default.cshtml Arar!
    {
        private readonly MusteriVtContext _context;

        public MusteriListe(MusteriVtContext context)
        {
            _context = context;
        }

        //public IViewComponentResult Invoke()
        //{
        //    var sonMusteriler = _context.Musteris.ToList();

        //    var sonMusterilert = new ViewComponentMusteriListesi
        //    {
        //        sonMusterilerim = sonMusteriler
        //    };

        //    return View(sonMusterilert);
        //}

        #region Parametreli Çalış
        public IViewComponentResult Invoke(string parametre)
        {
            #region QueryString Kullanımı 
            string QueryDeger = HttpContext.Request.Query["parametre"];
            #endregion

            if (!string.IsNullOrEmpty(QueryDeger))
            {
                parametre = QueryDeger;
            }

            if (string.IsNullOrEmpty(parametre))
            {
                var sonMusteriler = _context.Musteris.ToList();
                var sonMusterilert = new ViewComponentMusteriListesi
                {
                    sonMusterilerim = sonMusteriler
                };
                return View(sonMusterilert);
            }
            else
            {
                var sonMusteriler = _context.Musteris.Where(m => m.Adi.ToLower().Contains(parametre.ToLower())).ToList();
                var sonMusterilert = new ViewComponentMusteriListesi
                {
                    sonMusterilerim = sonMusteriler
                };
                return View(sonMusterilert);
            }
        }

        #endregion
    }
}
