using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Odev1
            int Total = 0;

            for (int i = 0; i < 100; i += 2)
            {
                Total += i;
            }

            Console.WriteLine("1'den 100'e kadar olan çift sayıların toplamı: " + Total);

            // Odev2
            int Total2 = 0;

            for (int i = 0; i < 100; i += 7)
            {
                Total2 += i;
            }

            Console.WriteLine("1'den 100'e kadar olan 7'ye bölünen sayıların toplamı: " + Total2);

            string[,] cars = new string[5, 2];

            cars[0, 0] = "Auris";
            cars[0, 1] = "Corolla";
            cars[1, 0] = "CHR";
            cars[1, 1] = "Yaris";
            cars[2, 0] = "Corolla Hybrid";
            cars[2, 1] = "Focus";
            cars[3, 0] = "Fiesta";
            cars[3, 1] = "Transit";
            cars[4, 0] = "Mustang";
            cars[4, 1] = "Connect";

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }


        }
    }
}
