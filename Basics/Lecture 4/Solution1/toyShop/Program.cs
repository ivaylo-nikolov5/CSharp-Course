using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double puzzlesPrice = puzzles * 2.6;
            double talkingDollsPrice = talkingDolls * 3;
            double teddyBearsPrice = teddyBears * 4.1;
            double minionsPrice = minions * 8.2;
            double trucksPrice = trucks * 2;

            double totalPrice = puzzlesPrice + talkingDollsPrice + teddyBearsPrice + minionsPrice + trucksPrice;
            double totalToys = puzzles + talkingDolls + teddyBears + minions + trucks;

            if (totalToys >= 50)
            {
                totalPrice -= totalPrice * 0.25;
            }

            totalPrice -= totalPrice * 0.1;
            double diff = Math.Abs(totalPrice - holidayPrice);

            if (totalPrice >= holidayPrice)
            {
                Console.WriteLine($"Yes! {diff:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:F2} lv needed.");
            }



        }
    }
}
