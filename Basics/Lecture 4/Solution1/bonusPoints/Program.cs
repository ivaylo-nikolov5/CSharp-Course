using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (startingPoints > 1000)
            {
                bonusPoints = startingPoints * 0.1;
            }
            else if (startingPoints > 100)
            {
                bonusPoints = startingPoints * 0.2;
            }
            else
            {
                bonusPoints = 5;
            }

            if (startingPoints % 2 == 0) 
            {
                bonusPoints += 1;
            }
            else if (startingPoints % 10 == 5)
            {
                bonusPoints += 2;
            }
                    

            double totalPoints = startingPoints + bonusPoints;


            Console.WriteLine(bonusPoints);
            Console.WriteLine(totalPoints);

        }
    }
}
