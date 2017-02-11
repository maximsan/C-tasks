using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPalindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.	Пользователь вводит строку. Проверить, является ли эта строка палиндромом. 
             * Палиндромом называется строка, которая одинаково читается слева направо и справа налево.*/
            Console.WriteLine("Input sentene: ");
            string strNew = Console.ReadLine();
            char[] cArray = strNew.ToCharArray();
            //string strPalindrom = strNew;

            Array.Reverse(cArray);
            
            string str = new string(cArray);

            //Console.Write("");
            Console.WriteLine("Is this palindrom? - " + str.Equals(strNew));
        }
    }
}
