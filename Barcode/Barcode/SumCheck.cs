using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    public static class SumCheck
    {
        public static string Checker(string sum)
        {
            decimal sumFormat;
            string roundedSum;
            string zero = "";
            string sumDecimal;
            string wholeSum;
            string validSum;
            string errorMessage = "Given sum was incorrect!";
            string[] sumArray;

            if (String.IsNullOrEmpty(sum))
            {
                Console.WriteLine(errorMessage);
                System.Threading.Thread.Sleep(1500);
                return "error";
            }

            sumFormat = Math.Round(decimal.Parse(sum),2);
            roundedSum = sumFormat.ToString();
            sumArray = roundedSum.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries);
            if (sumArray.ElementAtOrDefault(1) == null)
            {
                Array.Resize(ref sumArray, sumArray.Length + 1);
                sumArray[1] = "00";
            }
            if ((sumArray[0].Length) + (sumArray[1].Length) > 8)
            {
                Console.WriteLine("Bill sum is too large!");
                System.Threading.Thread.Sleep(1500);
                return "error";
            }
            for (int i = 0; sumArray[1].Length+i < 2; i++)
            {
                zero += "0";
            }
            sumDecimal = sumArray[1] + zero;
            wholeSum = sumArray[0] + sumDecimal;
            zero = "";
            for (int i = 0; wholeSum.Length + i < 8; i++)
            {
                zero += "0";
            }
            validSum = zero + wholeSum;
            return validSum;
        }
    }
}
