using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string place = "";
            double price = 0;


            if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                price = budget * 0.9;
            }

            if (season == "summer" && budget <= 1000)
            {
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    price = budget * 0.3;
                }
                else if (budget <= 1000)
                {
                    destination = "Balkans";

                    price = budget * 0.4;
                }
                place = "Camp";
            }
            else if (season == "winter" && budget <= 1000)
            {
                if (budget <= 100)
                {
                    destination = "Bulgaria";
                    price = budget * 0.7;
                }
                else if (budget <= 1000)
                {
                    destination = "Balkans";
                    price = budget * 0.8;

                }
                place = "Hotel";
            }

            destination = $"Somewhere in {destination}";
            place = $"{place} - {price:f2}";

            Console.WriteLine(destination);
            Console.WriteLine(place);
        }
    }
}
