using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {


            //type safety - tip güvenliği
            //Do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias
            //double ile ondalıklı sayıları tutuyoruz.

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000; //tamsayıları tutar
            double faizOrani = 1.45; //ondalıklı sayıları tutarız
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalık butonu");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");

            }

            else
            {
                Console.WriteLine("Değişmedi butonu");

            }














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
