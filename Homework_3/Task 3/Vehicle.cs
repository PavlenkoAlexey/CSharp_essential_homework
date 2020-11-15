using System;

namespace Task_3
{
    class Vehicle
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public double Price { get; set; }
        public int YearOfIssue { get; set; }
        public double Speed { get; set; }
        protected string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Длина: {CoordinateX}");
            Console.WriteLine($"Ширина: {CoordinateY}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Максимальная скорость: {Speed}");
            Console.WriteLine($"Год выпуска: {YearOfIssue}");
            Console.WriteLine();
        }
    }
    class Plane : Vehicle
    {
        public Plane(string name) : base() { Name = name; }
        public int Height { get; set; }
        public int NumberOfPassengers { get; set; }
        public override void Show()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Длина: {CoordinateX}");
            Console.WriteLine($"Размах крыльев: {CoordinateY}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Максимальная скорость: {Speed}");
            Console.WriteLine($"Год выпуска: {YearOfIssue}");
            Console.WriteLine($"Высота полета: {Height}");
            Console.WriteLine($"Пассажировместимость : {NumberOfPassengers}");
            Console.WriteLine();
        }
    }

    class Car : Vehicle
    {
        public Car(string name) : base() { Name = name; }

    }
    class Ship : Vehicle
    {
        public Ship(string name) : base() { Name = name; }
        public int NumberOfPassengers { get; set; }
        public string HomePort { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Длина: {CoordinateX}");
            Console.WriteLine($"Ширина: {CoordinateY}");
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine($"Скорость хода, узлов: {Speed}");
            Console.WriteLine($"Год выпуска: {YearOfIssue}");
            Console.WriteLine($"Порт приписки: {HomePort}");
            Console.WriteLine($"Пассажировместимость : {NumberOfPassengers}");
            Console.WriteLine();
        }

    }
        
    
}
