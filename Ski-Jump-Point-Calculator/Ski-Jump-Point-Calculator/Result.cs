﻿namespace Ski_Jump_Point_Calculator
{
    public class Result
    {
        private int _number;
        private string _name;
        private string _country;
        private double _score;

        public Result(int number, string name, string country, double score)
        {
            _number = number;
            _name = name;
            _country = country;
            _score = score;
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

        public double Score
        {
            get { return _score; }
            set { _score = value; }
        }
    }
}
