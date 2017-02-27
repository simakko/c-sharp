using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP
{
    class Program
    {

        static void Main(string[] args)
        {

            Bank bank = new Bank();
            Customer customer = new Customer("Pirkko", "Niemi", "123456");
            Customer customer2 = new Customer("Kalle", "Kekäle", "123457");
            Customer customer3 = new Customer("Jaana", "Koskela", "123458");



        }
    }
}
