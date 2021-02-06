using System;

namespace GnericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Murat");

            //Turkuaz renk olanlar class.
            //Generic lerle hangi tipi verirseniz, içindeki operasyonlar, add gibi parametre olarak o tipte çalışıyor.
            
        }
    }
}
