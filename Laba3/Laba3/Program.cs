using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Laba3;

namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("msvcrt")]

        static extern int _getch();
        static void Main(string[] args)
        {
            RangeOFArray MyArray = new RangeOFArray();
            bool start = true;
            while (start)
            {
            Start: Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("Choose \"1\" if you want to creat new array");
                Console.WriteLine("Choose \"2\" if you want to creat new array with new minimum index of array");
                Console.WriteLine("Choose \"3\" if you wnat to creat new array with new maximum index of array");
                Console.WriteLine("Input \"0\" for exit from application");
                switch (_getch())
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("Input minimum index for your array:");
                        MyArray.minIndexOfArray = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input maximum index for your array:");
                        MyArray.maxIndexOfArray = int.Parse(Console.ReadLine());
                        MyArray.createOfArray();
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Input minimum index for your array:");
                        MyArray.minIndexOfArray = int.Parse(Console.ReadLine());
                        MyArray.createOfArray();
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Input maximum index for your array:");
                        MyArray.maxIndexOfArray = int.Parse(Console.ReadLine());
                        MyArray.createOfArray();
                        Console.ReadKey();
                        break;
                    case '0':
                        Console.WriteLine("Are you shure???N/Y");
                        char answer = char.Parse(Console.ReadLine());
                        if (answer == 'N' || answer == 'n')
                        goto Start;
                        else start = false;
                        break;
                }
                Console.WriteLine("Bye, Bye!");
            }
           
        }

           
           ////Console.WriteLine("Input maximum index for your array:");
           ////MyArray.maxIndexOfArray = int.Parse(Console.ReadLine());
           
           //MyArray.createOfArray();

           //MyArray.maxIndexOfArray = int.Parse(Console.ReadLine());
           //MyArray.createOfArray();

           // // MyArray.printOfArray();
        
    }
}