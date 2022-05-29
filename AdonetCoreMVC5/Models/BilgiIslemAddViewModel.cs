using AdonetCoreMVC5.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdonetCoreMVC5
{
    public class BilgiIslemAddViewModel
    {
        public BilgiIslem BilgiIslem { get; set; }
        public List<SelectListItem> Sehir { get; set; }
        public BilgiIslemCalisan BilgiIslemCalisan { get; set; }
    }
}