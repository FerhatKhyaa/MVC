namespace AdonetCoreMVC2.Entities
{
    public class Islemler
    {
    }
    public class Ogrenciler
    {
        public int OgrId { get; set; }
        public string OgrAdSoyad { get; set; }
        public int OgrNotOrtalamasi { get; set; }
        public string OgrDurum { get; set; }
        public string OgrKulup { get; set; }
        public string OgrSehir { get; set; }
    }
    public class Ogretmenler
    {
        public int OgrtId { get; set; }
        public string OgrtAdSoyad { get; set; }
        public string OgrtBrans { get; set; }

    }
    public class Dersler
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public string DersOgretmeni { get; set; }

    }
}
