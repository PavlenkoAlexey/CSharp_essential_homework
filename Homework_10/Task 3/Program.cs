using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary1 = new MyDictionary<string, string>();
            dictionary1.AddNewPair("ручка", "pen");
            dictionary1.AddNewPair("яблоко", "apple");
            dictionary1.AddNewPair("стол", "table");
            dictionary1.AddNewPair("таблетка", "pill");

            Console.WriteLine($"На данный момент в словаре: {dictionary1.Count} пар(а/ы) слово-перевод.");
            Console.WriteLine($"ручка: {dictionary1["ручка"]}");
            Console.WriteLine($"стол: {dictionary1["стол"]}");
            Console.WriteLine($"а перевода слова машина нет: {dictionary1["машина"]}");

            Console.WriteLine();

            MyDictionary<int, double> dictionary2 = new MyDictionary<int, double>();
            dictionary2.AddNewPair(1, 14.88);
            dictionary2.AddNewPair(2, 359);
            dictionary2.AddNewPair(3, 22.8);
            dictionary2.AddNewPair(4, 13.37);

            Console.WriteLine($"1: {dictionary2[1]}");
            Console.WriteLine($"2: {dictionary2[2]}");
            Console.WriteLine($"3: {dictionary2[3]}");
            Console.WriteLine($"4: {dictionary2[4]}");

            Console.WriteLine($"5 - отсутствует: {dictionary2[5]}");


            Console.ReadLine(); //delay
        }
    }
}
