using System;

namespace Constructors // Class'ı new'lediğimiz zaman çalışan kısım
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Eda", LastName = "Kılınç", City = " İstanbul" }; //1. kullanım şekli
            Customer customer2 = new Customer(2, "Derin", "Kılınç", "İstanbul"); // 2, kullanım şekli .Normal () kullanımında metot kullanılmış gibi.
            Console.WriteLine(customer2.FirstName);

             

        }
    }

    class Customer
    {
        public Customer() //customer1'in çalışması için gerekli
            {
          
        }
        public Customer(int İd ,string firstName, string lastName,string city) // Metot gibi çalışır. Customer2 çalışması için () içinde in vb gibi tanımlamak lazım.
        {
            Console.WriteLine("Yapıcı blok çalıştır");
            Id = İd;    
            FirstName = firstName;// Customer2 dekileri ekrana yazdırmak için tek tek tanımlıyoruz.Sadece ismi yazdıracak cünkü yukarda sadece isim için komut verdik.
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
