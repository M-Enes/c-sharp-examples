using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoKiralama
{
    class Program
    {
        public static int Money = 500;
        public static int TotalRentPrice;

        static void WriteTotalRentPrice()
        {
            Console.WriteLine("Total Rent Price: " + TotalRentPrice);
        }
        static void WriteMoney()
        {
            Console.WriteLine("Your money: " + Money);
        }
        static int MoneyAfterPay()
        {
            return Money - TotalRentPrice;
        }
        static int InputCarNumber()
        {
            Console.Write("Please type car number: ");
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Otomobil[] otomobils = new Otomobil[10];

            otomobils[0] = new Otomobil
            {
                Mark = "Volkswagen",
                Model = "Polo",
                MotorCC = 1600,
                Length = 2,
                RentPrice = 100
            };

            otomobils[1] = new Otomobil
            {
                Mark = "Skoda",
                Model = "Octavia",
                MotorCC = 1400,
                Length = 3,
                RentPrice = 150
            };
            while (true)
            {
                Console.WriteLine("Please Type Rent, Pay, ex.");
                string input = Console.ReadLine();

                if (input == "Rent" || input == "rent")
                {
                    int carNumber = InputCarNumber();

                    Console.Write("Please type number of renting days: ");
                    int rentingDays = int.Parse(Console.ReadLine());

                    Console.WriteLine("Renting Price: " + otomobils[carNumber].RentPrice * rentingDays);
                    Console.Write("Rent? (yes or no)");
                    string RentingAnswer = Console.ReadLine();
                    bool Rent = RentingAnswer == "yes" || RentingAnswer == "Yes";

                    if (Rent)
                    {
                        otomobils[carNumber].Rent(rentingDays);
                        Console.WriteLine("Car " + carNumber + " is rented.");
                    }
                    else
                    {
                        Console.WriteLine("I don't rent car.");
                    }
                }
                else if (input == "Pay" || input == "pay")
                {
                    int carNumber = InputCarNumber();
                    Console.WriteLine("Money After Pay: " + MoneyAfterPay());
                    Console.Write("Pay? (yes or no)");

                    string PayingAnswer = Console.ReadLine();
                    bool Pay = PayingAnswer == "yes" || PayingAnswer == "Yes";

                    if (Pay)
                    {
                        otomobils[carNumber].Pay();
                        Console.WriteLine("Rent Price Car " + carNumber + " is payed.");
                    }
                    else
                    {
                        Console.WriteLine("I don't pay rent price.");
                    }
                }
                else { break; }

            }
            otomobils[1].Rent(1);
            otomobils[1].Pay();
            Console.WriteLine(otomobils[1].isRented);
        }
    }
}