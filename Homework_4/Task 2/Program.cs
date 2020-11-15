using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            IPlayable player1 = new Player();
            IRecodable player2 = new Player();

            player1.Play();
            player1.Pause();
            player1.Play();
            player1.Stop();

            Console.WriteLine();

            player2.Record();
            player2.Pause();
            player2.Record();
            player2.Stop();

            Console.ReadLine();

        }
    }
}
