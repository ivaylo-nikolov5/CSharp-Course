using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposedAmout = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double yearlyInterestPercent = double.Parse(Console.ReadLine());

            double interest = deposedAmout * (yearlyInterestPercent / 100);
            double monthInterest = interest / 12;
            double total = deposedAmout + (depositTerm * monthInterest);

            Console.WriteLine(total);
        }
    }
}
