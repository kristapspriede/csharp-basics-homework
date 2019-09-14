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
            int val = 7;
            for (int i = 0; i < val; i++)
            {
                for (int j = 1; j <= (val - 1 - i) * 4; j++)
                {
                    Console.Write("/");
                }
                
                for (int k = 1; k <= i * 4; k++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= i * 4; k++)
                {
                    Console.Write("*");
                }
                for (int j = 1; j <= (val - 1 - i) * 4; j++)
                {
                    Console.Write("\\");
                }


                Console.WriteLine();

            }

            Console.ReadKey();
        }

        
    }
}
