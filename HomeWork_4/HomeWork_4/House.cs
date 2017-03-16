using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class House
    {
        Basement basement;
        Walls[] walls;
        Door door;
        Window[] windows;
        Roof roof;

        public House()
        {
            this.basement = null;
            this.walls = new Walls[4];
            this.door = null;
            this.windows = new Window[4];
            this.roof = null;
        }

        public Basement BASEMENT
        {
            get { return basement; }
            set { basement = value; }
        }

        public Walls[] WALLS
        {
            get { return walls; }
            set { walls = value;}
        }

        public Door DOOR
        {
            get { return door; }
            set { door = value; }
        }

        public Window[] WINDOWS
        {
            get { return windows; }
        }

        public Roof ROOF
        {
            get { return roof; }
            set { roof = value; }
        }

        public bool isBasement()
        {
            if (basement == null)
                return true;
            else return false;
        }

        public int QuantityOfWalls()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                if (walls[i] == null)
                    return i;
            }
            return -1;
        }

        public bool isDoor()
        {
            if (door == null)
                return true;
            else return false;
        }

        public int QuantityOfWindows()
        {
            for (int i = 0; i < windows.Length; i++)
            {
                if (windows[i] == null)
                    return i;
            }
            return -1;
        }


        public bool isRoof()
        {
            if (roof == null)
                return true;
            else return false;
        }


        

    }
}
