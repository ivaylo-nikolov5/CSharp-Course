using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gueessThePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedPassword = "s3cr3t!P@ssw0rd";
            string password = Console.ReadLine();

            if (password == searchedPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }

        }
    }
}
