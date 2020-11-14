using System;
using Task_2;

namespace Task_4
{
    static class Program
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
        public static void Show<T>(this T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            MyList<double> myList = new MyList<double>();
            myList.Add(10.14);
            myList.Add(113.02);
            myList.Add(12.16);
            myList.Add(134.28);
            myList.Add(153.93);
            myList.Add(189.86);
            myList.Add(116.12);

            var intArray = myList.GetArray();
            intArray.Show();

            Console.WriteLine();

            var myList2 = new MyList<string>();
            myList2.Add("aaa");
            myList2.Add("bbb");
            myList2.Add("ccc");
            myList2.Add("ddd");
            myList2.Add("asfdvsdf");

            myList2.Show();

            Console.ReadLine();
        }
    }
}
