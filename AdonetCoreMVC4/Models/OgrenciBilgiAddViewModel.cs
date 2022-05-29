using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdonetCoreMVC4
{
    public class OgrenciBilgiAddViewModel
    {
        public List<SelectListItem> Ogrenci { get; set; }
        public List<SelectListItem> Bolum { get; set; }
        public List<SelectListItem> Dersler { get; set; }
        public List<SelectListItem> Derslik { get; set; }
        public List<SelectListItem> Sinif { get; set; }
    }
}