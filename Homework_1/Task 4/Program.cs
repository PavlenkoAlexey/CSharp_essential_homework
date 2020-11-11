using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(2, 2, "a");
            Point b = new Point(2, 4, "b");
            Point c = new Point(6, 4, "c");
            Point d = new Point(6, 2, "d");
            Point e = new Point(4, 0, "e");

            Figure figure1 = new Figure(a, b, c);
            figure1.Show();

            Console.WriteLine();

            Figure figure2 = new Figure(a, b, c, d);
            figure2.Show();

            Console.WriteLine();

            Figure figure3 = new Figure(a, b, c, d, e);
            figure3.Show();

            Console.ReadLine();
        }
    }
}
