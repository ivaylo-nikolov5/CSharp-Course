using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int textLength = text.Length;
            int totalPoints = 0;

            for (int i = 0; i < textLength; i++)
            {
                char currentChar = text[i];

                if (currentChar == char.Parse("a"))
                {
                    totalPoints++;
                }
                else if (currentChar == char.Parse("e"))
                {
                    totalPoints += 2;
                }
                else if (currentChar == char.Parse("i"))
                {
                    totalPoints += 3;
                }
                else if (currentChar == char.Parse("o"))
                {
                    totalPoints += 4;
                }
                else if (currentChar == char.Parse("u"))
                {
                    totalPoints += 5;
                }
            }

            Console.WriteLine(totalPoints);

        }
    }
}
