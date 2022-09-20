using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            double chickenMenusPrice = chickenMenus * 10.35;
            double fishMenusPrice = fishMenus * 12.4;
            double vegetarianMenusPrice = vegetarianMenus * 8.15;

            double totalFoodPrice = chickenMenusPrice + fishMenusPrice + vegetarianMenusPrice;
            double dessertPrice = 0.2 * totalFoodPrice;

            double totalPrice = totalFoodPrice + dessertPrice +  2.5;

            Console.WriteLine(totalPrice);
        }
    }
}
