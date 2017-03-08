﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referencenumber_fi
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to check a referencenumber or create a referencenumber(s)?");
            Console.WriteLine("(A) Check (B) Create");
            string answer = Console.ReadLine();

            if (answer == "a" || answer == "A")
            {
                Console.WriteLine("Give a referencenumber that you want to check");
                string input = Console.ReadLine();
                int length = input.Length;
                string input2 = input.Substring(0, length - 1);

                int verifier = int.Parse(input.Substring(length - 1));

                int result = int.Parse(Check.CheckNumbers(input2));

                if (verifier == result)
                {
                    Console.WriteLine("Referencenumber is valid");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Referencenumber is not valid");
                    Console.ReadKey();
                }

            }
            else if (answer == "b" || answer == "B")
            {
                Console.WriteLine("How many referencenumbers do you want to create?");
                int quantity = int.Parse(Console.ReadLine());

                string referencePart1 = ReferenceNumberCreator.Create();

                List<decimal> runing = new List<decimal>();                     //Creating running number to the end of the referencenumbers first part
                for (int i = 0; i < quantity; i++)
                {
                    runing.Add(i);
                }

                List<decimal> number = new List<decimal>();                     //Combining the two parts
                for (int i = 0; i < quantity; i++)
                {
                    number.Add(decimal.Parse(referencePart1) + runing[i]);
                }

                foreach (decimal num in number)
                {
                    string result = Check.CheckNumbers(num.ToString());
                    decimal referencenumber = decimal.Parse(num.ToString() + result);
                    Console.WriteLine(String.Format("{0:##### ##### ##### #####}", referencenumber));
                }
                Console.ReadKey();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
