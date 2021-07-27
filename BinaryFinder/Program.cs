using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFinder
{
    class Program
    {
        static string ReverseString(string stringToReverse)
        {
            string reversedString = "";
            int i = 0;
            while (i < stringToReverse.Length)
            {
                reversedString += stringToReverse[stringToReverse.Length - 1 - i];
                i++;
            }
            return reversedString;
        }
        static void Restart()
        {
            Console.Clear();
            string[] parameter = new string[] { "value", "value2" };
            Main(parameter);
        }
        static int CountCharInString(string stringValue, char CountChar)
        {
            int i = 0;
            int count = 0;
            while (i < stringValue.Length)
            {
                if (stringValue[i] == CountChar)
                {
                    count++;
                }
                i++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.Title = "Binary Finder";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please type binarytodecimal or decimaltobinary");
            string conversionDirection = Console.ReadLine();
            if (conversionDirection == "binarytodecimal")
            {
                Console.WriteLine("Please type binary value");
                Console.Write("binary value: ");
                string valueToConvertString = Console.ReadLine();
                valueToConvertString = ReverseString(valueToConvertString);

                bool isBinary =
                    (
                    CountCharInString(valueToConvertString, '0')
                    + CountCharInString(valueToConvertString, '1')
                    ) == valueToConvertString.Length;

                try
                {
                    if (!isBinary)
                    {
                        throw new FormatException();
                    }
                    else
                    {

                        int i = 0;
                        long conversionValue = 1;
                        long substriction = 0;

                        while (i < valueToConvertString.Length)
                        {
                            conversionValue *= 2;
                            if (valueToConvertString[i] == '0')
                            {
                                substriction += Convert.ToInt64(Math.Pow(2, i));
                            }
                            i++;
                        }
                        substriction += 1;
                        conversionValue -= substriction;
                        if (conversionValue < 0)
                        {
                            Console.WriteLine("This value is very big!");
                        }
                        else
                        {
                            Console.WriteLine("decimal value: " + conversionValue);
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.Beep();
                    Console.WriteLine("this value is not binary!");
                }
                catch (OverflowException)
                {
                    Console.Beep();
                    Console.WriteLine("this value is too big!");
                }

            }
            else if (conversionDirection == "decimaltobinary")
            {
                Console.WriteLine("Please type decimal value");
                try
                {

                    Console.Write("decimal value: ");
                    long convertingValue = Convert.ToInt64(Console.ReadLine());

                    if (convertingValue < 0)
                    {
                        throw new FormatException();
                    }

                    string conversionValue = "";

                    while (convertingValue / 2 != 1)
                    {
                        conversionValue += (convertingValue % 2).ToString();
                        convertingValue /= 2;
                    }
                    conversionValue += (convertingValue % 2).ToString();
                    conversionValue += "1";
                    conversionValue = ReverseString(conversionValue);

                    Console.Write("binary value: ");
                    int i = 0;
                    while (i < conversionValue.Length)
                    {
                        if ((conversionValue.Length - i) % 4 == 0)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(conversionValue[i]);
                        i++;
                    }
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.Beep();
                    Console.WriteLine("This value is unsupported!");
                }
                catch (OverflowException)
                {
                    Console.Beep();
                    Console.WriteLine("This value is too big!");
                }
            }
            else
            {
                Console.Beep();
                Console.WriteLine("This value is unsupported!");
            }
            Console.WriteLine("Would you like to restart it ? (yes or anything)");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "yes")
            {
                Restart();
            }
        }
    }
}
