using System;

namespace FifthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            float number1 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number");
            float number2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third number");
            float number3 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{Minimum3(number1, number2, number3)}");
        }

        static float Minimum3(float num1, float num2, float num3)
        {
            return Math.Min(num1, Math.Min(num2, num3));
        }
    }
}
