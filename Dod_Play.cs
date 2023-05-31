using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project
{
    internal class Dod_Play
    {
        public static void DodPlay()
        {

            Random genr = new Random();
            int wrg = genr.Next(1, 4);

            Thread.Sleep(1000);
            //1-Mileena, 2-Baraka, 3-Sindel
            if (wrg == 1)
            {
                Console.WriteLine("You're fighting with Mileena.");

            }
            if (wrg == 2)
            {
                Console.WriteLine("You're fighting with Baraka.");

            }
            if (wrg == 3)
            {
                Console.WriteLine("You're fighting with Sindel.");

            }
        }
    }
}