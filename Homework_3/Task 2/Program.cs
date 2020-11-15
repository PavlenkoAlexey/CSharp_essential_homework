using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pasha = new Pupil("Паша");
            Pupil kolya = new GoodPupil("Коля");
            Pupil vasya = new BadPupil("Вася");
            Pupil vladik = new ExcelentPupil("Владик");

            Classroom _10A = new Classroom(vasya, kolya, vladik, pasha);
            _10A.ClassroomInfo();

            Console.ReadKey();
        }
    }
}
