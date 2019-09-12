using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercse6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 110;
            for (a = 1; a <= b; a++)
            {
                
                if (a % 11 == 0)
                {
                    Console.WriteLine(a + "\r\n");
                }
                 else if (a % 5 == 0 && a % 7 == 0 && a % 3 == 0)
                {
                    Console.Write("CozaLozaWoza ");
                }
                else if (a % 5 == 0 && a % 7 == 0)
                {
                    Console.Write("LozaWoza ");
                }
                else if (a % 3 == 0 && a % 7 == 0)
                {
                    Console.Write("CozaWoza ");
                }
                else if (a % 3 == 0 && a % 5 == 0)
                {
                    Console.Write("CozaLoza ");
                }
                else if (a % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else if (a % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if (a % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else
                {
                    Console.Write(a + " ");
                }



            }
            

            Console.ReadLine();
        }

    }
}
