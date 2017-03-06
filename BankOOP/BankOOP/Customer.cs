using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    public class Customer
    {
        private string _firstName;
        private string _surName;
        private string _accountNumber;

        // static metodin arvoja voi kutsua ilman olion käyttämistä

        public Customer(string firstName, string surName, string accountNumber)
        {
            _firstName = firstName;
            _surName = surName;
            _accountNumber = accountNumber;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string SurName
        {
            get { return _surName; }
            set { _surName = value; }
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public override string ToString()
        {
            return _firstName + " " +_surName+ "\t " + _accountNumber;
        }
    }
}
