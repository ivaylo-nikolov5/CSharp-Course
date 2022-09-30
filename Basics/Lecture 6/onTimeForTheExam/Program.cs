using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int toExamMinutes = examHour * 60 + examMinutes;
            int toArrivalMinutes = arrivalHour * 60 + arrivalMinutes;

            int diff = Math.Abs(toArrivalMinutes - toExamMinutes);
            string condition = "";
            string result = "";

            if (toArrivalMinutes <= toExamMinutes)
            {
                if (diff <= 30)
                {
                    condition = "On time";
                    result = $"{diff} minutes before the start";
                }
                else
                {
                    condition = "Early";
                    if (diff >= 60)
                    {
                        int hours = diff / 60;
                        int minutes = diff % 60;

                        if (minutes < 10)
                        {
                            result = $"{hours}:0{minutes} hours before the start";
                        }
                        else
                        {
                            result = $"{hours}:{minutes} hours before the start";
                        }
                    }
                    else
                    {
                        result = $"{diff} minutes before the start";
                    }
                }
            }
            else
            {
                condition = "Late";
                if (diff >= 60)
                {
                    int hours = diff / 60;
                    int minutes = diff % 60;

                    if (minutes < 10)
                    {
                        result = $"{hours}:0{minutes} hours after the start";
                    }
                    else
                    {
                        result = $"{hours}:{minutes} hours after the start";
                    }
                }
                else
                {
                    result = $"{diff} minutes after the start";
                }
            }

            Console.WriteLine(condition);
            Console.WriteLine(result);
            

        }
    }
}
