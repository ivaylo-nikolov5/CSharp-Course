using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timePlus15Mins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hours += 1;
                minutes %= 60;
            }

            if (hours > 23)
            {
                hours = 0;

            }

            Console.WriteLine($"{hours}:{minutes:00}");
        }

    }
}
