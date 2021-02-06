using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encaosulation
        public void Add(Product product) //101

        {
            Console.WriteLine(product.ProductName + " Eklendi");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "Güncellendi");
        }

   

    }

   
}
