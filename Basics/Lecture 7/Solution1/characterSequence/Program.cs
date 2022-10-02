using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            for (int ch = 0; ch < str.Length; ch++)
            {
                Console.WriteLine(str[ch]);
            }
        }
    }
}
