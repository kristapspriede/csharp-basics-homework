using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        private string _title;
        private string _studio;
        public string _rating;

        

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;

        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public string movie()
        {
            //return "\"" + _title + "\"" + ", the studio " + "\"" + _studio + "\"" + " and the rating \"" + _rating + "\"";
            return _title + ", " + _studio + ", " + _rating;
        }

        
        




    }
}
