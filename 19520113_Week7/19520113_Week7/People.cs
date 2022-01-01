using System;
using System.Collections.Generic;
using System.Text;

namespace _19520113_Week7
{
    class People
    {
        private string name { get; set; }
        private int age { get; set; }
        private string country { get; set; }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }


        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public string Country
        {
            set { country = value; }
            get { return country; }
        }

        public People(string name, int age, string country)
        {

            this.name = name;
            this.age = age;
            this.country = country;
        }
        public People() { }
    }
}
