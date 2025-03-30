using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GenerateKeyValuePairs
    {
        public static Dictionary<int, string> GetKeyValuePairs()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            var numberOfDivisors = GetAmountOfDivisors();
            Console.WriteLine();
            for (int i = 1; i <= numberOfDivisors; i++)
            {
                int inputNumber;
                string inputWord;

                Console.ForegroundColor = ConsoleColor.White;
                string[] numberOrders = new string[] { "1st", "2nd", "3th", "4th", "5th" };

                inputNumber = GetDivisors(numberOrders, i);
                
                Console.ForegroundColor = ConsoleColor.White;
                inputWord = GetWordForDivisor(numberOrders, i);

                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.White;

                dictionary[inputNumber] = string.Join("", inputWord.Split());
            }
            return dictionary;
        }

        public static int GetDivisors(string[] numberOrders, int i)
        {
            
            while (true)
            {
                Console.Write($"Enter {numberOrders[i - 1]} divisor: ");
                Console.ForegroundColor = ConsoleColor.Red;
                if (int.TryParse(Console.ReadLine(), out int input) && input > 0)
                {
                    return input;
                }
            }
        }

        public static string GetWordForDivisor(string[] numberOrders, int i)
        {
            string? inputWord;
            while (true)
            {
                Console.Write($"Enter word for the {numberOrders[i - 1]} divisor (length between 3-10): ");
                Console.ForegroundColor = ConsoleColor.Red;
                inputWord = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                if (inputWord.Length > 2 && inputWord.Length < 10)
                {
                    return inputWord;
                }
                Console.WriteLine();
            }
        }
        public static int GetAmountOfDivisors()
        {
            int amountOfKeyValuePairs;
            while (true)
            {
                Console.Write("ENTER number of divisors: ");
                Console.ForegroundColor = ConsoleColor.Red;

                int.TryParse(Console.ReadLine(), out int amount);
                if (amount != 0)
                {
                    amountOfKeyValuePairs = amount;
                    break;
                }
            }
            return amountOfKeyValuePairs;
        }
    }
}
