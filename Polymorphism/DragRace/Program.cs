using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DragRace
{
    class Program
    { 
        /**
         * Take a look at the cars in this solution.
         * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
         * Which methods will be extracted with an empty body, and which can be default?
         * 2. Create two more cars of your own choice.
         * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
                  and add that behaviour in one more car.
         * 4. Create one instance of an each car and add them to list.
         * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
         * 6. Print out the car name and speed of the fastest car
         */

        private static void Main(string[] args)
        {
            var carList = new List<ICar>
            {
                new Audi(), new Bmw(), new Lexus(),
                new Tesla(), new Volvo(), new Audi(),
                new Bmw(), new Lexus(), new Tesla(),
                new Volvo()
            };


            for (int i = 0; i < 11; i++)
            {
               
                for (int j = 0; j < carList.Count; j++)
                {

                   
                    if (j == 2) //pārbauda nitro
                    {
                        if (j == 0)
                        {
                            carList[j].StartEngine();
                        }
                        if (carList[j] is IModifiedCar)
                        {
                            
                            ((IModifiedCar) carList[j]).UseNitrousOxideEngine();

                        } 
                    }
                    else
                    {
                        carList[j].SpeedUp();
                    }
                }
            }
            //fastest car name + speed

            carList = carList.OrderByDescending(c => int.Parse(c.ShowCurrentSpeed())).ToList();
            Console.WriteLine($"{carList.First().Name()}{carList.First().ShowCurrentSpeed()}");

            Console.WriteLine("other cars");
            carList.ForEach(c => Console.WriteLine($"{c.Name()} {c.ShowCurrentSpeed()}"));
            Console.ReadKey();


        }
    }
}