using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Roof : IPart
    {
        public Roof() { }

        public void Building()
        {
            Console.WriteLine("The roof is finish");
        }

        public void ShowPartOfHouse()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("             ********             ");
            Console.WriteLine("          **************          ");
            Console.WriteLine("        ******************        ");
            Console.WriteLine("     ***********************      ");
            Console.WriteLine("   ***************************    ");
            Console.WriteLine("  *****************************   ");
            Console.WriteLine("  ****  **  *********  **  ****   ");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
