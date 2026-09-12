using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class Shape
    {
        public virtual void CalculateArea()
        {
            Console.WriteLine("Area of Shape");
        }
    }

    // Derived Class
    class Circle : Shape
    {
        public override void CalculateArea()
        {
            double radius = 5;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle = " + area.ToString("0.00"));
        }
    }

    // Fixed spelling from "Rectabgle" to "Rectangle"
    class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            double length = 10;
            double width = 5;

            double area = length * width;
            Console.WriteLine("Area of Rectangle = " + area); // Fixed spelling "Reactangle"
        }
    }

    class Triangle : Shape
    {
        public override void CalculateArea()
        {
            double b = 10;
            double h = 5;

            double area = 0.5 * b * h;
            Console.WriteLine("Area of Triangle : " + area);
        }
    }

    internal class Program17
    {
        static void Main()
        {
            // Personal Header Details
            Console.WriteLine("Name:Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            Shape shape;

            shape = new Circle();
            shape.CalculateArea();

            shape = new Rectangle(); // Fixed object creation name
            shape.CalculateArea();

            shape = new Triangle();
            shape.CalculateArea();

            Console.ReadLine(); // Standardized to ReadLine to hold the window cleanly
        }

    }
}
