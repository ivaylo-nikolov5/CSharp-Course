using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int result = 0;

            switch (day) 
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    result = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    result = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    result = 16;
                    break;

            }

            Console.WriteLine(result);
        }
    }
}
