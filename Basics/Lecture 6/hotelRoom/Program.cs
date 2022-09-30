using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nights;
                apartmentPrice = 65 * nights;

                if (nights > 7 && nights <= 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                }
            }

            else if (month == "June" || month == "September")
            {
                studioPrice = 75.2 * nights;
                apartmentPrice = 68.7 * nights;

                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                }
            }
            else
            {
                studioPrice = 76 * nights;
                apartmentPrice = 77 * nights;
            }

            if (nights > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");

        }
    }
}
