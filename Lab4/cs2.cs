using Numbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle
    {
        private double side1, side2, side3;

        public Triangle(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public double Area()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
    }

    public class Rectangle
    {
        private double length, width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double Perimeter()
        {
            return 2 * (length + width);
        }

        public double Area()
        {
            return length * width;
        }
    }

    public class Square
    {
        private double side;

        public Square(double s)
        {
            side = s;
        }

        public double Perimeter()
        {
            return 4 * side;
        }

        public double Area()
        {
            return side * side;
        }
    }
    internal class cs2
    {
        public static void DisplayInfoFigure()
        {

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine(" ");
            
            double trianglePerimeter = triangle.Perimeter();
            Console.WriteLine($"Triangle Perimeter: {trianglePerimeter}") ;
            Console.WriteLine(" ");

            double triangleArea = triangle.Area();
            Console.WriteLine($"Triangle Area: {triangleArea}");
            Console.WriteLine(" ");

            Rectangle rectangle = new Rectangle(5, 3);

            
            double rectanglePerimeter = rectangle.Perimeter();
            Console.WriteLine($"Rectangle Perimeter: {rectanglePerimeter}" );
            Console.WriteLine(" ");

            double rectangleArea = rectangle.Area();
            Console.WriteLine($"Rectangle Area: {rectangleArea}");
            Console.WriteLine(" ");

            Square square = new Square(4);

            
            double squarePerimeter = square.Perimeter();
            Console.WriteLine($"Square Perimeter: {squarePerimeter}");
            Console.WriteLine(" ");

            double squareArea = square.Area();
            Console.WriteLine($"Triangle Perimeter: {trianglePerimeter}");
            Console.WriteLine(" ");
        }

    }

}