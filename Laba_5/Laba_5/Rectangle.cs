using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Rectangle:GeneralizedFigure
    {
        private int widthOfRectangle;
        private int heightOfRectangle;

        public Rectangle(int heightOfRectangle, int widthOfRectangle)
        {
            this.widthOfRectangle = widthOfRectangle;
            this.heightOfRectangle = heightOfRectangle;
        }

        public int WidthOfRectangle
        {
            get { return widthOfRectangle; }
        }

        public int HeightOfRectangle
        {
            get { return heightOfRectangle;}
        }
        public override void PrintAllFigures()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine();
            for (int i = 0; i < this.heightOfRectangle; i++)
            {
                for (int j = 0; j < this.widthOfRectangle; j++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
        }
    }
}
