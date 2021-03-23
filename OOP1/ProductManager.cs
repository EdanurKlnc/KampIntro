using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // Ürünle igilli operasyonlar içerir
    {
        public void Add(Product product) // Eklemek
        {
            Console.WriteLine(product.ProductName + " Eklendi ");
         }
          public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi .") ;
        }




    }
}
