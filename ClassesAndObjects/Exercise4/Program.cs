using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        public static void GetPG(Movie[] movieArray)
        {


            for (int i = 0; i < movieArray.Length; i++)
            {
                if (movieArray[i]._rating == "PG")
                    Console.WriteLine(movieArray[i].movie());
            }
            
        }
        static void Main(string[] args)
        {
            Movie [] movieArray = new Movie[3];

            movieArray[0] = new Movie("Casino Royale", "Eon Productions", "PG13");
            //Console.WriteLine(movieArray[0].movie());
            Console.WriteLine(movieArray[0].movie());

            movieArray[1] = new Movie("Glass", "Buena Vista International", "PG13");
            //Console.WriteLine(movie2.movie());
            Console.WriteLine(movieArray[1].movie());

            movieArray[2] = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
            //Console.WriteLine(movie3.movie());
            Console.WriteLine(movieArray[2].movie());

            //foreach (var i in movieArray)
            //{
            //    Console.WriteLine(i.movie());
            //}

            Console.WriteLine();

            GetPG(movieArray);

            
                
            Console.ReadKey();
        }

        
    }
    
}
