using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Exercise7___Piglet
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            Console.WriteLine("Welcome to Piglet!");
            Random random = new Random();
            int dice = random.Next(1, 7);
            do
            {
                Console.WriteLine("You rolled " + dice);
                points += dice;
                Console.WriteLine("Roll again?");
                var userInput = Console.ReadLine();
                if (userInput == "yes")
                {
                    dice = random.Next(1, 7);
                    continue;
                }
                else
                {
                    Console.WriteLine("You got " + points + " points!");
                    break;
                }
            } while (dice != 1);

            Console.ReadKey();
        }
    }
}
