using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Yöntem Customer customer = new Customer();
            //2. Yöntem
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara"); //Parametre

            //normal parantez gördüğümüz de, C# ve Java da Metot mantığı var demektir.

            Console.WriteLine(customer2.FirstName);
        }

      
    }

    class Customer 
    
    {
        //Yukarıdaki iki kullanım için bunu yapıyoruz. Parametre vermediğimiz için..
        public Customer() 
        
        { 
            
        }
        //default constructor
        //Ayrıca Constructor yazdığımızda, default Constructor'u ezmiş oluyoruz.
        
        public Customer(int id, string firstName, string lastName, string city) 
        
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

            
            //Method parametreleri camelcase yazılır.
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
