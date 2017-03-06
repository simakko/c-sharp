using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    public class BankAccount
    {
        private string _accountNumber;
        private decimal _accountBalance;
        private List<Transactions> _transactions;

        public BankAccount(string accountNumber)
        {
            _accountNumber = accountNumber;
            _transactions = new List<Transactions>(); //Luodaan uusi lista jokaiselle tilille
        }

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public void AddTransaction(decimal sum, DateTime timeStamp) // Lisätään kaikki tilitapahtumat listaan
        {
            _accountBalance = _accountBalance + sum;
            _transactions.Add(new Transactions(_accountBalance, sum, timeStamp));
        }

        public List<Transactions> GiveTransactions()
        {
            List<Transactions> transactions = (from transaction in _transactions orderby transaction.TimeStamp
                                               select transaction).ToList();
            return transactions;
        }

        public List<Transactions> GiveCertainTransactions(DateTime beginDate, DateTime toDate)
        {
            List<Transactions> certainTransactions = (from transaction in _transactions
                                                      where transaction.TimeStamp >= beginDate
                                                      where transaction.TimeStamp <= toDate
                                                      orderby transaction.TimeStamp
                                                      select transaction).ToList();

            return certainTransactions;
        }

        public decimal GiveAccountBalance()
        {
            return _accountBalance;
        }

    }
}
