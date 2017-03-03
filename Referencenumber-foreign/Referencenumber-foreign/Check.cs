using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencenumber_foreign
{
    public static class Check
    {
        public static string CheckNumbers(string input)
        {
            int length = input.Length;
            char[] number = input.ToCharArray();
            char[] multiplier = "7317317317317317317".ToCharArray();                             //Creating array of multipliers

            List<string> multipliers = new List<string>();
            List<string> numbers = new List<string>();

            for (int i = 0; i < length; i++)                                                     //Creating list out of input numbers and getting same amount of multipliers from multiplier array
            {
                multipliers.Add(multiplier[i].ToString());
                numbers.Add(number[i].ToString());
            }

            string[] reverseNumbers = numbers.ToArray();                                        //Convert lists to array and reversing input numbers to match multipliers
            string[] multiplierstr = multipliers.ToArray();

            Array.Reverse(reverseNumbers);

            int a = 0;
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                a = int.Parse(reverseNumbers[i]) * int.Parse(multiplierstr[i]);                 // Multiplying input numbers with multipliers and adding all sums together
                sum += a;
            }


            int vNum = (10 - sum % 10);                                                          //Calculating validating number 1

            if (vNum == 10)
            {
                vNum = 0;
            }

            string referenceFi = input + vNum.ToString();
            decimal combineline2 = decimal.Parse(referenceFi + "271500");

            decimal result = 98 - (combineline2 % 97);                                            //Calculating validating code

            string vCode = result.ToString();                                                     //Changing code to string and adding zero infront, if needed

            if (result <= 10)
            {
                vCode = "0" + result.ToString();
            }


            decimal validateLine = decimal.Parse(referenceFi + "2715" + result) % 97;             //Validating

            if (validateLine == 1)
            {
                string referencenumber = "RF" + vCode + referenceFi;
                // string iban = country += referenceFi;
                return referencenumber;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Referencenumber is not valid");
                Console.ReadKey();
                Environment.Exit(0);
            }

            return "0";

        }
    }
}
