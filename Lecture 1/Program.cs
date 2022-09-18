using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            
            string result = $"You are {firstName} {lastName}, a {age}-years old person from {town}.";
            Console.WriteLine(result);
        }
    }
}
