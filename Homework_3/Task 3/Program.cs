using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane concord = new Plane("Конкорд")
            {
                Height = 18300,
                Price = 23000000,
                NumberOfPassengers = 110,
                YearOfIssue = 1965,
                Speed= 2330,
                CoordinateX = 61.7,
                CoordinateY= 25.6,
            };
            concord.Show();

            Ship titanic = new Ship("Титаник")
            {
                CoordinateX = 269.1,
                CoordinateY = 28.19,
                NumberOfPassengers = 2439,
                Speed = 23,
                Price = 190000000,
                YearOfIssue = 1911,
                HomePort = "Ливерпуль"
            };
            titanic.Show();

            Car aventador = new Car("Ламборджини Авентадор")
            {
                Speed = 349.2,
                Price = 350000,
                YearOfIssue = 2011,
                CoordinateX = 4.78,
                CoordinateY = 2.03
            };
            aventador.Show();   

            Console.ReadKey();
        }
    }
}
