using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            //int cars, drivers, passengers, carsNotDriven, cars_driven;
            //double seatsInACar, carpool_capacity, average_passengers_per_car;

            int cars = 100; //cars
            int seatsInACar = 4; //seats in a car
            int drivers = 28; // drivers
            int passengers = 93; // passengers
            int carsNotDriven = cars - drivers; // free cars
            int carsDriven = drivers; // cars driven at the moment
            int carpool_capacity = carsDriven * seatsInACar; // carpool capacity
            double averagePassengersPerCar = (double)passengers / (double)carsDriven; // average passengers per car

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + string.Format("{0:F2}", averagePassengersPerCar)  + " in each car.");
            Console.ReadKey();
        }
    }
}