using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usdToBgnConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollars = double.Parse(Console.ReadLine());
            double levs = dollars * 1.79549;

            Console.WriteLine(levs);
        }
    }
}
