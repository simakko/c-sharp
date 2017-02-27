using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    class Customer
    {
        public string FirstName;
        public string SurName;
        public string AccountNumber;


        public Customer(string firstName, string surName, string accountNumber)
        {
            FirstName = firstName;
            SurName = surName;
            AccountNumber = accountNumber;
        }

        public string FirstName1
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string SurName1
        {
            get { return SurName; }
            set { SurName = value; }
        }

        public string AccountNumber1
        {
            get { return AccountNumber; }
            set { AccountNumber = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
