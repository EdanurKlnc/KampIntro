using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        { /*
            string[] isimler = new string[] { "Eda", "Engin", "Murat", "Nur" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; // 5 elemanlı tanımladığımız için Kerem 'ide ekrana yazar
            isimler[4] = "Kerem";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]); //15. satırda new dediğimiz için yeni bir adres yeri oluşturmuş oluruz. Yukardidakilerin adresleri farklı */

             // yukarıdakini List yöntemiylede yazabiliriz ;
            List<string> isimler2 = new List<string> { "Eda", "Engin", "Murat", "Nur" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
             

        }
    }
}
