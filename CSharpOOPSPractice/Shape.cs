using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPSPractice
{
    abstract class Shape
    {
        public abstract void CalculateArea();
        public abstract string ShapeName { get; } //when declared abstarct, it must be implemented in derived class
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
        public override string ShapeName => "Circle";
        public override void CalculateArea()
        {
            double radius = GetUserInput("For what radius you want to calculate the area of circle?");
            double Area = Math.PI * radius * radius;
            Console.WriteLine($"Shape name is: {ShapeName}");
            Console.WriteLine($"Area of the circle is: {Math.Round(Area, 3)}");
        }
    }
    internal class Rectangle : Shape
    {
        public override string ShapeName => "Rectangle";
        public override void CalculateArea()
        {
            double length = GetUserInput("Enter length for which you want to calculate the area of Rectangle?");
            double breadth = GetUserInput("Enter breadth for which you want to calculate the area of Rectangle?");
            double Area = length * breadth;
            Console.WriteLine($"Shape name is: {ShapeName}");
            Console.WriteLine($"Area of the rectangle is: {Math.Round(Area, 3)}");
        }
    }
    internal class Triangle1 : Shape
    {
        public override string ShapeName => "Triangle";
        public override void CalculateArea()
        {
            double height = GetUserInput("Enter height for which you want to calculate the area of Triangle?");
            double breadth = GetUserInput("Enter breadth for which you want to calculate the area of Triangle?");
            double Area = 0.5 * height * breadth;
            Console.WriteLine($"Shape name is: {ShapeName}");
            Console.WriteLine($"Area of the triangle is: {Math.Round(Area, 3)}");
        }
    }
}