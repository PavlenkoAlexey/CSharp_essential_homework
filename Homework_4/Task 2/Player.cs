using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Воспроизведение");
        }
        public void Record()
        {
            Console.WriteLine("Запись");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Воспроизведение приостановлено");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись приостановлена");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Конец записи");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Конец воспроизведения");
        }
    }
}
