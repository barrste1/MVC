using System;
using System.Collections.Generic;
using System.Text;

namespace _08062020_MCV_Lab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country displaycountry)
        {
            DisplayCountry = displaycountry;
        }
        public void Display()
        {
            Utility.PrintGreen($"Country: \t{DisplayCountry.Name}\n");
            Utility.PrintGreen($"Continent: \t{DisplayCountry.Continent}\n");
            
            Utility.PrintGreen($"Country Colors: ");
            for (int i =0; i<DisplayCountry.Colors.Count;i++)
            {
                Console.ForegroundColor = DisplayCountry.Colors[i]; 
                Console.WriteLine($"\t{DisplayCountry.Colors[i]}");
                Console.ResetColor();
            }


        }

    }
}
