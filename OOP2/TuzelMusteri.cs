using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    // iki nokta üst üste den sonra eklediğimiz durum için; miras / inheritance denilir.

    class TuzelMusteri :Musteri // TuzelMusteri, sen bir musteri sin demiş oluyoruz.
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
