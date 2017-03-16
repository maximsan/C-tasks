using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Basement : IPart
    {
        public Basement() { }

        public void Building()
        {
            Console.WriteLine("The basement is finish");
        }

         public void ShowPartOfHouse()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  *****************************   ");
            Console.WriteLine("  *****************************   ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
