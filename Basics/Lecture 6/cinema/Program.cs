using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (projectionType == "Premiere")
            {
                ticketPrice = 12;
            }
            else if (projectionType == "Normal")
            {
                ticketPrice = 7.5;
            }
            else if (projectionType == "Discount")
            {
                ticketPrice = 5;
            }

            double result = ticketPrice * rows * cols;

            Console.WriteLine($"{result:f2} leva");
        }
    }
}
