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

            string[] wordsList = { "london", "washington", "paris", "sydney", "berlin", "riga" };

            Random random = new Random();
            string word = wordsList[random.Next(0, wordsList.Length)];
            
            

            
            
            string misses = "";
            char[] guess = new char[word.Length];
            int lives = 3;
            bool won = false;
            int letters = 0;


            for (int i = 0; i < word.Length; i++)
                guess[i] = '_';

            //do
            //{

            //} while (true);

            while (!won && lives > 0)
            {
                Console.Write("Word:  ");
                Console.WriteLine(guess);
                Console.WriteLine();
                Console.WriteLine("Misses: " + misses);
                Console.WriteLine();
                Console.Write("Guess: ");

                char playerGuess = char.Parse(Console.ReadLine());
                

                if (word.Contains(playerGuess))
                {

                    for (int j = 0; j < word.Length; j++)
                    {
                        if (playerGuess == word[j])
                        {
                            guess[j] = playerGuess;
                            letters++;
                            //found = true;

                        }
                    }

                    if (letters == word.Length)
                    {
                        won = true;
                    }
                }
                else
                {
                    misses += playerGuess;
                    lives--;
                }

               

            }
            if (won)
            {
                Console.WriteLine("YOU GOT IT!");
            }
            else
            {
                Console.WriteLine("You lost! It was " + word);
            }
            Console.ReadKey();
        }
    }
}
