using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Logitech mouse", 70.00, 14);
            product1.PrintProduct();
            Product product2 = new Product("iPhone 5s", 999.99, 3);
            product2.PrintProduct();
            Product product3 = new Product("Epson EB-U05", 440.46, 1);
            product3.PrintProduct();


            Console.ReadKey();
        }
    }
}   
