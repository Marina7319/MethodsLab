using System;

namespace _5.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantityOfTheProduct = int.Parse(Console.ReadLine());
            switch (product)
            {
                case "coffee":
                    Coffee(quantityOfTheProduct);
                    break;
                case "water":
                    Water(quantityOfTheProduct);
                    break;
                case "coke":
                    Coke(quantityOfTheProduct);
                    break;
                case "snacks":
                    Snake(quantityOfTheProduct);
                    break;
            }
        }
        private static void Snake(int quantityOfTheProduct)
        {
            double sumSnacks = 2 * quantityOfTheProduct;
            Console.WriteLine($"{sumSnacks:f2}");
        }
        private static void Coke(int quantityOfTheProduct)
        {
            double sumCoke = 1.4 * quantityOfTheProduct;
            Console.WriteLine($"{sumCoke:f2}");
        }
        private static void Water(int quantityOfTheProduct)
        {
            Console.WriteLine($"{quantityOfTheProduct:f2}");
        }
        private static void Coffee(int quantityOfTheProduct)
        {
            double sumCoffee = 1.5 * quantityOfTheProduct;
            Console.WriteLine($"{sumCoffee:f2}");
        }
    }
}
