using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Worker : IWorker
    {
        //House house;

        string nameOfWorker;

        int number;

        //int j;
        public Worker(int number, string nameOfWorker) 
        { 
            this.nameOfWorker = nameOfWorker;
            this.number = number;
        }

        public void Check(House house)
        {
            
            if (house.isBasement())
            {
                house.BASEMENT = new Basement();
                Console.WriteLine("Worker №{0} builds basement", 1);
                house.BASEMENT.Building();
                return;
            }
            if (house.QuantityOfWalls() >= 0)
            {
                int i = house.QuantityOfWalls();
                house.WALLS[i] = new Walls();
                Console.WriteLine("Worker №{0} builds wall №{1}", 2 + i, i);
                house.WALLS[i].Building();
                return;
            }
            if (house.isRoof())
            {
                house.ROOF = new Roof();
                Console.WriteLine("Worker №{0} builds roof",  6);
                house.ROOF.Building();
                return;
            }
            if (house.QuantityOfWindows() >= 0)
            {
                int i = house.QuantityOfWindows();
                house.WINDOWS[i] = new Window();
                Console.WriteLine("Worker №{0} builds window №{1}", 6 + i, i);
                house.WINDOWS[i].Building();
                return;
            }
            if (house.isDoor())
            {
                house.DOOR = new Door();
                Console.WriteLine("Worker № {0} builds door", 10);
                house.DOOR.Building();
                return;
            }

        }


    }
}
