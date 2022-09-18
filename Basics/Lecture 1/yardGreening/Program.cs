using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double yardGreeningPrice = squareMeters * 7.61;
            double discount = yardGreeningPrice * 0.18;
            yardGreeningPrice -= discount;

            Console.WriteLine($"The final price is: {yardGreeningPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
