using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    enum ListOfFigures { rectangle, rhomb, treangle, trapeze, polygon }
    enum ListOfColors { yellow = 1, green, red, blue }

    class Program
    {
        [DllImport("msvcrt")]

        static extern int _getch();

        private static void Main(string[] args)
        {
            int n = 5;
            string answer = "";

            ConsoleColor[] arrayOfColors = new ConsoleColor[5];

            GeneralizedFigure[] GFigure = new GeneralizedFigure[n];

            //Creat empty object, because in another case if i try to print objects in point 6 i catch error
            for (int i = 0; i < n; i++)
            {
                GFigure[i] = new Rectangle(0, 0);
            }
            try
            {
                while (true)
                {

                    for (int j = 0; j < n; j++)
                    {
                        Console.Clear();
                        Console.WriteLine("Figure_App");
                        Console.WriteLine("Menu");
                        Console.WriteLine("Choose figures for printing");
                        Console.WriteLine("1 - rectangle");
                        Console.WriteLine("2 - rhomb");
                        Console.WriteLine("3 - treangle");
                        Console.WriteLine("4 - trapeze");
                        Console.WriteLine("5 - polygon");
                        Console.WriteLine("6 - print figures");
                        Console.WriteLine("0 - exit");
                        switch (_getch())
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("You choose rectangle");
                                GFigure[j] = new Rectangle(8, 10);
                                arrayOfColors[j] = ColorOfFigures();
                                Console.WriteLine("Do you want to choose another one or print figures?Y/N");
                                answer = Console.ReadLine();
                                if (answer == "N" || answer == "n")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine("You choose rhomb");
                                GFigure[j] = new Rhomb(8);
                                arrayOfColors[j] = ColorOfFigures();
                                Console.WriteLine("Do you want to choose another one or print figures?Y/N");
                                answer = Console.ReadLine();
                                if (answer == "N" || answer == "n")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                break;
                            case '3':
                                Console.Clear();
                                Console.WriteLine("You choose treangle");
                                GFigure[j] = new Treangle(10);
                                arrayOfColors[j] = ColorOfFigures();
                                Console.WriteLine("Do you want to choose another one or print figures?Y/N");
                                answer = Console.ReadLine();
                                if (answer == "N" || answer == "n")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                break;
                            case '4':
                                Console.Clear();
                                Console.WriteLine("You choose trapeze");
                                GFigure[j] = new Trapeze(8, 10);
                                arrayOfColors[j] = ColorOfFigures();
                                Console.WriteLine("Do you want to choose another one or print figures?Y/N");
                                answer = Console.ReadLine();
                                if (answer == "N" || answer == "n")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }

                                break;
                            case '5':
                                Console.Clear();
                                Console.WriteLine("You choose polygon");
                                GFigure[j] = new Polygon(8, 10);
                                arrayOfColors[j] = ColorOfFigures();
                                Console.WriteLine("Do you want to choose another one or print figures?Y/N");
                                answer = Console.ReadLine();
                                if (answer == "N" || answer == "n")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                break;

                            case '6':
                                Console.WriteLine();
                                Console.WriteLine("Print of figures: ");

                                for (int i = 0; i < n; i++)
                                {

                                    Console.ForegroundColor = arrayOfColors[i];
                                    GFigure[i].PrintAllFigures();

                                    Console.WriteLine();

                                }
                                Console.ReadKey();
                                break;
                            case '0':
                                Console.WriteLine("Do you want to exit?Y/N");
                                answer = Console.ReadLine();
                                if (answer == "Y" || answer == "y")
                                {
                                    Console.WriteLine("Bye");
                                    return;
                                }
                                

                                break;
                        } 
                    }
                
                Console.ForegroundColor = ConsoleColor.Gray;

                }   
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
        }

        private static ConsoleColor ColorOfFigures()
        {
            ConsoleColor[] arrayOfColors = new ConsoleColor[5];
            Console.WriteLine("Choose color of figure for printing and press ENTER");
            Console.WriteLine("1 - yellow");
            Console.WriteLine("2 - green");
            Console.WriteLine("3 - red");
            Console.WriteLine("4 - blue");
            switch (int.Parse(Console.ReadLine()))
            {
                case (int)ListOfColors.yellow:
                    return arrayOfColors[0] = ConsoleColor.Yellow;
                    //break;
                case (int)ListOfColors.green:
                    return arrayOfColors[1] = ConsoleColor.Green;
                    //break;
                case (int)ListOfColors.red:
                    return arrayOfColors[2] = ConsoleColor.Red;
                    //break;
                case (int)ListOfColors.blue:
                    return arrayOfColors[3] = ConsoleColor.Blue;
                    //break;
            }
            return 0;
        }
    }
}
