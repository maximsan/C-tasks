using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theNumeralEqualQuantity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input bottom border");
            string strBottom = Console.ReadLine();
            Console.WriteLine("Input upper border");
            string strUpper = Console.ReadLine();
            int iBottom = int.Parse(strBottom);
            int iUpper = int.Parse(strUpper);
            int iPrint, j;

            for (int i = iBottom; i <= iUpper; i++)
            {
                iPrint = i;
                j = i;
                do
                {
                    Console.Write(iPrint);
                    j--;
                } while (j != 0);
                Console.WriteLine();
            }
        }
    }
}
