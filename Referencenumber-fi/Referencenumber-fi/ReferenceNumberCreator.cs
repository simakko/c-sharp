using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencenumber_fi
{
    public static class ReferenceNumberCreator
    {
        public static string Create()
        {
            DateTime time = DateTime.Now;
            string day = time.ToString("dd"); //
            string month = time.ToString("MM");
            string year = time.ToString("yyyy");
            string hour = time.Hour.ToString();
            string min = time.Minute.ToString();
            string sec = time.Second.ToString();

            string referencePart1 = day + month + year + hour + min + sec;

            return referencePart1;
        }
    }
}
