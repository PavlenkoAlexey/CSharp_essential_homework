using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Figure
    {
        private readonly Point[] points;
        public Figure(Point a, Point b, Point c)
            
        {
            points = new Point[3];
            points[0] = a;
            points[1] = b;
            points[2] = c;

            Console.Write($"{a.Name}{b.Name}{c.Name} is a Triangle, its ");
            PerimeterCalculator(a,b,c);
        } 
        public Figure(Point a, Point b, Point c, Point d)
        {
            points = new Point[4];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;

            Console.Write($"{a.Name}{b.Name}{c.Name}{d.Name} is a Rectangle, its ");
            PerimeterCalculator(a, b, c, d);
        }
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            points = new Point[5];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
            points[4] = e;

            Console.Write($"{a.Name}{b.Name}{c.Name}{d.Name}{e.Name} is a Pentagon, its ");
            PerimeterCalculator(a, b, c, d, e);
        }

        public void Show ()
        {
            foreach (Point point in points)
            {
                Console.WriteLine($"point {point.Name}: {point.X};{point.Y}");
            }
        }
        private double LengthSide(Point A, Point B)
        {
            double distance = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
            return distance;
        }
        public void PerimeterCalculator(params Point[] points)
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length-1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
            perimeter += LengthSide(points[0], points[points.Length - 1]);

            Console.WriteLine("perimeter: " + perimeter);
        }
    }
}
