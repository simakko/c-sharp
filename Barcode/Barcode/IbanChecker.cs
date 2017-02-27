using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    public static class IbanChecker
    {
        public static string Checker(string iban)
        {
            string validIban;
            string countrycode = "1518";
            string validaterNum;
            string combineline;
            string validatingSum;
            string errorMessage = "Given iban number was incorrect!";
            decimal combineline2;
            decimal result;
            decimal tryparse;
            decimal validateLine;

            if (iban.Length < 18 || decimal.TryParse(iban.Substring(2), out tryparse) == false || String.IsNullOrEmpty(iban))
            {
                Console.WriteLine(errorMessage);
                System.Threading.Thread.Sleep(1500);
                validIban = "error";
                return validIban;
            }

            validaterNum = iban.Substring(2, 2);
            combineline = iban.Substring(4);
            combineline2 = decimal.Parse(combineline + countrycode + "00");

            result = 98 - (combineline2 % 97);                                              //Calculating validating code

            validatingSum = result.ToString();                                                           //Changing code to string and adding zero infront, if needed
            if (result <= 10)
            {
                validatingSum = "0" + result.ToString();
            }

            validateLine = decimal.Parse(combineline + countrycode + result) % 97;                 //Validating iban

            if (validateLine == 1)
            {
                validIban = validatingSum += combineline;
            }
            else
            {
                Console.WriteLine(errorMessage);
                System.Threading.Thread.Sleep(1500);
                validIban = "error";
            }
            if (result.ToString() != validaterNum)
            {
                Console.WriteLine(errorMessage);
                System.Threading.Thread.Sleep(1500);
                validIban = "error";
            }

            return validIban;
        }

    }
}