using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = new[] { 1, 2, 4, 5, 6, 9, 10, 20, 24, 30, 35 };
            Console.WriteLine(BinarySearch(arrayNum, 36));

        }

        static int BinarySearch(int[] array, int SearchNumber)
        {
            int min = 0;
            int max = array.Length - 1;
            int midNum = 0;
            //int i = 0;
            while (max >= min)
            {
                midNum = (max + min) / 2;

                if (array[midNum] == SearchNumber)
                    return array[midNum];
                else if (array[midNum] < SearchNumber)
                {
                    min = midNum + 1;
                }
                else 
                {
                    max = midNum - 1;
                }
                
            }
            return -1;
        }
    }
}
