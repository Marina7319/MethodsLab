using System;
using System.Linq;
namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digits = num;
            int numEven = 0;
            int numOdd = 0;
            while (digits != 0)
            {
                GetMultipleOfEvenAndOdds(digits);
                if (GetMultipleOfEvenAndOdds(digits) % 2 != 0)
                {
                    numEven += GetMultipleOfEvenAndOdds(digits);
                }
                else
                {
                    numOdd += GetMultipleOfEvenAndOdds(digits);
                }
                digits = digits / 10;
            }
            Console.WriteLine(Sum(numEven, numOdd));
        }
        static int GetMultipleOfEvenAndOdds(int digits)
        {
            int currentDigit = digits % 10;
            return currentDigit;
        }
        static int Sum(int v1, int v2)
        {
            int sum = v1 * v2;
            return sum;
        }
    }
}
