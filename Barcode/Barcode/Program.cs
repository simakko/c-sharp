using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            string validIban;
            string validReference;
            string validSum;
            string validDate;
            string iban;
            string reference;
            string sum;
            string date;
            string barcode;

            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter your Iban banknumber");
                    iban = Console.ReadLine();
                    validIban = IbanChecker.Checker(iban);
                } while (validIban == "error");

                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the reference number");
                    reference = Console.ReadLine();
                    validReference = ReferenceChecker.Checker(reference);
                } while (validReference == "error");

                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the bills sum");
                    sum = Console.ReadLine();
                    validSum = SumCheck.Checker(sum);
                } while (validSum == "error");

                do
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the due date of the bill in form dd.mm.yy");
                    date = Console.ReadLine();
                    validDate = DateCheck.Check(date);
                } while (validDate == "error");

                barcode = BarcodeCreator.Creator(validIban, validSum, validReference, validDate);
                Console.Clear();
                Console.WriteLine("Your barcode is:\n");
                Console.WriteLine(barcode);
                Console.ReadKey();

            }
            catch (IOException e)
            {
                Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
        }
    }
}
