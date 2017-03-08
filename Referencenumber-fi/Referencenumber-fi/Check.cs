using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencenumber_fi
{
    public static class Check
    {
        public static string CheckNumbers(string input)
        {
            int length = input.Length;
            char[] number = input.ToCharArray();
            char[] multiplier = "7317317317317317317".ToCharArray();

            List<string> multipliers = new List<string>();
            List<string> numbers = new List<string>();

            for (int i = 0; i < length; i++)
            {
                multipliers.Add(multiplier[i].ToString());
                numbers.Add(number[i].ToString());
            }

            string[] reverse_numbers = numbers.ToArray();
            string[] multiplierstr = multipliers.ToArray();

            Array.Reverse(reverse_numbers);

            int a = 0;
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                a = int.Parse(reverse_numbers[i]) * int.Parse(multiplierstr[i]);
                sum += a;
            }

            int result = (10 - sum % 10);
            if (result == 10)
            {
                result = 0;
            }

            return result.ToString();

        }
    }
}
