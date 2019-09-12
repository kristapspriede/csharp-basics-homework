using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product1ToN(10));
            Console.ReadKey();
        }
        static int Product1ToN(int N)
        {
            int i, number = 1;
            for (i = 1; i <= N; i++)
            {
                number = number * i;
            }

            return number;
        }
    }
}
