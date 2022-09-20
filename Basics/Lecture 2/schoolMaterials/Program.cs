using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackages = int.Parse(Console.ReadLine());
            int markerPackages = int.Parse(Console.ReadLine());
            int boardCleanerLiters = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double pensPrice = penPackages * 5.8;
            double markersPrice = markerPackages * 7.2;
            double boardCleanerPrice = boardCleanerLiters * 1.2;

            double totalPrice = pensPrice + markersPrice + boardCleanerPrice;
            totalPrice -= totalPrice * (percentDiscount / 100.0);

            Console.WriteLine(totalPrice);

        }
    }
}
