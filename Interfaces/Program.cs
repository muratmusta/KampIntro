using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface new'lenemez!
            //interface leri şablon oluşturmak için kullanıyoruz.
            //interface ler onu implemente eden class' ın referans numarasını tutabilirler.


            //IPersonManager customerManager = new CustomerManager();
            //IPersonManager employeeManager = new EmployeeManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }


        //interface lerde buradaki person da üyeler bırakabiliyorduk. Ama interface lerder üyeler oluyor ama üyelerin içi boi oluyor.


        interface IPersonManager

        {
            //implemented operation yani tamamlanmış operasyon, yani implemente edilmiş, içi doldurulmuş operasyon demek oluyor.
            //unimplemented operation
            //interface üyeleri, dışarıdan erişilebilir olmalıdır.  O yüzden public yazamayız.
            void Add(); //imza
            void Update();
        
        }

        //Eğer class olsaydı inherits...... implements - interface
        class CustomerManager : IPersonManager

        {
            public void Add()
            {
                //Müşteri ekleme kodları yazılır.
                Console.WriteLine("Müşteri eklendi");
            }
            public void Update()
            {
                //Müşteri ekleme kodları yazılır.
                Console.WriteLine("Müşteri güncellendi");
            }
        }

        class EmployeeManager : IPersonManager

        {
            public void Add()
            {
                //personel ekleme kodları yazılır.
                Console.WriteLine("Personel eklendi");
            }
            public void Update()
            {
                //Müşteri ekleme kodları yazılır.
                Console.WriteLine("Personel güncellendi");
            }

        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {

            Console.WriteLine("Stajyer eklendi");

        }

        public void Update()
        {

            Console.WriteLine("Stajyer güncellendi");

        }

    }


    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        
        {
            personManager.Add();
        }
    }
    
}
