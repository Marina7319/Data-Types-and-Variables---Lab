using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int ch = 1; ch <= num; ch++)
            {
                int sum = ch;
                int specialNum = 0;
                bool isSpecialNum = false;
                while (ch > 0)
                {
                    specialNum += ch % 10;
                    ch = ch / 10;
                }
                isSpecialNum = (specialNum == 5) || (specialNum == 7) || (specialNum == 11);
                Console.WriteLine("{0} -> {1}", sum, isSpecialNum);
                specialNum = 0;
                ch = sum;
            }
        }
    }
}
