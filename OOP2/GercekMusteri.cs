using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    // iki nokta üst üste den sonra eklediğimiz durum için; miras / inheritance denilir.

    class GercekMusteri : Musteri // GercekMusteri, sen bir musteri sin demiş oluyoruz.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
