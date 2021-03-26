using System;

namespace FourthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{Multiple(number1, number2)}");
        }

        static bool Multiple(int num1, int num2)
        {
            return (num2 % num1 == 0);
        }
    }
}
