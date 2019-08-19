using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercis6
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput1 = 0;
            int userInput2 = 0;
            int userInput3 = 0;
            Console.WriteLine("Enter single digit number!");
            userInput1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second single digit numbers!");
            userInput2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ok, last one!");
            userInput3 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sum of digits is " + (userInput1 + userInput2 + userInput3) + "!");
            Console.ReadKey();

        }
    }
}
