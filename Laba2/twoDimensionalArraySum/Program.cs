using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDimensionalArraySum
{
    class Program
    {
        static void Main(string[] args)
        {/*5.	Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от -100 до 100. 
          * Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.*/
            int iIndexMax = 0, jIndexMax = 0, iIndexMin = 0, jIndexMin = 0, sum = 0;
            int[,] randomArr = new int[5, 5];
            Random rn = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    randomArr[i, j] = rn.Next(-100, 100);
                    if (randomArr[iIndexMax, jIndexMax] < randomArr[i, j])
                    {
                        iIndexMax = i;
                        jIndexMax = j;
                    }
                    if (randomArr[iIndexMin, jIndexMin] > randomArr[i, j])
                    {
                        iIndexMin = i;
                        jIndexMin = j;
                    }
                }
            }
            //int iMaxVal = randomArr.Cast<int>().Max();
            //int iMinVal = randomArr.Cast<int>().Min();
            //Console.WriteLine(iMaxVal);
            //Console.WriteLine(iMinVal);

            foreach (int item in randomArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
           
            Console.WriteLine("Minimum - {0} in [{1}, {2}]; Maximum - {3} in [{4}, {5}]", randomArr[iIndexMin, jIndexMin],
                iIndexMin, jIndexMin, randomArr[iIndexMax, jIndexMax], iIndexMax, jIndexMax);

            if (iIndexMin < iIndexMax)
            {
                for (int i = iIndexMin; i <= iIndexMax; i++)
                {
                    for (int j = (i==iIndexMin?jIndexMin:0); j <=(i==iIndexMax?jIndexMax:4) ; j++)
                    {
                        sum += randomArr[i, j];
                    }
                } 
            }
            else
            {
                for (int i = iIndexMin; i >= iIndexMax; i--)
                {
                    for (int j = (i==iIndexMin?jIndexMin:4); j >= (i==iIndexMax?jIndexMax:0); j--)
                    {
                        sum += randomArr[i, j];
                    }
                }
                
            }
         Console.WriteLine("Sum of element betwen Max and Min is - {0}", sum);

        }
    }
}
