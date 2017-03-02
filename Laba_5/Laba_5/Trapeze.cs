using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Trapeze:GeneralizedFigure
    {
        private int heightOfTrapeze;
        private int upperSideOfTrapeze;

        public Trapeze(int heighOfTrapeze, int upperSideOfTrapeze)
        {
            this.heightOfTrapeze = heighOfTrapeze;
            this.upperSideOfTrapeze = upperSideOfTrapeze;
        }

        public int HeightOfTrapeze
        {
            get { return heightOfTrapeze;}
        }
        public override void PrintAllFigures()
        {
            Console.WriteLine("Trapeze");
            Console.WriteLine();
            int i, j, h = heightOfTrapeze;
            int a = upperSideOfTrapeze;
            
            for (i = h; i > 0; i--)
            {
                for (j = 0; j < (a+h); j++)
                {
                    if((j <= i/2 - 1)||(j >= a + h - i/2))
                        Console.Write(" ");
                    else Console.Write("$");
                }
                Console.WriteLine();
            }

        }
    }
}
