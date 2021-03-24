using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("istanbul");
            sehirler.Add("Ankara"); // Listeye yeni bir şey ekleme
            sehirler.Add("Bartın");
            sehirler.Add("Malatya");
            sehirler.Add("Zonguldak");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("istanbul");
            sehirler2.Add("Ankara");
            sehirler2.Add("Bartın");
            sehirler2.Add("Malatya");
            Console.WriteLine(sehirler2.Count);
           
        }
    }

    class MyList<T> // Generics class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array; // Alttaki new lemeden sonra yerler kaybolmasın diye tutucu bir yer veriyoruz
             _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length ; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item; 
        }
        public int Count
        {
            get { return _array.Length; }
        }
    }

   }


