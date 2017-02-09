using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depositInBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //int firstDeposit = 1000;
            double p, S, S1;
            int k = 0;
            Console.WriteLine("Input p procent of deposit");
            //strP = Console.ReadLine();
            p = double.Parse(Console.ReadLine());

            S1 = 1000 + 1000 * p/100;
            S = S1;
            k++;
            while (true)
            {
                if (S <= 1100)
                {
                    S += S * p / 100;
                    k++;
                }
                else
                {
                    Console.WriteLine("Amount of months is " + k);
                    Console.WriteLine("Sum of deposit is " + S);
                    break;
                }
            }

        }
    }
}
