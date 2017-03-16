using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_4
{
    class Team
    {
        Worker[] team = new Worker[11];

        bool completeOfBuilding;
        public Team()
        {
            for (int i = 0; i < team.Length; i++)
            {
                team[i] = new Worker( i+1, ("Worker "+(i+1)));
            }
        }

        public void BuildOfHouse(House house)
        {

            for (int i = 0; i < team.Length; i++)
            {
                team[i].Check(house);
                //team[i].Build();
            }
            //completeOfBuilding = true;
            Console.WriteLine("Building is over!");
        }


    }
}
