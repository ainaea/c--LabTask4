using System;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            int based = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter exponent (negative to quit):");
            int exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{based} to {exponent} is {IntegerPower(based,exponent)}");
        }

        static int IntegerPower(int num, int index)
        {
            if (index < 0)
            {
            return 0;
            }
            int result = 1;
            for (int i = 0; i < index; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
