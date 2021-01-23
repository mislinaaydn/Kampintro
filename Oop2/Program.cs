using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mislina";
            musteri1.Soyadi = "AYDIN";
            musteri1.TcNo = "12345678901";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;  
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "KODLAMA.İO";
            musteri2.VergiNo = "12345678900";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            // new bellekte bir referans no

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
