using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            switch (command)
            {
                case "add":
                    sumAdd(numOne, numTwo);
                    break;
                case "multiply":
                    sumMultiply(numOne, numTwo);
                    break;
                case "subtract":
                    sumSubtract(numOne, numTwo);
                    break;
                case "divide":
                    sumDivide(numOne, numTwo);
                    break;
            }
        }
        private static void sumDivide(int numOne, int numTwo)
        {
            int sumDivide = numOne / numTwo;
            Console.WriteLine(sumDivide);
        }
        private static void sumSubtract(int numOne, int numTwo)
        {
            int substract = numOne - numTwo;
            Console.WriteLine(substract);
        }
        private static void sumMultiply(int numOne, int numTwo)
        {
            int multiply = numOne * numTwo;
            Console.WriteLine(multiply);
        }
        private static void sumAdd(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            Console.WriteLine(sum);
        }
    }
}
