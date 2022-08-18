using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, times));
        }
        static string RepeatString(string input, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result = result + input;
            }
            return result;
        }
    }
}
