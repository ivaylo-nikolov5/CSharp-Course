using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacationBookList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int estimatedDays = int.Parse(Console.ReadLine());

            int timeForTheBook = numberOfPages / pagesPerHour;
            int hoursPerDay = timeForTheBook / estimatedDays;

            Console.WriteLine(hoursPerDay);
        }
    }
}
