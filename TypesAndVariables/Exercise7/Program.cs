using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInput;
            int letterCount = 0;
            Console.WriteLine("Enter any name:");
            userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
                if (char.IsUpper(userInput[i]))
            {
                letterCount++;
            }

            Console.WriteLine("Uppercase letters: " + letterCount);
            Console.ReadKey();
        }
    }
}
