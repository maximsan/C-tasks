using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quantityOfWordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input sentence: ");
            string strNew = Console.ReadLine();
            string[] strArray = strNew.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int iQuantuty = strArray.Length;
            Console.WriteLine("Quanitity of words is - {0}", iQuantuty);
        }
    }
}
