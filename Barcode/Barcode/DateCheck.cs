using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcode
{
    public static class DateCheck
    {
        public static string Check(string date)
        {
            string validDate;
            string errorMessage = "Date was incorrect!";
            DateTime dateParse;

            if (DateTime.TryParseExact(date, "dd.MM.yy", null, System.Globalization.DateTimeStyles.None, out dateParse))
            {
                validDate = dateParse.ToString("yyMMdd");
                return validDate; 
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
                System.Threading.Thread.Sleep(1500);
                return "error";
            }
        }
    }
}
