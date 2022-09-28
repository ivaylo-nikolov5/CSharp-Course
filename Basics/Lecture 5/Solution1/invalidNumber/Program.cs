using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (!(number >= 100 && number <= 200 || number == 0))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
