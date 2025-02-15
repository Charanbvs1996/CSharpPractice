using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPSPractice
{
    internal class Shape
    {
        public virtual void CalculateArea(){}       
        public double GetUserInput(string input)
        {

            while (true)
            {
                Console.WriteLine(input);
                string? value = Console.ReadLine();
                if (double.TryParse(value, out double val))
                {
                    return val;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
    internal class Circle : Shape
    {
        public override void CalculateArea()
        {
            double radius = GetUserInput("For what radius you want to calculate the area of circle?");
            double Area = Math.PI * radius * radius;
            Console.WriteLine($"Area of the circle is: {Math.Round(Area, 3)}");
        }
    }
    internal class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            double length = GetUserInput("Enter length for which you want to calculate the area of Rectangle?");
            double breadth = GetUserInput("Enter breadth for which you want to calculate the area of Rectangle?");
            double Area = length * breadth;
            Console.WriteLine($"Area of the rectangle is: {Math.Round(Area, 3)}");
        }
    }
}



/*Shape provides shared functionality.
Circle and Rectangle provide shape-specific behavior by overriding CalculateArea.
The abstract class helps adhere to the DRY principle (Don't Repeat Yourself).*/