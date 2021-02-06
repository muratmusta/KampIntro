using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");
            Console.Write("Öğrenci No Giriniz:");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch
            {
                Console.WriteLine("Öğrenci Bulunamadı.");
            }


            //Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            //Ogrenci.Add(134, "Tolga Demirer");
            //Ogrenci.Add(158, "Ümit Özkan");
            //Ogrenci.Add(115, "Kadir Aydemir");
            //Ogrenci.Add(174, "Cemal Çiftçi");

            //Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;

            //foreach (int Anahtar in AnahtarListesi)
            //    Console.WriteLine(Anahtar);
        }
    }
}
