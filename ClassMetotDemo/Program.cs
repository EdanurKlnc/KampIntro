using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Edanur";
            musteri1.Soyad = "Kılınç";
            musteri1.Yas = 23;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = " Engin";
            musteri2.Soyad = "Demiroğ";
            musteri2.Yas = 30;

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

        }
    }
}
