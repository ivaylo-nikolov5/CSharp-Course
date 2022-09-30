using System;


namespace skiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            double price = 0;

            if (roomType == "room for one person")
            {
                price = 18 * days;
            }
            else if (roomType == "apartment")
            {
                price = 25 * days;

                if (days > 15)
                {
                    price -= price * 0.5;
                }
                else if (days >= 10)
                {
                    price -= price * 0.35;
                }
                else
                {
                    price -= price * 0.3;
                }
            }
            else if (roomType == "president apartment")
            {
                price = 35 * days;
                
                if (days > 15)
                {
                    price -= price * 0.2;
                }
                else if (days >= 10)
                {
                    price -= price * 0.15;
                }
                else
                {
                    price -= price * 0.1;
                }
            }

            if (rating == "positive")
            {
                price += price * 0.25;
            }
            else
            {
                price -= price * 0.1;
            }

            Console.WriteLine($"{price:f2}");

            
        }
    }
}
