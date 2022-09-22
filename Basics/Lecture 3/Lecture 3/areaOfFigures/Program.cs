using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                result = side * side;
            }
            else if (figure == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                result = length * width;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI * (radius * radius);
            }
            else
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = (side * height) / 2;

            }
            Console.WriteLine("{0:F3}", result);
        }
    }
}
