using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            char operators = char.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(numOne, operators, numTwo));
        }
        private static double Calculate(int numOne, char @operators, int numTwo)
        {
            double result = 0;
            switch (@operators)
            {
                case '/':
                    result = numOne / numTwo;
                    break;
                case '*':
                    result = numOne * numTwo;
                    break;
                case '+':
                    result = numOne + numTwo;
                    break;
                case '-':
                    result = numOne - numTwo;
                    break;
            }
            return result;
        }
    }
}
