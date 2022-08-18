using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            float pounds = float.Parse(Console.ReadLine());
            double poundsToUsRate = 1.31;
            double result = pounds * poundsToUsRate;
            Console.WriteLine($"{result:f3}");
        }
    }
}
