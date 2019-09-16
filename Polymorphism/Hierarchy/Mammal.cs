using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string name, string type, double weight, int foodEaten, string region) : base(name, type, weight, foodEaten)
        {
            _livingRegion = region;
        }
    }
}
