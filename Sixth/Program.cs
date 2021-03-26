using System;

namespace Sixth
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPerfect();
        }

        static string Perfect(int num)
        {
            int sumCheck = 1; string factors = "1, ";
            for (int i = 2; i <= num / 2; i++)
            {
                if(num % i == 0)
                {
                    sumCheck += i;
                    factors += $"{i}, ";
                }
            }
            if (sumCheck == num)
            {
                // Console.WriteLine($"Perf in");
               Console.WriteLine($"Perfect {num} with factors {factors}"); 
            }
            // Console.WriteLine($"Perf");
            return "";
        }

        static void GetPerfect()
        {
            for (int h = 2; h < 1000; h++)
            {
                Perfect(h);
            }
        }
    }
}
