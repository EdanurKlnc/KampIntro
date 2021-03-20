using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager

    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad +" "+ musteri.Soyad + " " + "Eklendi!");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad +" " +musteri.Soyad + " " + "Silindi!");

        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı:" + musteri.Ad + " " + "Müşteri Soyadı: " + musteri.Soyad + " "+ "Müşteri Yas: " + musteri.Yas);

            }


        }
    }
}
