using System;
using System.Collections.ObjectModel;

namespace open_Closed_Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Doesn't follow the open/closed principle.

            var mySquare = new ShapeNotOpenClosed(0,3,"square");
            var myCircle = new ShapeNotOpenClosed(10,0,"circle");
            
            Console.WriteLine("Incorrect way of applying open/closed principle:");
            Console.WriteLine("Area of square: {0}", mySquare.getArea());
            Console.WriteLine("Area of circle: {0}", myCircle.getArea());

            // Does follow the open/closed principle.
            ICollection<ShapeOpenClosed> shapes = new Collection<ShapeOpenClosed>();

            shapes.Add(new Square(5));
            shapes.Add(new Circle(10));
            shapes.Add(new ScaleneTriangle(2.0,2.0,2.0));

            Console.WriteLine("Correct way of applying open/closed principle:");
            foreach (var s in shapes)
            {
                Console.WriteLine("Area of {0}: {1}", s.Type , s.GetArea());
            }

        }
    }
}