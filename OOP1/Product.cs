using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product // Entity gibi isimler veririz
    {
        public int Id { get; set; }

        public int CategoryId { get; set; } // Ürünün hangi kategoriye ait olduğu

        public string ProductName  { get; set; } //Ürün ismi

        public double UnitePrice { get; set; }

        public int UnitInStock { get; set; } // Ürünn stok adedi

        //CRUD  (eklemek, okumak, güncellemek, silmek)
    
    
    }
}
