using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _08062020_MCV_Lab
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }
        public CountryController(List<Country> countryDb)
        {
            countryDb = CountryDb;
        }
        public void CountryAction(Country c)
        {
            new CountryView(c).Display();

        }
        public void WelcomeAction()
        {
            bool end = false;
            while (!end)
            {
                int input = -1;
                new CountryListView(CountryDb);
                Console.WriteLine("Hello, Welcome to the Country App! ");
                new CountryListView(CountryDb).Display();
                while (input<0||input>CountryDb.Count)
                {
                    try
                    {
                        input = int.Parse(Utility.GetUserInput($"Which Country would you like to learn about? Please input the associated index number (1-{CountryDb.Count})."));
                    }
                    catch
                    {
                        Utility.PrintGreen("Invalid input.");
                    }
                }
                CountryAction(CountryDb[input]);

            }


        }

    }
}
