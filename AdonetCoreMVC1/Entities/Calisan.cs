using System.ComponentModel.DataAnnotations;

namespace AdonetCoreMVC1.Entities
{
    public class Calisan
    {
        [Display(Name = "Id Bilgisi : ")]
        public int Id { get; set; }
        [Display(Name = "Ad Bilgisi : ")]
        public string Adi { get; set; }
        [Display(Name = "Soyadı Bilgisi : ")]
        public string Soyadi { get; set; }
        [Display(Name = "Maaş Bilgisi : ")]
        public decimal Maas { get; set; }
        [Display(Name = "Şehir Bilgisi : ")]
        public int Sehir { get; set; }
    }
}
