using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace homework_2

{
    partial class Lighter
    {
        public void changeSizeOfModel(int _sizeOfModel)
        {
            this.iSizeOfModel = _sizeOfModel;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 34, newNumber = 38;
            Lighter L1 = new Lighter();
            Lighter L2 = new Lighter("Moroko",020,"White");
            Lighter L3 = new Lighter(340);
            L1.ShowNameOfLighter();
            Console.WriteLine("Number of model of lighter is {0}", L2.GetNumberOfModel());
            Console.WriteLine("Number of model of lighter is {0}", L1.GetNumberOfModel());
            L1.SetNumberOfModel(firstNumber);
            Console.WriteLine("Number of model of lighter is {0}", L1.GetNumberOfModel());
            L1.ChangeNumbers(ref newNumber);
            Console.WriteLine("Number of model of lighter is {0}", L1.GetNumberOfModel());
            Console.WriteLine(newNumber);
            Console.WriteLine(Lighter.priceOfLighter);
            Console.WriteLine(Lighter.nameOfMechanism);
            Console.WriteLine();
            /*check working of partial class*/

            L1.changeSizeOfModel(56);
            Console.WriteLine(L1.iSizeOfModel);

            /*Creating of array. Because I want to check how it works, 
             * how to add new features to object of class directly in array,
             * I change the modifacation of access from private to public*/

            Lighter [] array = new Lighter[5];
            for (int i = 0; i < 2; i++)
            {
                array[i] = new Lighter();
                Console.WriteLine("Input number of model of Lighter");
                array[i].iNumberOfModel = int.Parse(Console.ReadLine());
                Console.WriteLine("Input name of color");
                array[i].nameOfColor = Console.ReadLine();
            
            }
            Console.WriteLine(array[1].iNumberOfModel);
 
        }
    }
}

