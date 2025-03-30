using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FizzBuzzEngine
    {
        public static void CreateFizzBuzz(Dictionary<int, string> dictionary,Tuple<int, int> lowerUpperLimits)
        {
            Dictionary<string, int> amountOfKeyValuePairs = new Dictionary<string, int>();
            GetTheFinalCountDown();

            for (int i = lowerUpperLimits.Item1; i <= lowerUpperLimits.Item2; i++)
            {
                Thread.Sleep(100);
                string valueBuffer = "";
                string stringRepreOfI = i.ToString();
                foreach (var key in dictionary.Keys)
                {
                    if (i % key == 0 || stringRepreOfI.Contains(key.ToString()))
                    {
                        valueBuffer += dictionary[key];
                        if (!amountOfKeyValuePairs.ContainsKey(dictionary[key]))
                        {
                            amountOfKeyValuePairs.Add(dictionary[key], 1);
                        }
                        else
                        {
                            amountOfKeyValuePairs[dictionary[key]] += 1;
                        }
                    }
                }

                if (valueBuffer.Length == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(valueBuffer);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            GetTheAmountOfOccurance(amountOfKeyValuePairs);

            Console.WriteLine("Press ENTER to end program...");
            Console.ReadLine();
        }
        public static void GetGreeting()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("                     Welcome to the almighty Fizz Buzz generator.                           ");
            Console.WriteLine("    Please Proceed with the given instructions to generate your own customized fizz buzz.   ");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public static void GetTheAmountOfOccurance(Dictionary<string, int> amountOfKeyValuePairs)
        {
            Console.WriteLine();
            foreach (var key in amountOfKeyValuePairs.Keys)
            {
                Console.Write("Value: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"\"{key}\" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" is present exactly: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{amountOfKeyValuePairs[key]} ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("number of times");
                Console.WriteLine();
            }
        }
        public static void GetTheFinalCountDown()
        {
            Console.Write("GET READY ");
            for (int i = 3; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("ITS THE FINAL COUNTDOWN!!" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public static Tuple<int, int> GetLowerUpperLimits()
        {
            Console.WriteLine();
            int lowerLimit = GetLimit(0,1,"lower");
            Console.ForegroundColor = ConsoleColor.White;
            int upperLimit = GetLimit(lowerLimit, 100, "upper");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Tuple<int, int> tuple = new Tuple<int, int>(lowerLimit, upperLimit);
            Console.ForegroundColor = ConsoleColor.White;
            return tuple;
        }

        public static int GetLimit(int neddToComply, int returnValue, string limitType)
        {
            while (true)
            {
                Console.Write($"Enter a {limitType} limit for the generator: ");
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(Console.ReadLine(), out int inputLimit))
                {
                    if (inputLimit > neddToComply)
                    {
                        return inputLimit;
                    }
                }
                else
                {
                    return returnValue;
                }
            }
        }
    }
}
