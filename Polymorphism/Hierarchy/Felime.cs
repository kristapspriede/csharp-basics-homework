using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Felime : Mammal
    {
        public Felime(string name, string type, double weight, int foodEaten, string region) : base(name, type, weight, foodEaten, region)
        {
            
        }
    }
}
