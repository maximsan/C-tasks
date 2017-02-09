using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcerASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbolStr;
            string newSymbolStr = null;
            int iString;


            while ((symbolStr = Console.ReadKey().KeyChar) != ' ')
            {
                if (char.IsUpper(symbolStr))
                    //symbolStr = char.ToLower(symbolStr);
                {
                    iString = Convert.ToInt32(symbolStr) + 32;
                    symbolStr = Convert.ToChar(iString);
                }
                else
                    //symbolStr = char.ToUpper(symbolStr);
                {
                    iString = Convert.ToInt32(symbolStr) - 32;
                    symbolStr = Convert.ToChar(iString);
                }
            newSymbolStr += symbolStr;
            }
            Console.WriteLine();
            Console.WriteLine(newSymbolStr);
        }
    }
}
