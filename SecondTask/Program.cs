using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side1:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side2:");
            double side2 = Convert.ToDouble(Console.ReadLine());
                        
            Console.WriteLine($"The hypothenuse of the triangle with sides {side1} and {side2} is {Hypotenuse( side1,  side2)}");
            
            // Console.WriteLine($"{Math.Sqrt(81)}");

        }

        static double Hypotenuse(double first, double second)
        {
            return Math.Sqrt(first * first + second * second);
        }
    }
}
