using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Rhomb:GeneralizedFigure
    {
         private int heightOfRhomb;

        public Rhomb(int heightOfRhomb)
        {
            this.heightOfRhomb = heightOfRhomb;
        }

        public int HeightOfRhomb
        {
            get { return heightOfRhomb;}
        }
        public override void PrintAllFigures()
        {
            //string[][] newArray = new string[heightOfRhomb][];
            //int l = heightOfRhomb;
            //
            //for (int i = 0; i < this.heightOfRhomb; i++)
            //{
            //    for (int j = 1; j <= this.heightOfRhomb*2; j+=2)
            //    {
            //        newArray[i] = new string[j];
            //        for (int k = l; k <= l && l <= this.heightOfRhomb * 2; k--)
            //        {
            //            newArray[i][k] = "$";
            //            Console.WriteLine(newArray[i][k]);
            //        }
            //        Console.WriteLine();
            //    }
            //    
            //}
            Console.WriteLine("Rhomb");
            Console.WriteLine();
            int i, j, N = heightOfRhomb*2;
            int center = N / 2;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i <= center)
                    {
                        // Верхняя половина ромба
                        if (j >= center - i && j <= center + i)
                            Console.Write("$");
                        else
                            Console.Write(" ");
                    }
                    else
                    {
                        // Нижняя половина ромба
                        if (j >= center + i - N + 1 && j <= center - i + N - 1)
                            Console.Write("$");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}
