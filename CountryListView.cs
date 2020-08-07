using System;
using System.Collections.Generic;
using System.Text;

namespace _08062020_MCV_Lab
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }
        public CountryListView()
        {


        }
        public CountryListView(List<Country> countries)
        {
            countries = Countries;
        }
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
                Utility.PrintGreen($"{i + 1}. {Countries[i]}\n");
        }

    }
}
