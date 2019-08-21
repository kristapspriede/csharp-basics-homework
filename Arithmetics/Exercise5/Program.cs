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
            
            Random random = new Random();
            int ranNum = random.Next(1, 100);
            int userGuess = 0;

           
            while (userGuess != ranNum)
            {
                Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > ranNum)
                {
                    Console.WriteLine("Sorry, you are too high.  I was thinking of " + ranNum + ".");
                break;
            }
                else if (userGuess < ranNum)
                {
                    Console.WriteLine("Sorry, you are too low.  I was thinking of " + ranNum + ".");
                    break;
            }
                else
                {
                    Console.WriteLine("You guessed it!  What are the odds?!?");
                    break;
                }
           }
            Console.ReadLine();
        }

    }
}
