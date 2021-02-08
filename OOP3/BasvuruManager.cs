using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)

        {
            //Başvuran bilgilerini değerlendirme
            //Şuan tüm başvuruları Konut Kredisine bağımlı hale getirdin ve onun üzerinden hesaplanır!
            //Programcılık hayatının kırılma noktası olabilir !!!
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Bunun yerine, başvuru yaparken bir parametre alsam, bu başvuruyu hangi krediye göre yapmam gerektiğini bana söyle desem, IKrediManager krediManager yapmalıyız.

            krediManager.Hesapla();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
