using Geometry.Shapes;
using System.ComponentModel;
using static System.Console;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("---------- Circle ---------\n");
            
            Circle circle = new Circle(radius: 3f);
            WriteLine(circle.GetArea());
            WriteLine(circle.GetCircumference());
            WriteLine(circle.GetVolymAsSphere());


            WriteLine("\n\n---------- Unequal sides triangle ---------\n");

            Triangle scalenTriangle = new Triangle(3,4,5);
            WriteLine(scalenTriangle.GetArea());
            WriteLine(scalenTriangle.GetCircumference());
            WriteLine(scalenTriangle.GetSumOfTheAngles());

            WriteLine("\n\n---------- Equal sides triangle ---------\n");

            Triangle equilateralTriangle = new Triangle(6);
            WriteLine(equilateralTriangle.GetArea());
            WriteLine(equilateralTriangle.GetCircumference());
            WriteLine(equilateralTriangle.GetSumOfTheAngles());


            WriteLine("\n\n---------- Square ---------\n");

            Square square = new Square(20);
            WriteLine(square.GetArea());
            WriteLine(square.GetCircumference());
            WriteLine(square.GetSumOfTheAngles());


            if (circle is Polygon)
                WriteLine("\nCircle is a polygon");
            else
                WriteLine("\nCircle is not a polygon");

            if (scalenTriangle is Polygon)
                WriteLine("\nScalene triangle is a polygon");
            else
                WriteLine("\nScalene triangle is not a polygon");

            if (equilateralTriangle is Polygon)
                WriteLine("\nEquilateral triangle is a polygon");
            else
                WriteLine("\nEquilateral triangle is not a polygon");

            if (square is Polygon)
                WriteLine("\nSquare is a polygon");
            else
                WriteLine("\nSquare is not a polygon");
        }
    }
}