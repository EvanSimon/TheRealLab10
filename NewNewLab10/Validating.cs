using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNewLab10
{
    class Validating
    {
         public static double Valadate()//Validate method inside the the Validating
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter radius");
                    double UserInput = double.Parse(Console.ReadLine());
                    return UserInput;
                }

                catch (FormatException)
                {
                    Console.WriteLine("That was not a number. Please enter a number");
                   
                }
            }
        }
    }
}
