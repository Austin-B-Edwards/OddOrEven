using System;
using System.Runtime.CompilerServices;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            
           bool answer = IsOdd(5);

            Console.WriteLine(answer);
        } 

        // Start here
        public static bool IsOdd(int num)
        {
            // determines if a number is odd 
            if(num % 2 == 0)
            {
                Console.WriteLine($"Odd");
                return true;
            }
            else
            {
                Console.WriteLine($"Even");
                return false;
            }
        }

    }
}
