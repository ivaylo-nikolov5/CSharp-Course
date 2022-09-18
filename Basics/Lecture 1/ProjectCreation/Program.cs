using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int neededTime = projects * 3;

            string result = $"The architect {name} will need {neededTime} hours to complete {projects} project/s.";

            Console.WriteLine(result);
        }
    }
}
