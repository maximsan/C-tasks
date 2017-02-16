using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private int _numberOfAccount;
        private int _passwordOfAccount;
        public Account ()
        {
            Console.WriteLine("Creating of new account in bank");
            Random number = new Random();
            Console.Write("Number of account:");
            _numberOfAccount = number.Next(10, 1000);
            Console.WriteLine(_numberOfAccount);
            Console.Write("Password of account:");
            _passwordOfAccount = number.Next(1, 10);
            Console.WriteLine(_passwordOfAccount);
        }

        public int numberOfAccount
        {
            set { _numberOfAccount = value; }
            get { return _numberOfAccount; }
        }

        public int passwordOfAccount
        {
            set { _passwordOfAccount = value; }
            get { return _passwordOfAccount; }
        }
    }
}
