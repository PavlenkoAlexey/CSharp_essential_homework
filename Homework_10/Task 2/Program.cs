using System;
using System.Collections.Generic;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            MyList<int> intList = new MyList<int>(2);

            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            intList.Capacity = 6;
            int testIndex1 = intList[3]; // получение элемента по указанному индексу

            intList.Show();

            Console.WriteLine("\n" + $"Элементов в массиве intList сейчас: {intList.Count}");
            Console.WriteLine($"А всего может быть записано до следующего увеличения: {intList.Capacity}");

            Console.WriteLine();

            MyList<string> stringList = new MyList<string>();

            stringList.Add("aaa");
            stringList.Add("bbb");
            stringList.Add("ccc");
            stringList.Add("ddd");
            stringList.Add("eee");
            stringList.Add("fff");
            stringList.Add("ggg");

            stringList.Capacity = 8;
            string testIndex2 = stringList[3];

            stringList.Show();
            Console.WriteLine("\n" + $"Элементов в массиве stringList сейчас: {stringList.Count}");
            Console.WriteLine($"А всего может быть записано до следующего увеличения: {stringList.Capacity}");
            Console.WriteLine("\n" + "Получение элементов по индексу");
            Console.WriteLine($"testIndex1: {testIndex1}, testIndex2: {testIndex2}");

            Console.ReadLine();
        }
    }
}
