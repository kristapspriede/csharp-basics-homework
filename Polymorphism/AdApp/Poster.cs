using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    class Poster : Advert
    {
        private int _height;
        private int _width;
        private int _rate;
        private int _copies;
        public Poster(int fee, int height, int width, int rate, int copies) : base(fee)
        {
        _height = height;
        _width = width;
        _rate = rate;
        _copies = copies;
    }
        private new int Cost()
        {
            var fee = base.Cost();
            return fee + _rate * _height * _width * _copies;
        }
        public override string ToString()
        {
            return base.ToString()
                   + " Poster ad: poster width = " + _width
                   + " poster height = " + _height
                   +" copies = " + _height
                    + " rate = " + _rate;
        }
    }

}
