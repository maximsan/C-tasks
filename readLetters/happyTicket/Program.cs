using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of your ticket of tram:");
            string strTicket = Console.ReadLine();
            int iNumOfTicket = int.Parse(strTicket);
            int iFirstNumeral = iNumOfTicket / 1000;
            int iSecondNumeral = iNumOfTicket % 1000;
            int iFirstSum = 0;
            int iSecondSum = 0;
            for (int i = 0; i < 3; i++)
            {
                iFirstSum += iFirstNumeral % 10;
                iFirstNumeral = iFirstNumeral / 10;
            }
            for (int i = 0; i < 3; i++)
            {
                iSecondSum += iSecondNumeral % 10;
                iSecondNumeral = iSecondNumeral / 10;
            }
            if (iFirstSum == iSecondSum)
                Console.WriteLine("Your ticket is Happy!");
            else
            {
                Console.WriteLine("Your ticket is decepiton!");
            }

        }
    }
}
