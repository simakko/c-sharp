using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    public class Bank
    {
        private string _name;
        private List<BankAccount> _accounts; //List of account numbers
        private Random _random;

        public Bank(string name)
        {
            _name = name;
            _accounts = new List<BankAccount>();
            _random = new Random(DateTime.Now.Millisecond);
        }

        public string NewAccount() //Tilin luominen kutsuu tätä metodia
        {
            BankAccount account = new BankAccount(RandomAccountNumber());
            _accounts.Add(account);
            return account.AccountNumber;
        }

        private string RandomAccountNumber()
        {          
            string stringBuilder = "";

            for (int i = 0; i < 16; i++)
            {
                stringBuilder += _random.Next(1, 10).ToString();
            }
            return "FI" + stringBuilder;
        }

        public List<Transaction> GetTransactions(string accountNumber)
        {
            BankAccount customersAccount = _accounts.First(account => account.AccountNumber == accountNumber);
            List<Transaction> transactions = customersAccount.GiveTransactions();
            return transactions;
        }

        public List<Transaction> GetCertainTransactions(string accountNumber, DateTime beginDate, DateTime toDate)
        {
            BankAccount customersAccount = _accounts.First(account => account.AccountNumber == accountNumber);
            List<Transaction> certainTransactions = customersAccount.GiveCertainTransactions(beginDate, toDate);
            return certainTransactions;
        }

        public decimal GetAccountBalance(string accountNumber)
        {
            BankAccount customersAccount = _accounts.First(account => account.AccountNumber == accountNumber);
            return customersAccount.GiveAccountBalance();
        }

        public void AddTransaction(string accountNumber, decimal sum, DateTime timeStamp) //Luodaan tilitapahtumat
        {
            BankAccount customersAccount = _accounts.First(account => account.AccountNumber == accountNumber);
            customersAccount.AddTransaction(sum, timeStamp);
        }
    }
}
