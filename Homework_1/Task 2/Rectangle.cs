using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Rectangle
    {
        private readonly double side1, side2;
        public double Area => side1 * side2;
        public double Perimeter => side1 * 2 + side2 * 2;

        public Rectangle(double side1, double side2)
        {
            if (side1 > 0 && side2 > 0)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            else
            {
                Console.WriteLine("Error: lengths of a rectangle sides can only be positive ");
            }
        }

    }
}
