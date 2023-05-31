using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project
{
    internal class Play
    {
        public static void GamePlay(int round, int[] rounds)
        {
            Dod_Play.DodPlay();

            while (round < 3)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"\tRound {round + 1}");
                Thread.Sleep(1000);
                Console.WriteLine("\tFIGHT!");

                Thread.Sleep(1000);
                Console.WriteLine("\tChoose your attack.");
                Console.WriteLine("1 - basic attack | 2 - special ability");

                int[] twB = { 100, 0 };
                int[] enemy = { 100, 0 };
                Random gen = new Random();


                while (enemy[0] > 0 | twB[0] > 0)
                {

                    while (true)
                    {
                        int odp = int.Parse(Console.ReadLine());
                        if (odp == 1)
                        {
                            int pods = gen.Next(10, 20);
                            int ptkZ = gen.Next(20, 30);
                            int ptkZE = gen.Next(20, 30);

                            enemy[0] -= pods;
                            //Console.WriteLine(enemy[1]);
                            enemy[1] += ptkZE;
                            twB[1] += ptkZ;
                            Console.WriteLine($"Your health: {twB[0]}, Enemy's health: {enemy[0]}, Your charching points: {twB[1]}");
                            break;

                        }
                        if (odp == 2 && twB[1] >= 100)
                        {
                            int zawO = gen.Next(35, 45);
                            int ptkZE = gen.Next(20, 30);

                            enemy[0] -= zawO;
                            enemy[1] += ptkZE;
                            twB[1] = 0;
                            Thread.Sleep(1000);
                            Console.WriteLine("You used your special ability!");
                            Thread.Sleep(1000);
                            Console.WriteLine($"Your health: {twB[0]}, Enemy's health: {enemy[0]}, Your charching points: {twB[1]}");
                            break;

                        }
                        else
                        {
                            Console.WriteLine("You don't have enough points to charge your special ability.");
                        }

                    }
                    if (enemy[0] <= 0)
                    {
                        rounds[0] += 1;
                        Console.WriteLine(rounds[0]);
                        round += 1;
                        Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                        break;
                    }
                    // runda wygrana przez wroga
                    if (twB[0] <= 0)
                    {
                        rounds[1] += 1;
                        round += 1;
                        Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                        break;
                    }

                    Thread.Sleep(1000);
                    Console.WriteLine("Enemy's turn.");
                    Thread.Sleep(1000);
                    //1-podstawowy atak, 2-zaawan
                    while (true)
                    {
                        int warn = gen.Next(1, 3);
                        //Console.WriteLine($"LOSOWANIE{warn}");
                        if (warn == 1)
                        {
                            int podsE = gen.Next(10, 20);
                            int ptkZ = gen.Next(20, 30);
                            int ptkZE = gen.Next(20, 30);

                            twB[0] -= podsE;
                            twB[1] += ptkZ;
                            enemy[1] += ptkZE;
                            Console.WriteLine($"Your health: {twB[0]}, Enemy's health: {enemy[0]}, Your charching points: {twB[1]}");
                            break;
                        }
                        if (warn == 2 && enemy[1] >= 100)
                        {
                            int ptkZ = gen.Next(20, 30);
                            int zawOE = gen.Next(35, 45);

                            twB[0] -= zawOE;
                            twB[1] += ptkZ;
                            enemy[1] = 0;
                            Thread.Sleep(1000);
                            Console.WriteLine("Enemy used special ability!");
                            Thread.Sleep(1000);
                            Console.WriteLine($"Your health: {twB[0]}, Enemy's health: {enemy[0]}, Your charching points: {twB[1]}");
                            break;

                        }

                    }
                    //runda wygrana przez gracza
                    if (enemy[0] <= 0)
                    {
                        rounds[0] += 1;
                        Console.WriteLine(rounds[0]);
                        round += 1;
                        Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                        break;
                    }
                    // runda wygrana przez wroga
                    if (twB[0] <= 0)
                    {
                        rounds[1] += 1;
                        round += 1;
                        Console.WriteLine($"{rounds[0]} : {rounds[1]}");
                        break;
                    }


                }

            }
            if (rounds[0] > rounds[1])
            {
                Thread.Sleep(1000);
                Console.WriteLine("YOU WON!");
                Thread.Sleep(1000);
            }
        }
    }
}
