using AdonetCoreMVC1.Entities;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace AdonetCoreMVC1.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("parametreli-calisan-list")]
    public class ParametreliCalisanListTagHelper : TagHelper
    {
        private List<Calisan> _calisans;
        public ParametreliCalisanListTagHelper()
        {
            _calisans = new List<Calisan>
            {
                new Calisan {Id=1 , Adi="Samet",Soyadi="Erdem",Maas=2000,Sehir=59},
                new Calisan {Id=2 , Adi="Ahmet",Soyadi="Sarıkaya",Maas=2000,Sehir=59},
                new Calisan {Id=3 , Adi="Furkan",Soyadi="Furkan",Maas=2000,Sehir=59},
                new Calisan {Id=4 , Adi="Mehmet",Soyadi="Mehmet",Maas=2000,Sehir=59}
            };
        }

        private const string sayiyaGoreGetirBaglantiAdi = "sayi";

        [HtmlAttributeName(sayiyaGoreGetirBaglantiAdi)]

        public int SayiyaGoreGetir { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            var query = _calisans.Take(SayiyaGoreGetir);
            StringBuilder metinOlusturucu = new StringBuilder();

            foreach (var calisan in query)
            {
                metinOlusturucu.AppendFormat("<h2><a href='/calisan/detay/{0}'>{1}</a></h2>", calisan.Id, (calisan.Adi + " " + calisan.Soyadi));
            }

            output.Content.SetHtmlContent(metinOlusturucu.ToString());

            base.Process(context, output);
        }
    }
}
