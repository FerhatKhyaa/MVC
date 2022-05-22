using AdonetCoreMVC1.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdonetCoreMVC1
{
    public class CalisanAddViewModel
    {
        public Calisan Calisan { get; set; }
        public List<SelectListItem> sehirler { get; set; }
    }
}