using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Polygon:GeneralizedFigure
    {
        private int heightOfPolygon;
        private int sideOfPolygon;


        public Polygon (int heightOfPolygon, int sideOfPolygon)
        {
            this.heightOfPolygon = heightOfPolygon;
            this.sideOfPolygon = sideOfPolygon;
        }
        public int HeightOfPolygon
        {
            get { return heightOfPolygon;}
        }

        public int SideOfPolygon
        {
            get { return sideOfPolygon;}
        }
        public override void PrintAllFigures()
        {
            Console.WriteLine("Polygon");
            Console.WriteLine();
            int i, j;
            int center1 = heightOfPolygon;

            for (i = 0; i < center1; i++)
            {
                for (j = 0; j < heightOfPolygon * 2; j++)
                {
                    if (j >= center1 - i && j <= center1 + i)

                        Console.Write("$");

                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (i = 0; i < sideOfPolygon; i++)
            {
                for (j = 0; j <= heightOfPolygon*2; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }


            for (i = 0; i < center1; i++)
            {
                for (j = 0; j < heightOfPolygon * 2; j++)
                {
                    // Нижняя половина ромба
                    if (j >= center1 + i - heightOfPolygon + 1 && j <= center1 - i + heightOfPolygon - 1)
                        Console.Write("$");
                    else
                        Console.Write(" ");
                 }
                Console.WriteLine();
             }
                

        }
    }
}
