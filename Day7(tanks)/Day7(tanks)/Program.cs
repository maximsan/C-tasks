using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib;
using System.Threading;

namespace Day7_tanks_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                const int n = 5;
                int CountOfWinOfPantaraTanks=0;
                int CountOfWinOfT34Tanks=0;
                Tank[] panteraTanks = new Tank[n];
                Tank[] t34Tanks = new Tank[n];
                if (panteraTanks == null || t34Tanks == null)
                {
                    //check for memory leak
                    throw new Exception("Error of memory allocation");
                }
                for (int i = 0; i < panteraTanks.Length; i++)
                {
                    panteraTanks[i] = new Tank("Pantera");
                    if (panteraTanks[i] == null)
                    {

                        throw new Exception("Error of memory allocation for pantera tanks");
                    }
                    //setting of delay for creating of various random elements of objects
                    Thread.Sleep(100);
                }

                for (int i = 0; i < t34Tanks.Length; i++)
                {
                    t34Tanks[i] = new Tank("T34");
                    if (t34Tanks[i] == null)
                    {
                        throw new Exception("Error of memory allocation for t34 tanks");
                    }
                    //setting of delay for creating of various random elements of objects
                    Thread.Sleep(100);
                }
                for (int i = 0; i < n; i++)
                {
                    
                    string NameOfWinner = panteraTanks[i] * t34Tanks[i];
                    //counting of the badges
                    if (NameOfWinner == "Pantera")
                        CountOfWinOfPantaraTanks++;
                    else if (NameOfWinner == "T34")
                        CountOfWinOfT34Tanks++;
                    //printing of the winner in the battle
                    if (NameOfWinner != null)
                    {
                        Console.WriteLine("In " + (i + 1) + " battle:");
                        Console.WriteLine("Winner: {0}", NameOfWinner);
                    }
                    else 
                        Console.WriteLine("Draw!!!");
                    
                    Thread.Sleep(1000);
                }
                //check for winner of the all games
                if (CountOfWinOfPantaraTanks < CountOfWinOfT34Tanks)
                    Console.WriteLine("Winner of the games:T34 tanks");
                else if (CountOfWinOfPantaraTanks > CountOfWinOfT34Tanks)
                    Console.WriteLine("Winner of the all games: Pantera tanks");
                else Console.WriteLine("Draw!!!");

            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
