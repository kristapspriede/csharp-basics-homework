using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word: ");
            var input1 = Console.ReadLine();
            Console.WriteLine("Enter second word: ");
            var input2 = Console.ReadLine();


            int dots = 30 - (input1.Length + input2.Length);
            //Console.Write(input1);
            //for (var i = 0; i < dots; i++)
            //{
            //    Console.Write(".");
            //}
            //Console.Write(input1);
            Console.WriteLine(input1+ new String('.', dots) +input2);
            Console.ReadKey();
        }
    }
}
