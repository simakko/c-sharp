using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    public static class ReferenceChecker
    {
        public static string Checker(string referenceInput)
        {
            int length;
            int result;
            int multiplication;
            int sum = 0;
            string errorMessage = "Given reference number was incorrect!";
            string zeros ="";
            string reference;
            string multiplierNumbers = "7317317317317317317";
            char[] number;
            char[] multiplier;
            string[] reverseNumbers;
            string[] multiplierstr;


            if (String.IsNullOrEmpty(referenceInput))
            {
                Console.WriteLine(errorMessage);
                System.Threading.Thread.Sleep(1500);
                return "error";
            }

            reference = referenceInput.Substring(0, referenceInput.Length - 1);
            length = reference.Length;
            number = reference.ToCharArray();
            multiplier = multiplierNumbers.ToCharArray();

            List<string> multipliers = new List<string>();
            List<string> numbers = new List<string>();

            for (int i = 0; i < length; i++)
            {
                multipliers.Add(multiplier[i].ToString());
                numbers.Add(number[i].ToString());
            }

            reverseNumbers = numbers.ToArray();
            multiplierstr = multipliers.ToArray();

            Array.Reverse(reverseNumbers);

            for (int i = 0; i < length; i++)
            {
                multiplication = int.Parse(reverseNumbers[i]) * int.Parse(multiplierstr[i]);
                sum += multiplication;
            }

            result = (10 - sum % 10);
            if (result == 10)
            {
                result = 0;
            }
            if (result != int.Parse(referenceInput.Substring(referenceInput.Length - 1)))
            {
                Console.WriteLine(errorMessage);
                System.Threading.Thread.Sleep(1500);
                return "error";
            }

            for (int i = 0; 20 - reference.Length > i; i++)
            {
                zeros += "0";
            }


            return zeros + reference;
        }
    }
}
