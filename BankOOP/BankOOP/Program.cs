using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Bank bank = new Bank("Pankki");
                List<Customer> customers = new List<Customer>();
                customers.Add(new Customer("Jaana", "Joki", bank.NewAccount()));
                customers.Add(new Customer("Reino", "Rotko", bank.NewAccount()));
                customers.Add(new Customer("Kalevi", "Kullervo", bank.NewAccount()));

                foreach (var customer in customers)
                {
                    AddRandomActivities(bank, customer);
                }

                var date = AskForInput();
                
                foreach (var customer in customers)
                {
                    PrintActivities(bank, customer, date.Item1,date.Item2);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred:\n" + e.Message);
                Console.ReadKey();
            }

        }

        static void AddRandomActivities(Bank bank, Customer customer)
        {
            decimal _sum;
            decimal _balance;
            int _year;
            int _month;
            int _day;
            DateTime _time;
            Random _random = new Random();
            _year = _random.Next(2000, 2016);
            _month = _random.Next(1, 12);
            _day = _random.Next(1, 28);
            _time = new DateTime(_year, _month, _day);
            bank.AddTransaction(customer.AccountNumber, _random.Next(1000, 100000),
                new DateTime(_year, _month, _day));
            Console.WriteLine(customer + "\nAccount balance: \t" +
                              bank.GetAccountBalance(customer.AccountNumber) + " EUR\n\n");

            for (int i = 0; i < 10; i++) // Adding random transactions to every account
            {
                _sum = _random.Next(10, 10000);
                _balance = bank.GetAccountBalance(customer.AccountNumber);
                do
                {
                    _year = _random.Next(2000, 2016);
                    _month = _random.Next(1, 12);
                    _day = _random.Next(1, 28);
                } while (new DateTime(_year, _month, _day) < _time);
                if (_balance - _sum >= 0)
                {
                    bank.AddTransaction(customer.AccountNumber, _sum * -1, new DateTime(_year, _month, _day));
                }
            }
        }

        static Tuple<DateTime, DateTime> AskForInput()
        {
            DateTime from;
            DateTime to;

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("View account transactions:\nGive a date to start out");
            while (!DateTime.TryParse(Console.ReadLine(), out from))
            {
                Console.WriteLine("\nDate wasn't valid. Enter date in (yy.mm.dd) form");
            }
            Console.WriteLine("\n\nGive a date where to end up");

            while (!DateTime.TryParse(Console.ReadLine(), out to))
            {
                Console.WriteLine("\nDate wasn't valid. Enter date in (yy.mm.dd) form");
            }
            Console.Clear();
            return Tuple.Create(from, to);
        }

        static void PrintActivities(Bank bank, Customer customer, DateTime from, DateTime to)
        {
            Console.WriteLine(customer.FirstName + " " + customer.SurName + "\n" + customer.AccountNumber + "\n");
            var transactionList = bank.GetCertainTransactions(customer.AccountNumber, from, to);
            //var transactionList = _bank.GetTransactions(customer.AccountNumber);
            foreach (var transaction in transactionList)
            {
                Console.WriteLine("\t" + transaction);
            }
            Console.WriteLine("\nAccount balance: \t" + bank.GetAccountBalance(customer.AccountNumber) + " EUR\n\n\n");
        }
    }
}
