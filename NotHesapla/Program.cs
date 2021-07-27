using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotHesapla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrencinin birinci notunu giriniz: ");
            try
            {
                double value1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Öğrencinin ikinci notunu giriniz: ");
                double value2 = Convert.ToDouble(Console.ReadLine());

                double average = Convert.ToDouble((value1 + value2)) / 2;

                bool isNotNote = value1 < 0 || value1 > 100 || value2 < 0 || value2 > 100;

                if (isNotNote)
                {
                    Console.WriteLine("Bu not geçerli değil.");
                }
                else
                {
                    Console.WriteLine("Ortalamanız: " + average);
                    Console.Write("Öğrencinin 5 üzerinden notu: ");

                    if (average >= 85)
                    {
                        Console.WriteLine(5);
                    }
                    else if (average >= 70)
                    {
                        Console.WriteLine(4);
                    }
                    else if (average >= 55)
                    {
                        Console.WriteLine(3);
                    }
                    else if (average >= 45)
                    {
                        Console.WriteLine(2);
                    }
                    else if (average >= 20)
                    {
                        Console.WriteLine(1);
                    }
                    else if (average >= 0)
                    {
                        Console.WriteLine(0);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nHatalı giriş");
            }
        }
    }
}
