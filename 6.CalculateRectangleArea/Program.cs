using System;

namespace _6.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateArea(weight, height);
            Console.WriteLine(area);
        }
        private static double CalculateArea(double weight, double height)
        {
            return weight * height;
        }
    }
}
