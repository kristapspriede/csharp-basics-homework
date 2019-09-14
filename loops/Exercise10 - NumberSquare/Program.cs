using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10___NumberSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min?");
            var min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max?");
            var max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = min; i <= max; i++) {
                
                for (int j = i; j <= max; j++)
                {
                    Console.Write(j + " ");
                }
                for (int k = min; k <= i - 1; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();

            }
            Console.ReadKey();
        }
        
    }
}
