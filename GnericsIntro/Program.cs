using System;

namespace GnericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Murat");

            Console.WriteLine("Hello World!");
        }
    }
}
