using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            string result = "";

            if (operation == "+")
            {
                int total = number1 + number2;
                string evenOdd = "";
                if (total % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }

                result = $"{number1} + {number2} = {total} - {evenOdd}";
            }

            else if (operation == "-")
            {
                int total = number1 - number2;
                string evenOdd = "";
                if (total % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }

                result = $"{number1} - {number2} = {total} - {evenOdd}";
            }

            else if (operation == "*")
            {
                int total = number1 * number2;
                string evenOdd = "";
                if (total % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }

                result = $"{number1} * {number2} = {total} - {evenOdd}";
            }

            else if (operation == "/")
            {

                if (number2 == 0)
                {
                    result = $"Cannot divide {number1} by zero";
                }
                else
                {

                    double total = number1 * 1.0 / number2;

                    result = $"{number1} / {number2} = {total:f2}";
                }
            }

            else if (operation == "%")
            {

                if (number2 == 0)
                {
                    result = $"Cannot divide {number1} by zero";
                }
                else
                {
                    int total = number1 % number2;

                    result = $"{number1} % {number2} = {total}";
                }
            }

            Console.WriteLine(result);
        }
    }
}
