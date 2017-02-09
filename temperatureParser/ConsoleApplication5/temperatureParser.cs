using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class temperatureParser
    {
        static void Main(string[] args)
        {
            float TC, TF;

            Console.WriteLine("Input temperature in Farengeit = ");
            string stringTF = Console.ReadLine();
            TF = float.Parse(stringTF);
            TC = (TF - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsii = " + TC);
        }
    }
}
