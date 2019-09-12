using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5___PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            String userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            char[] charInput = userInput.ToCharArray();
            for (int i = 0; i < charInput.Length; i++)
            {
                if (charInput[i] == 'a' || charInput[i] == 'b' || charInput[i] == 'c')
                {
                    Console.Write(2);
                    continue;
                }
                else if (charInput[i] == 'a' || charInput[i] == 'b' || charInput[i] == 'c')
                {
                    Console.Write(3);
                    continue;
                }
                if (charInput[i] == 'd' || charInput[i] == 'e' || charInput[i] == 'f')
                {
                    Console.Write(4);
                    continue;
                }
                if (charInput[i] == 'g' || charInput[i] == 'h' || charInput[i] == 'i')
                {
                    Console.Write(5);
                    continue;
                }
                if (charInput[i] == 'j' || charInput[i] == 'k' || charInput[i] == 'l')
                {
                    Console.Write(6);
                    continue;
                }
                if (charInput[i] == 'm' || charInput[i] == 'n' || charInput[i] == 'o')
                {
                    Console.Write(7);
                    continue;
                }
                if (charInput[i] == 'p' || charInput[i] == 'q' || charInput[i] == 'r' || charInput[i] == 's')
                {
                    Console.Write(8);
                    continue;
                }
                if (charInput[i] == 'w' || charInput[i] == 'x' || charInput[i] == 'y' || charInput[i] == 'z')
                {
                    Console.Write(9);
                    continue;
                }
            }
           /* switch (charInput)
            {
             
            }

            Console.ReadKey();*/

        }
    }
}
