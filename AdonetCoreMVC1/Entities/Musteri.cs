using System.ComponentModel.DataAnnotations;

namespace AdonetCoreMVC1.Entities
{
    public class Musteri
    {
        [Display(Name ="Id Bilgisi")]
        public int Id { get; set; }
        [Display(Name = "Müşteri Adı")]
        public string Adi { get; set; }
        [Display(Name = "Müşteri Soyadı")]
        public string Soyadi { get; set; }
        [Display(Name = "Müşteri Telefonu")]
        public string Tel { get; set; }
        [Display(Name = "Şirket Adı")]
        public string SirketAdi { get; set; }
    }
}
