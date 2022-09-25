using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace godzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int statistsCount = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());

            double decorPrice = movieBudget * 0.1;
            double clothingPrice = statistsCount * outfitPrice;

            if (statistsCount > 150)
            {
                clothingPrice -= clothingPrice * 0.1;
            }

            double totalPrice = decorPrice + clothingPrice;
            double diff = movieBudget - totalPrice;

            if (diff >= 0)
            {
                Console.WriteLine($"Action!\nWingard starts filming with {diff:f2} leva left.\n");

            }
            else
            {
                Console.WriteLine($"Not enough money!\nWingard needs {Math.Abs(diff):f2} leva more.");
            }


        }
    }
}
