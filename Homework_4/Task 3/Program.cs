using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler file1 = new TXTHandler();
            file1.Create();
            file1.Open();
            file1.Change();
            file1.Save();

            Console.WriteLine();

            AbstractHandler file2 = new XMLHandler();
            file2.Create();
            file2.Open();
            file2.Change();
            file2.Save();

            Console.WriteLine();

            AbstractHandler file3 = new DOCHandler();
            file3.Create();
            file3.Open();
            file3.Change();
            file3.Save();



            Console.ReadKey();
        }
    }
}
