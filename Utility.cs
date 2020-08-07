using System;
using System.Collections.Generic;
using System.Text;

namespace _08062020_MCV_Lab
{
    class Utility
    {

        public static string GetUserInput(string message)
        {
            string input = "";
            PrintGreen(message);
            input = Console.ReadLine();

            return input;
        }
        public static void PrintGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }
    }

}
