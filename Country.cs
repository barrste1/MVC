using System;
using System.Collections.Generic;
using System.Text;

namespace _08062020_MCV_Lab
{
    class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<ConsoleColor> Colors { get; set; }

        public Country()
        {

        }
        public Country(string name,Continent continent,List<ConsoleColor> colors)
        {
            name = Name; continent = Continent; colors = Colors;
        }

    }
}
