using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revererseNaturalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string strN;
            Console.WriteLine("Inout number");
            //strN = Console.ReadLine();
            int N = int.Parse(strN = Console.ReadLine());
            int uTemp, uNewN = 0;
            do
            {
                uTemp = (N % 10);
                N /= 10;
                uNewN = (uNewN * 10 + uTemp);
            } while (N != 0);
            Console.WriteLine(uNewN);
        }
    }
}
