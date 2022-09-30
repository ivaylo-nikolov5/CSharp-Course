using System;


namespace summerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (partOfTheDay == "Morning")
            {
                if (10 <= degrees && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";

                }
                else if (18 < degrees && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (25 <= degrees)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (partOfTheDay == "Afternoon")
            {
                if (10 <= degrees && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";

                }
                else if (18 < degrees && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (25 <= degrees)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (partOfTheDay == "Evening")
            {
                
                    outfit = "Shirt";
                    shoes = "Moccasins";
            }

            string result = $"It's {degrees} degrees, get your {outfit} and {shoes}.";
            Console.WriteLine(result);
        }
    }
}
