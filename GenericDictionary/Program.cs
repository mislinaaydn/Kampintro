using System;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDictionary<byte, string> plakaSehir = new MyGenericDictionary<byte, string>();
            plakaSehir.Add(34, "İstanbul");
            plakaSehir.Add(35, "İzmir");
            plakaSehir.Add(52, "Ordu");
            plakaSehir.Add(63, "Şanlıurfa");
            plakaSehir.Add(77, "Yalova");

            Console.WriteLine("Plaka No: " + plakaSehir.Items1[0] + " " + "Şehir: " + plakaSehir.Items2[0]);
            Console.WriteLine("Plaka No: " + plakaSehir.Items1[1] + " " + "Şehir: " + plakaSehir.Items2[1]);
            Console.WriteLine("Plaka No: " + plakaSehir.Items1[2] + " " + "Şehir: " + plakaSehir.Items2[2]);
            Console.WriteLine("Plaka No: " + plakaSehir.Items1[3] + " " + "Şehir: " + plakaSehir.Items2[3]);
            Console.WriteLine("Plaka No: " + plakaSehir.Items1[4] + " " + "Şehir: " + plakaSehir.Items2[4]);

        }
    }
}