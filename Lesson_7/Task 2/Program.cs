using System;

namespace Task_2
{
    struct Train
    {
        private int trainNumber;

        public Train(string destination, int trainNumber, DateTime departureTime)
        {
            this.DepartureTime = departureTime;
            this.Destination = destination;
            this.trainNumber = trainNumber;
        }


        public int TrainNumber
        {
            get => trainNumber;
            set => trainNumber = GetTrainNumber(value);
        }

        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }

        private int GetTrainNumber(int trainNum)
        {
            if (trainNum > 0)
                return trainNum;
            else
            {
                while (true)
                {
                    Console.WriteLine("Номер поезда не может быть отрицательным, введите заново");
                    trainNum = int.Parse(Console.ReadLine());
                    if (trainNum > 0)
                        return trainNum;
                    else
                        continue;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[3];


            //  Ввод с клавиатуры данных в массив
            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine($" Введите {i + 1}-й номер поезда");
                trains[i].TrainNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"Введите назначение поезда {trains[i].TrainNumber}");
                trains[i].Destination = Console.ReadLine();
                Console.WriteLine($"Введите время отправления поезда {trains[i].TrainNumber}");
                trains[i].DepartureTime = DateTime.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n" + "Введите номер поезда, информацию о котором хотите узнать");
            ShowTrainInfo(out _, trains); // Вывод на экран информации о поезде, номер которого введен с клавиатуры


            static void ShowTrainInfo(out int trainNumber, Train[] trains)
            {
                trainNumber = int.Parse(Console.ReadLine());
                for (int i = 0; i < trains.Length; i++)
                {
                    if (trains[i].TrainNumber == trainNumber)
                    {
                        Console.WriteLine($"Назначение: {trains[i].Destination}");
                        Console.WriteLine($"Время отправления: {trains[i].DepartureTime}");
                        return;
                    }
                }
                Console.WriteLine("Нет поезда с таким номером");
            }

            Console.ReadLine();
        }
    }
}
