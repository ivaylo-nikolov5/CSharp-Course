using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodPackages = int.Parse(Console.ReadLine());
            int catFoodPackages = int.Parse(Console.ReadLine());

            double dogFoodPrice = dogFoodPackages * 2.5;
            int catFoodPrice = catFoodPackages * 4;

            double totalPrice = dogFoodPrice + catFoodPrice;

            Console.WriteLine(totalPrice + " lv.");
        }
    }
}
