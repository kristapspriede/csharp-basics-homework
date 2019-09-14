using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat : Felime
    {
        private string _breed;
        public Cat(string name, string type, double weight, int foodEaten, string region, string breed) : base(name, type, weight, foodEaten, region)
        {
            _breed = breed;
        }
    }
}
