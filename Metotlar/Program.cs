using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {/*
            string urunadi = "Elma";
            double fiyatı = 15;
            string aciklama = " Amasya elması";
            // 3 şekilde yazacağımıza 2ü zaten bir ürün elde ettiği için sınıf içerisnde yazacağız
            

            Urun urun1 = new Urun();
            urun1.Adi = " Elma ";
            urun1.Fiyatı = 15;
            urun1.Aciklama = " Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = " Karpuz";
            urun2.Fiyatı = 10;
            urun2.Aciklama = " Diyarbakır karpuzu"; */

            Urun[] urunler = new Urun[] { urun1 , urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
            } 
            Console.WriteLine("-----------Metotlar-------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);



            sepetManager.Ekle2("Armut", "yeşil", 12, 20);
            sepetManager.Ekle2("elma", "eşil elma", 15, 22);




        }
    }
}



 // Do not repest yourself f