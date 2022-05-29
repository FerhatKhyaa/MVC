using System.ComponentModel.DataAnnotations;

namespace AdonetCoreMVC4.Entities
{
    public class Ogrenci
    {
        public int OgrId { get; set; }
        public int BolumId { get; set; }
        public int SinifId { get; set; }
        public int DerslikId { get; set; }
        public int DersId { get; set; }
        public int NotId { get; set; }
        [Display(Name = "Ogrenci Adı : ")]
        public string OgrAd { get; set; }
        [Display(Name = "Ogrenci Soyadı : ")]
        public string OgrSoyad { get; set; }
    }
}
