using System.ComponentModel.DataAnnotations;

namespace AdonetCoreMVC5.Entities
{
    public class BilgiIslemCalisan
    {
        [Display (Name ="Çalışan İd Giriniz : ")]
        public int CalisanId { get; set; }
        [Display(Name = "Çalışan Ad-Soyad Giriniz : ")]
        public string CalisanAdiSoyadi { get; set; }
        
        [Display(Name = "Çalışan Ne Hakkında İşlem Yapıldı? : ")]
        public string CalisanYapilanIslem { get; set; }
    }
}
