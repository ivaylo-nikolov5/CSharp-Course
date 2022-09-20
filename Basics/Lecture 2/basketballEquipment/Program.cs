using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyTax = int.Parse(Console.ReadLine());

            double sneakersPrice = yearlyTax - (yearlyTax * 0.4);
            double basketballEquipPrice = sneakersPrice - (sneakersPrice * 0.2);
            double ballPrice = basketballEquipPrice / 4;
            double basketballAccessoriesPrice = ballPrice / 5;

            double totalPrice = sneakersPrice + basketballEquipPrice + ballPrice + basketballAccessoriesPrice + yearlyTax;

            Console.WriteLine(totalPrice);


        }
    }
}
