using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(134, "Engin Demiroğ");
            Ogrenci.Add(158, "Kerem Varış");
            Ogrenci.Add(115, "Murt Kurtboğan");
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


        }
    }
}
