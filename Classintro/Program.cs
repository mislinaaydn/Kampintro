using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;
            
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin demiroğ";
            kurs1.İzlenmeOranı = 68;
           
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "engin";
            kurs2.İzlenmeOranı = 6;
           
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = " demiroğ";
            kurs3.İzlenmeOranı = 80;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[]{ kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ ":" +kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOranı{ get; set; }


    }
}
