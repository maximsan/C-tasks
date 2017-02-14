using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    
    partial class Lighter
    {

            public /*private*/  string nameOfProducer = "Criket";
            public /*private*/  string nameOfLighter = "Fires";
            public /*private*/  int iNumberOfModel = 029;
            public /*private*/  string nameOfColor = "Black";
            public /*private*/  int iSizeOfModel = 30;
            public /*private*/ int quantityOfLighters;

            public static double priceOfLighter;
            public static string nameOfMechanism;
       
        public Lighter()
        {
            this.iNumberOfModel = 0;
            this.nameOfColor = nameOfColor;
            this.nameOfLighter = nameOfLighter;
            this.nameOfProducer = nameOfProducer;
            Console.WriteLine("This is Lighter");
        }

        public Lighter(string nameOfProducer, int iNumberOfModel, string nameOfColor)
        {
            Console.WriteLine("Name of producer: {0}, name of color: {2}, number of model: {1}", 
                this.nameOfProducer = nameOfProducer, this.iNumberOfModel = iNumberOfModel, this.nameOfColor = nameOfColor);
        }

        public Lighter(int quantityOfLighters)
        {
            this.quantityOfLighters = quantityOfLighters;
            Console.WriteLine("Quantity of lighters: {0}", this.quantityOfLighters);
        }

        static Lighter()
        {
            priceOfLighter = 100;
            nameOfMechanism = "quickFly";
        }

        public void ShowNameOfLighter()
        {
            Console.WriteLine(nameOfLighter);
        }

        public void ShowNameOfProducer()
        {
            Console.WriteLine(nameOfProducer);
        }

        public void ShowNameOfColor()
        {
            Console.WriteLine(nameOfColor);
        }

        public int GetNumberOfModel()
        {
            return iNumberOfModel;
        }

        public void SetNumberOfModel(int iNumberOfModel)
        {
            this.iNumberOfModel = iNumberOfModel;
        }

        public int ChangeNumbers(ref int newNumber)
        {
            if (newNumber != this.iNumberOfModel && newNumber > 0)
            {
                int temp = this.iNumberOfModel;
                this.iNumberOfModel = newNumber;
                newNumber = temp;
            }
            return newNumber;
        }

    }
}
