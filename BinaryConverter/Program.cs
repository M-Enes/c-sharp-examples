using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = {"                                  #########################################                                  ",
                                  "                                  #### KONSOL TEMEL KONTROL UYGULAMASI ####                                  ",
                                  "                                  #########################################                                  ",
                                  "                                                                                                             ",
                                  "                                                                                                             ",
                                  "                                                                                                             ",
                                  "                                                                                                             ",
                                  "                Sayı Giriniz:                                                                                ",
                                  "                                                                                                             ",
                                  "                                                                                                             ",
                                  "                Bit Karşılığı:                                                                               ",
                                  "                                                                                                             ",
                                  "                                                                                                             ",
                                  "                                                                                                             ",
                                  "                                                                                                             "
            
            
            
            
            
            
            
            
            
            
            
            };



            /*
            #########################################
            #### KONSOL TEMEL KONTROL UYGULAMASI ####
            #########################################



            



            */
            foreach (var s in myStrings)
            {
                Console.WriteLine(s);
            }
            Console.SetCursorPosition(29,7);

            string inputString = Console.ReadLine();
            Console.SetCursorPosition(30,10);

            int number = int.Parse(inputString);

            int divNumber = number;

            List<string> outputString = new List<string>();

            while(divNumber / 2 >= 1)
            {
                outputString.Add((divNumber % 2).ToString());
                divNumber /= 2;
            }
            outputString.Add("1");

            for (int i = 0; i < outputString.Count /2; i++)
            {
                var firststring = outputString[i]; 
                outputString[i] = outputString[outputString.Count - i - 1];
                outputString[outputString.Count - i - 1] = firststring;
            }

            outputString.ForEach(s => Console.Write(s));

        }
    }
}