using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNewLab10
{
    class Program
    {
        static void Main(string[] args)
        {         
            bool run = true;          
            while (run)
            {                                         
                 Circle myCircle = new Circle(Validating.Valadate());
                 Console.WriteLine($"Circumfrance:{myCircle.CalculateFormattedCircumference()}");
                 Console.WriteLine($"Area: {myCircle.CalculateFormattedArea()}");
                run = Continue();
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("would you like to run this program agian (y/n)");
            string input = Console.ReadLine().ToLower();
            bool stuff;
            if (input == "y")
            {
                stuff = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye");
                stuff = false;
            }
            else
            {
                Console.WriteLine("Sorry I didn't catch that. Please try agian (y/n)");
                stuff = Continue();
            }

            return stuff;
        }

    }
}
