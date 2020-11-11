using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Three comrades")
            {
                Author = "Erich Maria Remarque",
                Content = "Chapter 1\n" + "Chapter 2"
            };
            book1.Show();


            Console.Read(); // Delay
        }
    }
}
