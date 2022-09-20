using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int metersNylon = int.Parse(Console.ReadLine());
            int litersPaint = int.Parse(Console.ReadLine());
            int litersThinner = int.Parse(Console.ReadLine());
            int neededHours = int.Parse(Console.ReadLine());

            double nylonPrice = (metersNylon + 2) * 1.5;
            double paintPrice = (litersPaint + (litersPaint * 0.1)) * 14.5;
            double thinnerPrice = litersThinner * 5;

            double suppliesPrice = nylonPrice + paintPrice + thinnerPrice + 0.4;
            double workersCost = (suppliesPrice * 0.3) * neededHours;

            double totalPrice = suppliesPrice + workersCost;

            Console.WriteLine(totalPrice);
        }
    }
}
