using System;

namespace GnericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Murat");

            Console.WriteLine(isimler.Length);

            isimler.Add("Defne");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

            //Turkuaz renk olanlar class.
            //Generic lerle hangi tipi verirseniz, içindeki operasyonlar, add gibi parametre olarak o tipte çalışıyor.

        }
    }
}
