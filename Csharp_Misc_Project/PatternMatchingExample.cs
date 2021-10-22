using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Misc_Project
{
    class Shape
    {
        public const float PI = 3.4F;
    }
    class Circle: Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    class Rectangle : Shape
    {
        public double Length { get; }
        public double Height { get; }
        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
    class Triangle: Shape
    {
        public double Base { get; }
        public double Height { get; }
        public Triangle(double @base,double height)
        {
            Base = @base;
            height = Height;
        }
    }
    class PatternMatchingExample
    {
        public static void Calculate(Shape shape)
        {
            switch(shape)
            {
                case Circle c:
                    Console.WriteLine("Area of Circle : " + (c.Radius * c.Radius * Shape.PI));
                    break;

                case Rectangle r:
                    Console.WriteLine("Area of Rectangle : " + (r.Length * r.Height));
                    break;

                case Triangle t:
                    Console.WriteLine("Area of Triangle : " + (0.5 * t.Base * t.Height));
                    break;
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));

            }
            //if(shape is Circle circle)
            //{
            //    //Circle circle = (Circle)shape;
            //    Console.WriteLine("Area of Circle : " + (circle.Radius * circle.Radius * Shape.PI));
            //}
            //else if(shape is Rectangle rectangle)
            //{
            //    //Rectangle rectangle = (Rectangle)shape;
            //    Console.WriteLine("Area of Rectangle : " + (rectangle.Length * rectangle.Height));
            //}
            //else if(shape is Triangle triangle)
            //{
            //    //Triangle triangle = (Triangle)shape;
            //    Console.WriteLine("Area of Triangle : " + (0.5 * triangle.Base * triangle.Height));
            //}
            //else
            //{
            //    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            //}
        }
        //static void Main(string[] args)
        //{
        //    Circle circle = new Circle(10);
        //    Calculate(circle);
        //    Rectangle rectangle = new Rectangle(10, 5);
        //    Calculate(rectangle);
        //    Triangle triangle = new Triangle(15, 5);
        //    Calculate(triangle);
        //    Console.ReadKey();
        //}
        
    }
}
