using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = "kristaps";
            var chars = word.ToCharArray();
            char[] misses = new char[3];
            int missesCount = 0;


            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine("Word: ");
            Console.WriteLine();
            Console.WriteLine("Misses: " + missesCount);
            Console.WriteLine();
            Console.WriteLine("Guess: ");
            char input = (char)Console.Read();

                if (input == chars[i])
                {
                    Console.WriteLine(chars[i]);
                    
                }
                if (input != chars[i])
                {
                    missesCount++;
                }
               
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
