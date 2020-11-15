using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate[] delegates = new MyDelegate[]
            {
                new MyDelegate(ReturnRandom),
                new MyDelegate(ReturnRandom),
                new MyDelegate(ReturnRandom),
                new MyDelegate(ReturnRandom),
                new MyDelegate(ReturnRandom),
            };
            
            MyDelegate2 mydelegate = (delegates) =>
            {
                double sum = 0;
                foreach (MyDelegate @delegate in delegates)
                {
                    sum += @delegate();
                }
                return sum / delegates.Length;
            };

            double arithmeticalMean = mydelegate(delegates);
            Console.WriteLine(arithmeticalMean);

            Console.ReadLine();
        }

        delegate int MyDelegate();
        delegate double MyDelegate2(MyDelegate[] delegates);
        
        static int ReturnRandom()
        {
            Random rnd = new Random();
            return rnd.Next(5, 10);
        }
        
    }
}
