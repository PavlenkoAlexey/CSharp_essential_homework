using System;
using System.Security.Cryptography.X509Certificates;

namespace Task_2
{
    public delegate double MyDelegate(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate Add = (x, y) => x + y;
            MyDelegate Sub = (x, y) => x - y;
            MyDelegate Mul = (x, y) => x * y;
            MyDelegate Div = (x, y) =>
            {
                if (y != 0)
                    return x / y;
                else
                {
                    Console.WriteLine("Нельзя делить на ноль!");
                    return x / y;
                }

            };

            Console.WriteLine("Введите первое число");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите знак операции");
            char op = char.Parse(Console.ReadLine());

            double result = 0;
            switch (op)
            {
                case '+':
                    result = Add(x, y);
                    break;
                case '-':
                    result = Sub(x, y);
                    break;
                case '*':
                    result = Mul(x, y);
                    break;
                case '/':
                    result = Div(x, y);
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильный знак операции");
                    break;
            }

            Console.WriteLine($"Результат операции: {result}");

            Console.ReadLine();

        }
    }
}
