using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareOfTreangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3, a, b, c, S, p;
            Console.WriteLine("Input value of coordinate x1");
            string stringX1 = Console.ReadLine();
            x1 = double.Parse(stringX1);
            Console.WriteLine("Input value of coordinate y1");
            string stringY1 = Console.ReadLine();
            y1 = double.Parse(stringY1);
            Console.WriteLine("Input value of coordinate x2");
            string stringX2 = Console.ReadLine();
            x2 = double.Parse(stringX2);
            Console.WriteLine("Input value of coordinate y2");
            string stringY2 = Console.ReadLine();
            y2 = double.Parse(stringY2);
            Console.WriteLine("Input value of coordinate x3");
            string stringX3 = Console.ReadLine();
            x3 = double.Parse(stringX3);
            Console.WriteLine("Input value of coordinate y3");
            string stringY3 = Console.ReadLine();
            y3 = double.Parse(stringY3);

            a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            
            p = (a+b+c)/2;

            S = Math.Pow((p * (p - a) * (p - b) * (p - c)),0.5);

            Console.WriteLine("Square of treangle = "+S);
        }
    }
}
