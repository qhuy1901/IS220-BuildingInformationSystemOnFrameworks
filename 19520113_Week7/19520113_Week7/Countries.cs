using System;
using System.Collections.Generic;
using System.Text;

namespace _19520113_Week7
{
    class Countries
    {
        private string country { get; set; }
        private string countryName { get; set; }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        public Countries() { }
    }
}
