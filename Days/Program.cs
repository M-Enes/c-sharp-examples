using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;

            var dayNumber = today.Day;
            var dayinWeek = dayNumber % 7;
            var outputMessage = "Happy ";
            switch (dayinWeek)
            {
                case 1:
                    outputMessage += "Monday";
                    break;
                case 2:
                    outputMessage += "Tuesday";
                    break;
                case 3:
                    outputMessage += "Wednesday";
                    break;
                case 4:
                    outputMessage += "Thursday";
                    break;
                case 5:
                    outputMessage += "Friday";
                    break;
                case 6:
                    outputMessage += "Saturday";
                    break;
                case 7:
                    outputMessage += "Sunday";
                    break;
                default:
                    outputMessage += "";
                    break;
            }

            Console.WriteLine(outputMessage);

        }
    }
}
