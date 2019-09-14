using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9___RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Desired sum:");
            Random random = new Random();
            var input = Convert.ToInt32(Console.ReadLine());

            do
            {
                int dice = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                sum = dice + dice2;
                Console.WriteLine(dice + " and " + dice2 + " = " + sum);
                Console.ReadKey();
                continue;
            } while (sum != input);

            Console.ReadKey();
        }
    }
}
