using System;
using System.Diagnostics.Metrics;

namespace ALi
{
    class NumberManipulator
    {

        static void Main(string[] args)
        {
            Console.Write($"Enter a number:");
            int num1;
            num1 = Convert.ToInt32(Console.ReadLine());


            if (num1 > 0)
            {
                Console.WriteLine($"Output: The {num1} is positive.");
            }
            else if(num1 < 0)
            {
                Console.WriteLine($"Output: The {num1} is negative.");
            }
            else if(num1 == 0)
            {
                Console.WriteLine($"Output: The {num1} is neither positive nor negative");
            }


        }


    }
}