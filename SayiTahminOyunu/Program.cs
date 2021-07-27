using System;
using System.Collections.Generic;


namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Game();
            while (command == "r")
            {
                Console.WriteLine("Başlatılıyor");
                command = Game();
            }
        }
        static string Game()
        {
            Console.WriteLine("1 ile 100 arasında bir sayı giriniz.");
            int number = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int pcnumber = rnd.Next(0, 100);

            int trying = 1;
            while (number != pcnumber)
            {
                string message;
                if (number < pcnumber)
                {
                    message = "Daha büyük bir sayı giriniz.";
                }
                else if (number > pcnumber)
                {
                    message = "Daha küçük bir sayı giriniz.";
                }
                else
                {
                    message = "";
                }
                trying++;
                Console.WriteLine(message);
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Kazandınız! Tahmin sayısı : " + trying + 
                "\nÇıkış yapmak için q, tekrar oynamak için r yazınız.");
            return Console.ReadLine();
        }
    }
}
