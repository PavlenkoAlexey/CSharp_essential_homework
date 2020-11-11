using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);


            Console.WriteLine("\n" + "Area: " + rectangle.Area);
            Console.WriteLine("Perimeter: " + rectangle.Perimeter);
            

            Console.ReadKey(); // Delay
        }
    }
}
