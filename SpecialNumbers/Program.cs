using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                int sum = 0;
                int currentNum = i;
                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    //124
                    //124 % 10 = 4
                    //124 / 10 = 12

                    //12 % 10 = 2
                    //12 / 10 = 1
                    // 1 % 10 = 1
                    //1 /10 =0
                    //sum = 4 + 2 + 1
                    currentNum = currentNum / 10;
                }
                if (sum == 5 || sum == 11 || sum == 7)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
