using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project
{
    internal class Class
    {
        public static void Mort()
        {
            Console.WriteLine(" _    _   ____   ____  _____   __     _");
            Console.WriteLine("|  \\/  | /    \\ | _  \\|__ __| /_ \\   | |");
            Console.WriteLine("| |\\/| ||  /\\  || - _/  | |  //_\\ \\  | |");
            Console.WriteLine("| |  | ||  \\/  ||   \\   | | / ___  \\ | |__");
            Console.WriteLine("|_|  |_| \\____/ |_|\\_\\  |_|/_/   \\__\\|____|");
        }
        public static void Komb()
        { 
            Console.WriteLine(" _  __  ____   _    _  ____     __    _____");
            Console.WriteLine("| |/ / /    \\ |  \\/  || _  \\   /_ \\  |__ __|");
            Console.WriteLine("|   / |  /\\  || |\\/| || - _/  //_\\ \\   | |");
            Console.WriteLine("|   \\ |  \\/  || |  | || _  \\ / ___  \\  | |");
            Console.WriteLine("|_|\\_\\ \\____/ |_|  |_||____//_/   \\__\\ |_|");
        }
        public static void Pos()
        {
            Console.WriteLine(" ____________ ____________ ____________");
            Console.WriteLine("|            |            |            |");
            Console.WriteLine("| 1.Sub-Zero | 2.Scorpion | 3.Liu Kang |");
            Console.WriteLine("|____________|____________|____________|");
        }
        public static void PosW()
        {
            while (true)
            {
                int odp = int.Parse(Console.ReadLine());
                if (odp == 1)
                {
                    Console.WriteLine("\tYou chose Sub-Zero!");
                    break;
                }
                if (odp == 2)
                {
                    Console.WriteLine("\tYou chose Scorpion!");
                    break;
                }
                if (odp == 3)
                {
                    Console.WriteLine("\tYou chose Liu Kang!");
                    break;
                }
                else
                {
                    Console.WriteLine("You chose wrong button.");
                }
            }
        }
    }
}
