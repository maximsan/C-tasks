using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class TeamLeader : IWorker
    {
        public TeamLeader() { }
        public void Check (House house)
        {
            Console.WriteLine("Checkinf of the building");
            if (!house.isBasement())
            {
                Console.WriteLine("The basement was built");
            }
            if (house.QuantityOfWalls() >= 0)
            {
                Console.WriteLine("The {0} walls were built");
            }
            else
            {
                Console.WriteLine("The 4 walls were built");
            }

            if  (!house.isRoof())
            {
                Console.WriteLine("The roof were built");
            }
            if (house.QuantityOfWindows()>=0)
            {
                Console.WriteLine("The {0} windows were built");
            }
            else 
            {
                Console.WriteLine("The 4 windows were built");
            }
            if(!house.isDoor())
            {
                Console.WriteLine("The door was built");
            }
            //return true;
            Console.WriteLine("Building is over!");
        }

        public void PrintingHouse(House house)
        {
            house.ROOF.ShowPartOfHouse();
            for (int i = 0; i < 4; i++)
            {
                house.WALLS[i] = new Walls();
                //walls[i].ShowPartOfHouse();
                house.WALLS[i].ShowPartOfHouse();
            }
            house.BASEMENT.ShowPartOfHouse();
        }

    }
}
