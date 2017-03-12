using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    public class Transaction
    {
        private decimal _sum;
        private decimal _balance;
        private DateTime _timeStamp;

        public Transaction(decimal balance, decimal sum, DateTime timeStamp)
        {
            _balance = balance;
            _timeStamp = timeStamp;
            _sum = sum;
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public decimal Sum
        {
            get { return _sum; }
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
        }

        public override string ToString()
        {
            return _timeStamp.ToString("dd/M/yyyy") + "\t " + _sum;
        }
    }

}
