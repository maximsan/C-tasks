using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    class RangeOFArray
    {
        private int _minIndexOfArray; 
        private int _maxIndexOfArray;
 
        public int minIndexOfArray
        {
            set {_minIndexOfArray = value;}
            get { return _minIndexOfArray;}
        }

        public int maxIndexOfArray
        {
            get { return _maxIndexOfArray; }
            set { _maxIndexOfArray = value; }
        }

        public void createOfArray ()
        {
            int[] myArray = new int[this._maxIndexOfArray - this._minIndexOfArray + 1];
            
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(0,100);
            }

            Console.WriteLine("You array with your own number of index will look like:");
            int temp = this._minIndexOfArray;
            foreach (var item in myArray)
            {
                
                Console.Write(item + " [" + temp++ + "] ");
            }
            Console.WriteLine();
        }
  
    }
}
