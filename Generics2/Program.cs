using System;
using System.Collections.Generic;

namespace Generics2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            isimler.Add("Engin");
            isimler.Add("Engin");
            isimler.Add("Engin");
            isimler.Add("Engin");
            Console.WriteLine(isimler.Count);

            MyList<string> isimler2 = new MyList<string>();
            isimler2.Add("Ahmet");
            isimler2.Add("Ahmet");
            isimler2.Add("Ahmet");
            isimler2.Add("Ahmet");
            isimler2.Add("Ahmet");
            isimler2.Add("Ahmet");
            Console.WriteLine(isimler2.Count);

        }

        class MyList<T>
        {
            T[] _items; //Create Array
            T[] _tempArray; //Create temp Array
            public MyList() //Set advanced Contructor
            {
                _items = new T[0]; //Set Array
            }

            public void Add(T item) //Add item to Array
            {
                _tempArray = _items; //Set tempArray values from _items
                _items = new T[_tempArray.Length + 1]; //_items length now +1 but all data cleared

                for (int i = 0; i < _tempArray.Length; i++) //Create loop for give back data
                {
                    _items[i] = _tempArray[i]; //Now give back data
                }
                _items[_items.Length - 1] = item; //Add new item

            }

            public int Count
            {
                get { return _items.Length; }
            }
        }
    }
}
