using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //İMZANIN AYNI OLDUĞU AMA İÇERİSİNİN FARKLI OLDUĞU DURUMLARDA BİZ, AŞAĞIDAKİ BASE DE OLUŞTURDUĞUMUZ CLASS' I, CLASS OLARAK DEĞİL DE INTERFACE OLARAK OLUŞTURURUZ.
    interface IKrediManager //Base  - Ebeveny görevi görüyor.
        //interface, arayüz demek, benim şablonum görevimi görüyor.

        //interface şunu anlatır : eğer ki birisi (interface IKrediManager) bu interface'i kullanırsa o arkadaş void ile yazdığımız methot' u içermek zorundadır.

    {
        void Hesapla(); //imza // Benim için interface
        void BiseyYap();
       
    }
}


//Hesapla vs. bunlar bankadaki her kredide olması gereken methotlar. Bunu zorunlu yapıyoruz. Bu yüzden yeni kredi oluşturulacağı zaman mutlaka bu interface den imlemente olduğu için bu void ' leri içermek zorunda.

//IKrediManager bir interface, onu implemente eden interface ' lere implemention (implementasyon) deniyor.