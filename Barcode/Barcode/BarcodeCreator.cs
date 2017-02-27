using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    public static class BarcodeCreator
    {
        public static string Creator(string validIban, string validSum, string validReference, string validDate)
        {
            string checkBarcode;
            string barcode;
            string initialMark = "105";
            string endMark = "STOP";
            string versionMark = "4";
            string[] numPairArray;
            int multipliedSum = int.Parse(initialMark); //initial mark is added as default value
            int validateSum;

            checkBarcode = versionMark + validIban + validSum + validReference + validDate;

            List<string> numberPairs = new List<string>();

            for (int i = 0; i < checkBarcode.Length; i++)
            {
                numberPairs.Add(checkBarcode[i].ToString() + checkBarcode[i++].ToString());
                i++;
            }

            numPairArray = numberPairs.ToArray();

            for (int i = 0; i < numPairArray.Length; i++)
            {
                multipliedSum += int.Parse(numPairArray[i]) * i + 1;
            }

            validateSum = multipliedSum % 103;
            barcode = initialMark + checkBarcode + validateSum + endMark;

            return barcode;
        }
    }
}
