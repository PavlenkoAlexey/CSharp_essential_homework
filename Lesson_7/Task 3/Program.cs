using System;

namespace Task_3
{
    class Program
    {
        class MyClass
        {
            public string change;
        }
        struct MyStruct
        {
            public string change;
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "не изменено";

            MyStruct myStruct;
            myStruct.change = "не изменено";

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine($"myClass.change: {myClass.change}");
            Console.WriteLine($"myStruct.change: {myStruct.change}");
            /* Поле myClass.change изменилось тк myClass переменная ссылочного типа и методу была передана ссылка на переменную лежащую на кучу
             * Поле myStruct.change не изменилось тк методу была передана копия структуры и изменения в копии не затронули оригинал
             * Чтобы метод StruktTaker изменил myStruct.change нужно добавить в сигнатуру метода ключевое слово ref
             */

            Console.ReadLine(); // Delay

            static void ClassTaker(MyClass myClass)
            {
                myClass.change = "изменено";
            }
            static void StruktTaker(MyStruct myStruct)
            {
                myStruct.change = "изменено";
            }
        }
    }
}
