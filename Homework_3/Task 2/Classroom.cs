using System;

namespace Task_2
{
    class Classroom
    {
        private readonly Pupil[] classroom;
        public Classroom(Pupil pupil1,Pupil pupil2)
        {
            classroom = new Pupil[2];
            classroom[0] = pupil1;
            classroom[1] = pupil2;
        }
        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            classroom = new Pupil[3];
            classroom[0] = pupil1;
            classroom[1] = pupil2;
            classroom[2] = pupil3;
        }
        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            classroom = new Pupil[4];
            classroom[0] = pupil1;
            classroom[1] = pupil2;
            classroom[2] = pupil3;
            classroom[3] = pupil4;
        }
        
        public void ClassroomInfo()
        {
            foreach (Pupil pupil in classroom)
            {
                Console.WriteLine($"Ученик {pupil.Name}: ");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine();
            }
        }

    }
}
