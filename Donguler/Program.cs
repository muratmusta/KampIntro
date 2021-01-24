using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";

            //dinamik bir listeleme yapmak için diziler/array kullanırız.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java","Python" };


                        //i sayaç, 0 den başla, 3 den küçük olduğu sürece bir bir arttır.
            //for (int i = 0; i<3; i++)
            // for (int i = 1; i <= 10; i+=2) şeklinde de yazabiliriz. iki iki arttır demek oluyor.

            //Yukarıda tanımladığımız string array için kullanılan döngü yapıları.
            // 1- For Döngüsü
            for(int i = 0; i<kurslar.Length; i++)

            {
                Console.WriteLine(kurslar[i]);

            }


            Console.WriteLine("-------------For bitti---------");


            //Yukarıda tanımladığımız string array için kullanılan döngü yapıları.
            // 2- Foreach Döngüsü
            foreach (string kurs in kurslar) //kurs: takma isim, allias
            {
                Console.WriteLine(kurs);


            }
            Console.WriteLine("Sayfa Sonu - Footer");

        }
    }
}
