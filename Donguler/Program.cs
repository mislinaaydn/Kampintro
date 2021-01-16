using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args) { 

        string kurs1 = "Yazılım geliştirme kampı";
        string kurs2 = "Programlamaya giriş için temel kurs ";
        string kurs3 = "Java";
        string kurs4 = "Python";


            Console.WriteLine("kurs1");
            Console.WriteLine("kurs2");
            Console.WriteLine("kurs3");
            Console.WriteLine("kurs4");


            //array = dizi .

            string[] kurslar = new string[] { "Yazılım geliştirme kampı", 
                "Programlamaya giriş için temel kurs " ,
                "Java","Python"};
           
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)//foreach dizileri tek tek dolaşmada kullanılır.
            //dizilerde kullanılır.

            {
                Console.WriteLine();
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
