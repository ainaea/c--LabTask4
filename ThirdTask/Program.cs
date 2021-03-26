using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter hours of parking:");
            int hours = Convert.ToInt32(Console.ReadLine());
                        
            Console.WriteLine($"The total cost of parking for {hours} hour(s) is {Calculate_Charges(hours):C}");
        }

        static decimal Calculate_Charges(int timeCount)
        {
            decimal price;
            
            if (timeCount >= 19)
            {
               price = 10; 
            }else if (timeCount  <= 3)
            {
               price = 2; 
            }
            else{
                price = 2 + ((timeCount - 3) *0.5M);
            }
            return price;
        }
    }
}
