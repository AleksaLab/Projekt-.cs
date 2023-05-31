using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to");
            Thread.Sleep(1000);
            Class.Mort();
            Thread.Sleep(1000);
            Class.Komb();
            Thread.Sleep(1000);
            Console.WriteLine("Choose your character.");
            Class.Pos();
            Class.PosW();
            int round = 0;
            int[] rounds = { 0, 0 };
            
            while (true)
            {
                Play.GamePlay(round, rounds);
                rounds[0] = 0;
                rounds[1] = 0;
                Console.WriteLine("Want to play again? 1-yes, 2-no.");
                int odp = int.Parse(Console.ReadLine());
                if (odp == 1)
                {
                    Play.GamePlay(round, rounds);
                    rounds[0] = 0;
                    rounds[1] = 0;
                }
                if (odp == 2)
                {
                    Console.WriteLine("Thank you for playing.");
                    break;
                }
            }
        }
    }
}
