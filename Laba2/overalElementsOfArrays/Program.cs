using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overalElementsOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input size of first array: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Input size of second array: ");
            int M = int.Parse(Console.ReadLine());
            int [] arrayN = new int[N];
            int [] arrayM = new int[M];
            //int [] thirdArray = new int[];
            Random rn = new Random();

            for (int i = 0; i < N; i++)
            {
                arrayN[i] = Convert.ToInt32(rn.Next(0, 20));
                Console.Write(arrayN[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                arrayM[i] = Convert.ToInt32(rn.Next(0, 20));
                Console.Write(arrayM[i] + " ");
            }
            Console.WriteLine();
            //int [] thirdArray = 

            var arrayCommon = arrayN.Intersect(arrayM);

            foreach (int i in arrayCommon)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }
}
