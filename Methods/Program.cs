using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first;
            //int second = 100;
            //var result = Add3(out first, second);
            Console.WriteLine(Multiply(2,3,3));
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int first=20,int second=30)
        {
            return first + second;
        }
        static int Add3(out int first, int second)
        {
            first = 30;
            return first + second;
        }

        static int Multiply(params int[] numbers)
        {
            var total = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                total *=numbers[i];
            }
            return total;
        }
    }
}
