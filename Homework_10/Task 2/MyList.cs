using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class MyList<T>
    {
        private const int defaultSize = 5; // размер при успользовании конструктора по умолчанию
        private const double growthIndex = 2; // во сколько раз увеличится массив при переполнении 
        private T[] array;
        private int count; // кол-во элементов на данный момент, поле тут только затем что в задании было явно указано что свойство должно быть только для чтения
        public int Count => count;  // свойство для получения кол-ва элементов на данный момент
        public int Capacity { get; set; } // кол-во элементов которое может храниться в массиве до переполнения
        public MyList() : this(defaultSize) { } //конструктор по умолчанию
        public MyList(int initialCapacity) // конструктор с явно заданным кол-вом элементов до переполнения
        {
            count = 0;
            Capacity = initialCapacity;
            array = new T[initialCapacity];
        }

        public T this[int index]
        {
            get => array[index];
        }
        public void Add(T newElement)
        {
            if (count < Capacity)
            {
                array[count++] = newElement;
            }
            else
            {
                array = Resize(array);
                array[count++] = newElement;
                Capacity = array.Length;
            }
        }
        private T[] Resize(T[] array)
        {
            int newCapacity = (int)(Capacity * growthIndex);
            T[] newArray = new T[newCapacity];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return array = newArray;
        }

        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
