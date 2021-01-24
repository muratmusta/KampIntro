using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi, Tekrikler  :  " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdeti) 
        {
            Console.WriteLine("Sepete Eklendi, Tekrikler  :  " + urunAdi);

        }
    }
}
