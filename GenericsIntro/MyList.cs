using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];  // 0 elemanlı Array oluşturduk
        }
        public void Add(T item)  // Yeni eleman ekleme
        {
            T[] tempArray = items; // Aşağıdaki kısımda /new kullanıcağımız için , adres yeri değişmesin diye
                                   //"gecici dizi" oluşturarak referansı birine tuturuyoruz

        
            items = new T[items.Length +1]; // Eleman sayısını 1 artırma 
            for (int i = 0; i < tempArray.Length; i++ )
            {
                items[i]=tempArray[i];
            }
            items[items.Length - 1] = item;
        }

     }
}
