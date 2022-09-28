using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            double sellsVolume = double.Parse(Console.ReadLine());

            double commissionPercent = 0;
            bool isTownValid = true;
            bool isVolumeValid = true;
            if (sellsVolume < 0)
            {
                isVolumeValid = false;
                Console.WriteLine("error");
            }

            if (isVolumeValid)
            {
                if (cityName == "Sofia")
                {
                    if (sellsVolume > 10000)
                    {
                        commissionPercent = 12;
                    }
                    else if (sellsVolume > 1000)
                    {
                        commissionPercent = 8;
                    }
                    else if (sellsVolume > 500)
                    {
                        commissionPercent = 7;
                    }
                    else
                    {
                        commissionPercent = 5;
                    }
                }
                else if (cityName == "Varna")
                {
                    if (sellsVolume > 10000)
                    {
                        commissionPercent = 13;
                    }
                    else if (sellsVolume > 1000)
                    {
                        commissionPercent = 10;
                    }
                    else if (sellsVolume > 500)
                    {
                        commissionPercent = 7.5;
                    }
                    else
                    {
                        commissionPercent = 4.5;
                    }
                }
                else if (cityName == "Plovdiv")
                {
                    if (sellsVolume > 10000)
                    {
                        commissionPercent = 14.5;
                    }
                    else if (sellsVolume > 1000)
                    {
                        commissionPercent = 12;
                    }
                    else if (sellsVolume > 500)
                    {
                        commissionPercent = 8;
                    }
                    else
                    {
                        commissionPercent = 5.5;
                    }
                }
                else
                {

                    isTownValid = false;
                    Console.WriteLine("error");
                }
            }

            if (isTownValid && isVolumeValid)
            {
                double total = sellsVolume * commissionPercent / 100;
                Console.WriteLine($"{total:f2}");
            }

        }
    }
}
