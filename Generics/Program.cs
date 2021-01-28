using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ANKARA");
            sehirler.Add("SİVAS");
            sehirler.Add("KAYSERİ");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("ANKARA");
            sehirler2.Add("SİVAS");
            sehirler2.Add("KAYSERİ");
            sehirler2.Add("KONYA");
            sehirler2.Add("BURSA");
            sehirler2.Add("ADIYAMAN");
            Console.WriteLine(sehirler2.Count);
        }
    }
    class MyList<T> //Generics class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];

        }
        public void Add (T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
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
