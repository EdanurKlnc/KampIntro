using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitePrice = 500;
            product1.UnitInStock = 3;

            //Yukarıdakini aşağıdaki şeklinde de yazabiliriz . 2 yazım şeklide doğru

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "kalem", UnitePrice = 400, UnitInStock = 36 };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

        }
    }
}
