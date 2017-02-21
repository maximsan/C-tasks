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
            Tank [] panteraTanks = new Tank[5];
            Tank [] t34Tanks = new Tank[5];
            for (int i = 0; i < panteraTanks.Length; i++)
            {
                panteraTanks[i] = new Tank("Pantera - " + (i+1));
                Thread.Sleep(100);
            }
 
            for (int i = 0; i < t34Tanks.Length; i++)
            {
                t34Tanks[i] = new Tank("T34 - " + (i+1));
                Thread.Sleep(100);
            }


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("In "+(i+1)+" battle win:");
                Console.WriteLine(panteraTanks[i] * t34Tanks[i]);
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }
    }
}
