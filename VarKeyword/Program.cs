using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 200;
            //number7 = 'A';
            //Console.WriteLine(number7==10 ? "Number7 is 10" : "Number is not 10");
            var slice = number - number % 10;
            Console.WriteLine("Number is between {0}-{1}",slice,slice+10);

            //var message = string.Empty;
            //if (number >= 0 && number <= 100)
            //{
            //    message = "Number is between 0-100";
            //}
            //else if (number >100 && number <=200)
            //{
            //    message = "Number is between 101-200";
            //}
            //else if(number >200 || number <0)
            //{
            //    message = "Number is less than 0 or greater than 200";
            //}

            //  Console.WriteLine(message);
        }
    }
}
