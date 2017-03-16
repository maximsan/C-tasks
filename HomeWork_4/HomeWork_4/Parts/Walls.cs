using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Walls : IPart
    {
        public Walls() { }
        public void Building()
        {
            Console.WriteLine("wall is finish");
        }

        public void ShowPartOfHouse()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ****  **  ***   ***  **  ****   ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
