using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Jump_Point_Calculator
{
    public class Jumper
    {
        private int _number;
        private string _name;
        private string _country;

        public Jumper(int number, string name, string country)
        {
            _number = number;
            _name = name;
            _country = country;
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
    }
}
