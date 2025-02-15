using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPSPractice
{
    class Shapes
    {
        protected int GetUserInput(string input)
        {
            while (true)
            {
                Console.WriteLine(input);
                string? userInput = Console.ReadLine();
                int number;
                if (int.TryParse(userInput, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
        
        internal class Circle1 : Shapes, IShape, IPrintable
        {
            public double Radius { get; set; }
            public double Area { get; set; }           
            public void CalculateArea()
            {
                Radius = GetUserInput("Enter the radius of the circle: ");
                Area = Math.PI * Radius * Radius;
            }
            public void PrintArea()
            {
                Console.WriteLine($"The radius of the circle is {Area}");
            }
        }
        class Rectangle1 : Shapes, IShape, IPrintable
        {
            public double Length { get; set; }
            public double Breadth { get; set; }
            public double Area { get; set; }         
            public void CalculateArea()
            {
                Length = GetUserInput("Enter the length of the rectangle: ");
                Breadth = GetUserInput("Enter the breadth of the rectangle: ");
                Area = Length * Breadth;
            }
            public void PrintArea()
            {
                Console.WriteLine($"The area of the rectangle is {Area}");
            }
        }
        class Triangle : Shapes, IShape, IPrintable
        {
            public double Base { get; set; }
            public double Height { get; set; }
            public double Area { get; set; }           
            public void CalculateArea()
            {
                Base = GetUserInput("Enter the base of the triangle: ");
                Height = GetUserInput("Enter the height of the triangle: ");
                Area = 0.5 * Base * Height;
            }
            public void PrintArea()
            {
                Console.WriteLine($"The area of the triangle is {Area}");
            }

        }
    }

   
