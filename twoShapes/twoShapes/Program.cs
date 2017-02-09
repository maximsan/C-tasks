using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeShapesABC
{
    class Program
    {
        static void Main(string[] args)
        {
            double raceSquare, A, B, C, N;
            string strA, strB, strC;
            Console.WriteLine("Input A ");
            strA = Console.ReadLine();
            A = double.Parse(strA);
            Console.WriteLine("Input B ");
            strB = Console.ReadLine();
            B = double.Parse(strB);
            Console.WriteLine("Input C ");
            strC = Console.ReadLine();
            C = double.Parse(strC);
            N = Math.Truncate(A * B / Math.Pow(C, 2));
            if (N <= 0)
                Console.WriteLine("The area of square is wrong!!!");
            else 
            {
                    raceSquare = (A * B) - N * Math.Pow(C, 2);
                    Console.WriteLine("The amount of square is = " + N);
                    Console.WriteLine("The race of area is = " + raceSquare);
            }
        }
    }
}
