using System.ComponentModel.DataAnnotations;

namespace AdonetCoreMVC5.Entities
{
    public class BilgiIslem
    {
        [Display(Name = "Id Giriniz :")]
        public int Id { get; set; }
        [Display(Name = "Ad Giriniz :")]
        public string Name { get; set; }
        [Display(Name = "Soyad Giriniz :")]
        public string Surname { get; set; }
        [Display(Name = "Maaşınızı Giriniz :")]
        public decimal Money { get; set; }
        [Display(Name = "Şehrinizi Seçiniz :")]
        public string Country { get; set; }
        [Display(Name = "Lütfen Yaşınızı Giriniz :")]
        public int YearsOld { get; set; }
    }
}
