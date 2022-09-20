using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;

            int capacity = length * width * height;
            double capacityInLiters = capacity * 0.001;
            double neededLiters = capacityInLiters * (1 - percent);

            Console.WriteLine(neededLiters);
        }
    }
}
