using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib
{
    public class Tank
    {
        private string NameOfTank;
        private int LevelOfAllowanceOfAmmunition;
        private int LevelOfArmor;
        private int LevelOfMobility;
        Random ran = new Random();

        public Tank(string NameOfTank)
        {
            this.NameOfTank = NameOfTank;

            this.LevelOfAllowanceOfAmmunition = Randomaizer(ran);
            this.LevelOfArmor = Randomaizer(ran);
            this.LevelOfMobility = Randomaizer(ran);
        }

        static int Randomaizer(Random ran)
        {
            return ran.Next(0, 100);
        }

        public void GetAllowanceOfAmmunition()
        {
            Console.WriteLine("Level of allowance of ammunition: {0}", LevelOfAllowanceOfAmmunition);
        }

        public void GetLevelOfArmor()
        {
            Console.WriteLine("Level of armor: {0}", LevelOfArmor);
        }

        public void GetLevelOfMobility()
        {
            Console.WriteLine("Level of mobility: {0}", LevelOfMobility);
        }

        public void GetNameOfTank()
        {
            Console.WriteLine("Name of tank: " + NameOfTank);
        }
        
        public static string operator *(Tank panteraTank, Tank t34Tank)
        {
            if ((panteraTank.LevelOfAllowanceOfAmmunition * panteraTank.LevelOfArmor * panteraTank.LevelOfMobility >
                t34Tank.LevelOfAllowanceOfAmmunition * t34Tank.LevelOfArmor * t34Tank.LevelOfMobility))
                return panteraTank.NameOfTank;
            else 
                return t34Tank.NameOfTank;

        }

    }
}
