using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace worldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double totalTime = distanceInMeters * timePerMeter;
            totalTime += Math.Floor(distanceInMeters / 15) * 12.5;

            double diff = Math.Abs(totalTime - recordInSeconds);

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
            }
        }
    }
}
