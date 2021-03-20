using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "eda";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 55;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenmeOrani = 90;


            Console.WriteLine(kurs1.KursAdi +" " +kurs1.Egitmen);
            Console.WriteLine(kurs2.KursAdi + " " + kurs2.Egitmen);
            Console.WriteLine(kurs3.KursAdi + " " + kurs3.Egitmen);

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}