using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int cpus = int.Parse(Console.ReadLine());
            int rams = int.Parse(Console.ReadLine());

            double videoCardsPrice = videoCards * 250;
            double cpusPrice = cpus * (0.35 * videoCardsPrice);
            double ramsPrice = rams * (0.1 * videoCardsPrice);

            double totalPrice = videoCardsPrice + cpusPrice + ramsPrice;
            if (videoCards > cpus)
            {
                totalPrice -= totalPrice * 0.15;
            }

            double diff = Math.Abs(totalPrice - budget);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {diff:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:f2} leva more!");
            }
        }  
    }
}
