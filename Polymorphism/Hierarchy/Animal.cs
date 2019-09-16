using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public Animal(string name, string type, double weight, int foodEaten)
        {
            _animalName = name;
            _animalType = type;
            _animalWeight = weight;
            _foodEaten = foodEaten;
        }

        void makeSound()
        {

        }

        void eat()
        {

        }
       

    }   

}
