using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double result = 0;

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                        result = 0.5 * quantity;
                        break;
                    case "water":
                        result = 0.8 * quantity;
                        break;
                    case "beer":
                        result = 1.2 * quantity;
                        break;
                    case "sweets":
                        result = 1.45 * quantity;
                        break;
                    case "peanuts":
                        result = 1.6 * quantity;
                        break;

                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        result = 0.4 * quantity;
                        break;
                    case "water":
                        result = 0.7 * quantity;
                        break;
                    case "beer":
                        result = 1.15 * quantity;
                        break;
                    case "sweets":
                        result = 1.3 * quantity;
                        break;
                    case "peanuts":
                        result = 1.5 * quantity;
                        break;

                }
            }
            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        result = 0.45 * quantity;
                        break;
                    case "water":
                        result = 0.7 * quantity;
                        break;
                    case "beer":
                        result = 1.1 * quantity;
                        break;
                    case "sweets":
                        result = 1.35 * quantity;
                        break;
                    case "peanuts":
                        result = 1.55 * quantity;
                        break;
                
                }
            }

            Console.WriteLine(result);
        }
    }
}
