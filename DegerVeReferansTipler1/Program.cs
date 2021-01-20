using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 20;
            int sayi2 = 50;
            sayi1 = sayi2;
            sayi2 = 45;
            //sayi1 ?? 50

            int[] sayilar1 = new int[] { 100, 200, 300 };
            int[] sayilar2 = new int[] { 1000, 2000, 3000 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] 999



        }
    }
}
