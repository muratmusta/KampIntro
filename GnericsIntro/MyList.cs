using System;
using System.Collections.Generic;
using System.Text;

namespace GnericsIntro
{
    class MyList<T>
    {
        T[] items;
        // constructor (ctor tab tab) bir methotdur. Newlediğimiz anda çalışan bloğa constractor denilir.
        //Bu klası new lersen MyList otomatik çalışıyor.
        //newlediğim anda array'i sıfırladık. Sıfır elemanlı olarak mewledik.
        public MyList()
        {
            items = new T[0];
        }

        // Artık yukarıdaki T türünde items dizime elaman eklemek için, 0 elamanlı olarak newlememiz gerekiyordu ve yaptık.
        public void Add(T item)
        {
            //Şimdi Add ile ekleyeiliriz. Ancak diziye elaman eklemek için önce elaman sayısını 1 arttırmak gerekiyor.
            //Diziye 1 eleman eklendiğinde, sonra eleman sayısını 1 arttırınca iki eleman olacak. Ancak newlediğimiz için değerler uçacak. Uçan aslında referance numarası uçuyor.
            //O yüzden referance numarasını birine tutturmam erekiyor.
            T[] tempArray = items; // T türünde geçici array oluşturuyoruz. Geçici dizinin referansı, items' in referansı anlamına geliyor.
            items = new T[items.Length + 1]; //items.Length dizinin eleman sayısını verir. önce burası çalışır. Eleman sayısını 1 arttır demek.
            for (int i = 0; i < tempArray.Length; i++) //tempArry'e emanet ettiğimiz elemanları geri çağırmak için for döngüsünü çalıştırıyoruz. tempArry'in bütün elemanlarını items' e atıyoruz.
            {            //sıfırdan başlayıp tempArray kadar gez.
                items[i] = tempArray[i]; //benim items'ımın i'nin ci elemanı, eşittir tempArray den gelen geçici olarak verdiğim  i'nin ci elemanıdır diyoruz. Yani emaneten verdiğim elemanları sırasıyla kendi üstüme alıyorum. yani items'a..
            }
            //for bittikten sonra, items'ın son elemanı, yani uzunluğunun (length) - 1. değeri. Örneğin 6 elamanlı ise, 6-1 5. index. çünkü sıfırdan başlıyor. 
            // artık items eski değerlerine geri kavuştu.
            items[items.Length - 1] = item;
        }

        public int Length 
        
        {
            get { return items.Length; }
        }

        public T[] Items

        {
            get { return items; }
        }

    }
}
