using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacManager = new IhtiyacKrediManager();
            //ihtiyacManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //*** Bunun yerine IKrediManager diyerek aynı sonucu aldık.***

            //******* !!! DEMEK Kİ INTERFACE LER DE O INTERFACE' İ IMPLEMENTE EDEN CLASS' IN REFERANS NUMARASINI TUTABİLİYOR !!! *******


            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();         
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        
        }
    }
}
