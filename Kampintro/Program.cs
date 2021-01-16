using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args){
            //type safety - tip güvenliği 
            // do  not repeat yourself - kendini tekrar etme
           
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı= 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else { 
            }
            Console.WriteLine("değişmedi butonu");
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            


        }
    }
}
