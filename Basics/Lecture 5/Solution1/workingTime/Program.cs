using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hour < 10 || hour > 18 || day == "Sunday")
            {
                Console.WriteLine("closed");
            }
            else if (hour >= 10 && hour <= 18)
            {
                Console.WriteLine("open");
            }
        }
    }
}
