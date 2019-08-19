using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8___AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 3;
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < (val - 1) * (val - i - 1); j++)
                {
                    Console.Write("/");
                }
                
                for (int k = 0; k <= i * 4 - 1; k++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k <= i * 4 - 1; k++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < (val - 1) * (val - i - 1); j++)
                {
                    Console.Write("\\");
                }


                Console.WriteLine();

            }

            Console.ReadKey();
        }

        
    }
}
