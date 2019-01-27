using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNewLab10
{
    class Circle
    {
        private double radius;
        public const double PI = Math.PI;//Pi constant

        public Circle(double radius) //constructor for the radius
        {
            this.radius = radius;
        }

        public double CalculatedCircumference()//calculat circumference method
        {
            double circumference = PI * (radius * 2);
            return circumference;
        }

        private string FormatNumber(double x) //formating method
        {
            return $"{x,0:N2}";
        }

        public string CalculateFormattedCircumference()//call the Format method and put the circumference method into 
        {
            return FormatNumber(CalculatedCircumference());
        }

        public double CalculatedArea()//area method
        {
            double area = PI * (radius * radius);
            return area;
        }

        public string CalculateFormattedArea()//formating the area using the same method as befor
        {
            return FormatNumber(CalculatedArea());
        }
    }
}
