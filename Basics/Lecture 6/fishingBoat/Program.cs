using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace fishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double boatPrice = 0;

            if (season == "Spring")
            {
                boatPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatPrice = 4200;
            }
            else if (season == "Winter")
            {
                boatPrice = 2600;
            }


            if (fishermen <= 6)
            {
                boatPrice -= boatPrice * 0.1;
            }
            else if (fishermen > 6 && fishermen <= 11)
            {
                boatPrice -= boatPrice * 0.15;
            }
            else
            {
                boatPrice -= boatPrice * 0.25;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                boatPrice -= boatPrice * 0.05;
            }

            double diff = Math.Abs(budget - boatPrice);
            string result = "";

            if (budget >= boatPrice)
            {
                result = $"Yes! You have {diff:f2} leva left.";
            }
            else
            {
                result = $"Not enough money! You need {diff:f2} leva.";
            }

            Console.WriteLine(result);
        }

    }
}
