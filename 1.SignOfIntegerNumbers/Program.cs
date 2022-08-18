using System;

namespace _1.SignOfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numbers = int.Parse(input);
            PrintSign(numbers);
        }
        private static void PrintSign(int numbers)
        {
            if (numbers > 0)
            {
                Console.WriteLine($"The number {numbers} is positive.");
            }
            else if (numbers < 0)
            {
                Console.WriteLine($"The number {numbers} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {numbers} is zero.");
            }
        }
    }
}
