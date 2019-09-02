using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog(string name, string sex, string mother, string father)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public string fathersName()
        {
            //return _father;
            if (_father == "")
            {
                return "Unknown";
            }
            else
            {
                return _father;
            }
        }

        public bool HasSameMotherAs(Dog dog1, Dog dog2)
        {
            if (dog1._mother == dog2._mother)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
