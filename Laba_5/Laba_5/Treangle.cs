using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Treangle:GeneralizedFigure
    {
        private int heightOfTreangle;
        public Treangle(int heightOfTreangle)
        {
            this.heightOfTreangle = heightOfTreangle;
        }

        public int HeightOfTreangle
        {
            get { return heightOfTreangle;}
        }

        public override void PrintAllFigures()
        {
            Console.WriteLine("Treangle");
            Console.WriteLine();
            int i, j, N = heightOfTreangle;
            int center;
            center = heightOfTreangle/2;

            for (i = 0; i < center; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (j >= center - i && j <= center + i)
                    
                        Console.Write("$");
                    
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
