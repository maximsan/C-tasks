using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescsriptionOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your number ");
            string yourNumber = Console.ReadLine();
            int iNumber = int.Parse(yourNumber);
            int temp;

            string strThird = null;
            string strTwo = null, strOne = null;

            

                int iNumeral;
                temp = iNumber;
                iNumeral = iNumber / 100;
                iNumber = temp - iNumeral * 100;

                switch (iNumeral)
                {
                    case 1: strOne = "сто "; break;
                    case 2: strOne = "двести "; break;
                    case 3: strOne = "триста "; break;
                    case 4: strOne = "четыреста "; break;
                    case 5: strOne = "пятьсот "; break;
                    case 6: strOne = "шестьсот "; break;
                    case 7: strOne = "семьсот "; break;
                    case 8: strOne = "восемьсот "; break;
                    case 9: strOne = "девятьсот "; break;
                }
                if (iNumber>9 && iNumber<20)
                {
                switch (iNumber)
                    {
                    case 10: strTwo = "деcять"; break;
                    case 11: strTwo = "одиннадцать"; break;
                    case 12: strTwo = "двенадцать"; break;
                    case 13: strTwo = "тринадцать"; break;
                    case 14: strTwo = "четырнадцать"; break;
                    case 15: strTwo = "пятнадцать"; break;
                    case 16: strTwo = "шестнадцать"; break;
                    case 17: strTwo = "семнадцать"; break;
                    case 18: strTwo = "восемнадцать"; break;
                    case 19: strTwo = "девятнадцать"; break;
                    }
                }
                else if (iNumber<10){
                    switch (iNumber)
                    {
                        case 1: strThird = "один"; break;
                        case 2: strThird = "два"; break;
                        case 3: strThird = "три"; break;
                        case 4: strThird = "четыре"; break;
                        case 5: strThird = "пять"; break;
                        case 6: strThird = "шесть"; break;
                        case 7: strThird = "семь"; break;
                        case 8: strThird = "восемь"; break;
                        case 9: strThird = "девять"; break;
                    }
                }
                else 
                {
                    temp = iNumber;
                    iNumber = iNumber / 10;
                    switch (iNumber)
                    {
                     case 2: strTwo = "двадцать "; break;
                     case 3: strTwo = "тридцать "; break;
                     case 4: strTwo = "сорок "; break;
                     case 5: strTwo = "пятьдесят "; break;
                     case 6: strTwo = "шестьдесят "; break;
                     case 7: strTwo = "семьдесят "; break;
                     case 8: strTwo = "восемьдесят "; break;
                     case 9: strTwo = "девяносто "; break;
                    }
                    iNumber = temp % 10;
                    switch (iNumber)
                    {
                        case 1: strThird = "один"; break;
                        case 2: strThird = "два"; break;
                        case 3: strThird = "три"; break;
                        case 4: strThird = "четыре"; break;
                        case 5: strThird = "пять"; break;
                        case 6: strThird = "шесть"; break;
                        case 7: strThird = "семь"; break;
                        case 8: strThird = "восемь"; break;
                        case 9: strThird = "девять"; break;
                    }
                }
           
            Console.WriteLine("Your number is " + strOne + strTwo + strThird);

            //int val = (int)Char.GetNumericValue('8');

            Console.WriteLine(val);
        }
    }
}
