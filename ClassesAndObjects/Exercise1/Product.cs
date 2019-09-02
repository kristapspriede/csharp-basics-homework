using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Product
    {
        private string _name;
        private double _price;
        private int _amount;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine(_name + ", price " + _price + ", amount " + _amount);
        }

        public int changeQuantity(int amount)
        {
            return _amount = amount;
        }

        public double changePrice(double price)
        {
            return _price = price;
        }

    }
}
