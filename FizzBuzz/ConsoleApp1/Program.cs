using System.Collections;
using System.Collections.Generic;
using System.Threading.Channels;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzEngine.GetGreeting();
            FizzBuzzEngine.CreateFizzBuzz(GenerateKeyValuePairs.GetKeyValuePairs(), FizzBuzzEngine.GetLowerUpperLimits());
        }
    }
}