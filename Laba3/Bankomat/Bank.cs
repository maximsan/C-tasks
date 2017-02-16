using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    using Account;
    class Bank
    {
        Account NewAccount = new Account(); 

        private int _initialSum;
        public int initialSum
        {
            set { _initialSum = value; }
            get { return _initialSum; }
        }

        public int returnNumber()
        {
            return NewAccount.passwordOfAccount;
        }

        public int AddSumOnAccount(int addSum)
        {
            return initialSum += addSum;
        }

        public int WithdrawCash(int minusSum)
        {
            return initialSum -= minusSum;
        }

    }
}
