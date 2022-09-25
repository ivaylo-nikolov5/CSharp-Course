using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episodeLength = int.Parse(Console.ReadLine());
            int breakLength = int.Parse(Console.ReadLine());

            double lunchTime = breakLength / 8;
            double restTime = breakLength / 4;
            double timeLeft = Math.Ceiling(breakLength - lunchTime - restTime);

            if (timeLeft >= episodeLength)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeLeft - episodeLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodeLength - timeLeft)} more minutes.");
            }
        }
    }
}
