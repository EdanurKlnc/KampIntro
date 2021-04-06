using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Musteri musteri1 = new Musteri();
                 musteri1.Adi = " engin";
                 musteri1.Soyadi = "Demiroğ";
                 musteri1.Id = 1;
                 musteri1.TcNo = "333333";
                 musteri1.MusteriNo = "111";
                 musteri1.SirketAdi = "?";  */ //SOLID 

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin ";
            musteri1.Soyadi = "Demiroğ ";
            musteri1.TcNo = "1235";
            

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama io ";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2); 
                
            // mola







           

        }
    }
}
