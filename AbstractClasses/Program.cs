using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Kaydet();
            aMevzuat.Degerlendir();
            Console.ReadLine();

                
        }
    }

    abstract class MevzuatBase
    {
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi");

        }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatına göre değerlendirildi");
        }
    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatına göre değerlendirildi");
        }
    }
    class CustomerManager // Somut sınıf
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted");

        }
    }
    class Customer //property
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
