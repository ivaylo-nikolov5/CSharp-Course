using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace newHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowers == "Roses")
            {
                price = numberOfFlowers * 5;
                if (numberOfFlowers > 80)
                {
                    price -= price * 0.1;
                }
            }
            else if (flowers == "Dahlias")
            {
                price = numberOfFlowers * 3.8;
                if (numberOfFlowers > 90)
                {
                    price -= price * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                price = numberOfFlowers * 2.8;
                if (numberOfFlowers > 80)
                {
                    price -= price * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                price = numberOfFlowers * 3;
                if (numberOfFlowers < 120)
                {
                    price += price * 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = numberOfFlowers * 2.5;
                if (numberOfFlowers < 80)
                {
                    price += price * 0.2;
                }
            }

            double diff = Math.Abs(budget - price);
            string result = "";

            if (budget >= price)
            {
                result = $"Hey, you have a great garden with {numberOfFlowers} {flowers} and {diff:f2} leva left.";
            }
            else
            {
                result = $"Not enough money, you need {diff:f2} leva more.";
            }

            Console.WriteLine(result);
        }

    }
}
