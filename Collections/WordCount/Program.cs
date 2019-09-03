using System;
using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    class Program
    {
        private const string Path = "C:/Users/krist/csharp-basics-homework/Collections/WordCount/lear.txt";

        private static void Main(string[] args)
        {
            int linesCount = 0;
            int wordCount = 0;
            int charCount = 0;
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                //Console.WriteLine(s);
                linesCount++;
            }

            
            var text = File.ReadAllText(Path);
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '?', '!'};
            string[] words = text.Split(delimiterChars);
            foreach (var w in words)
            {

                wordCount++;
            }
            char[] spaces = { ' ' };

            foreach (var c in text)
            {
                charCount++;
                
            }

            Console.WriteLine(linesCount);
            Console.WriteLine(wordCount);
            Console.WriteLine(charCount);

            Console.ReadKey();
        }
    }
}